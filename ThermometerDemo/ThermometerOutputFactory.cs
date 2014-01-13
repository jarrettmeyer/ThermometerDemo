using System.Linq;
using Ninject;

namespace ThermometerDemo
{
    public class ThermometerOutputFactory
    {
        private readonly IKernel kernel;

        public ThermometerOutputFactory(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public IThermometerOutput GetOutputForTemperature(int temperature)
        {
            var output = kernel.GetAll<IThermometerOutput>()
                .Where(to => temperature >= to.Temperature)
                .OrderBy(to => to.Temperature)
                .Last();
            return output;
        }
    }
}
