using MediatR;

namespace Hepsiburada.Application.Queries
{
    public class ProductCheckByCodeQuery : IRequest<bool>
    {
        public string Code { get; protected set; }

        public ProductCheckByCodeQuery(string code)
        {
            Code = code;
        }

    }
}
