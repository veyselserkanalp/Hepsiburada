using Microsoft.Extensions.DependencyInjection;

namespace Hespiburada.Data.EntityFramework.Extensions
{
    public interface IDataServiceCollection
    {
        IServiceCollection ServiceCollection { get; }
    }
}