using Microsoft.Extensions.DependencyInjection;

namespace Hespiburada.Data.EntityFramework.Extensions
{
    public class DataServiceCollection : IDataServiceCollection
    {
        public DataServiceCollection(IServiceCollection serviceCollection)
        {
            ServiceCollection = serviceCollection;
        }

        public IServiceCollection ServiceCollection { get; protected set; }
    }
}
