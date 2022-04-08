using Hepsiburada.Domain.ViewModels;
using MediatR;

namespace Hepsiburada.Application.Queries
{
    public class GetByProductIdQuery : IRequest<ProductViewModel>
    {
        public int ProductId { get; protected set; }

        public GetByProductIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
