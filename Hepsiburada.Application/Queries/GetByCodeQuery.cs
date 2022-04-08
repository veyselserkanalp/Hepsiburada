using Hepsiburada.Domain.ViewModels;
using MediatR;

namespace Hepsiburada.Application.Queries
{
    public class GetByCodeQuery : IRequest<ProductViewModel>
    {
        public string ProductCode { get; protected set; }

        public GetByCodeQuery(string productCode)
        {
            ProductCode = productCode;
        }
    }
}
