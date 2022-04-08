using Hepsiburada.Application.Commands;
using Hepsiburada.Application.Queries;
using Hepsiburada.Core.Abstraction;
using Hepsiburada.Core.Abstraction.Data;
using Hepsiburada.Domain.AggregatesModel.ProductAggregate;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hepsiburada.Application.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }
        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var isProductExists = await _mediator.Send(new ProductCheckByCodeQuery(request.ProductCode), cancellationToken);

            if (isProductExists)
            {
                ApplicationContext.ThrowBusinessException("Product already has!");
            }

            var repository = _unitOfWork.GetRepository<Product>();

            var product = new Product(request.Name, request.ProductCode, request.Stock, request.CurrentPrice);

            await repository.MarkForInsertionAsync(product, cancellationToken);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return product;
        }
    }
}
