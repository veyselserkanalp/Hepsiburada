using Hepsiburada.Core.Abstraction.Exceptions;

namespace Hepsiburada.Core.Abstraction
{
    public static class ApplicationContext
    {
        public static void ThrowBusinessException(string message)
        {
            throw new BusinessException(message);
        }

    }
}
