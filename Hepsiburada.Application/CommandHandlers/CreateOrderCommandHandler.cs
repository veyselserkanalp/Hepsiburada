using Ardalis.GuardClauses;
using Hepsiburada.Application.Commands;
using Hepsiburada.Core.Abstraction;
using Hepsiburada.Core.Abstraction.Data;
using Hepsiburada.Domain.AggregatesModel.OrderAggregate;
using Hepsiburada.Domain.AggregatesModel.ProductAggregate;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hepsiburada.Application.CommandHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Order>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;

        public CreateOrderCommandHandler(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }
        public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.AttachAsync<Product>(request.ProductId);

            Guard.Against.Null(product, nameof(product));

            if (product.Id.Equals(default))
            {
                ApplicationContext.ThrowBusinessException("Product not fount ");
            }
            var repository = _unitOfWork.GetRepository<Order>();
            product.Stock = product.Stock - request.Quantity;
            var repositoryProduct = _unitOfWork.GetRepository<Product>();

            await repositoryProduct.MarkForInsertionAsync(product, cancellationToken);

            var order = new Order(request.UnitPrice, request.TotalPrice, request.Discount, request.CampaignId, request.ProductId, request.ProductCode, product.Stock);

            await repository.MarkForInsertionAsync(order, cancellationToken);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return order;
        }
    }
}
