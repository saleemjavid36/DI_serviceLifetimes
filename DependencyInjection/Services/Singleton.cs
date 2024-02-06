using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    public class Singleton:ISingleton
    {
        private readonly Guid number;
        public Singleton()
        {
            number = Guid.NewGuid();
        }
        public string PrintGuidNumber()
        {
            return number.ToString();
        }
    }
}
