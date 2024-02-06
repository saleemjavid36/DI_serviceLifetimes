using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    public class Scopped : IScoped
    {
        private readonly Guid number;
        public Scopped()
        {
            number = Guid.NewGuid();
        }
        public string PrintGuidNumber()
        {
            return number.ToString();
        }
    }
}
