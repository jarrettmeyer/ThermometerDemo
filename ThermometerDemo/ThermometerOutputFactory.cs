using System.Collections.Generic;
using System.Linq;

namespace ThermometerDemo
{
    public class ThermometerOutputFactory
    {
        private readonly IEnumerable<IThermometerOutput> outputs;

        public ThermometerOutputFactory(IEnumerable<IThermometerOutput> outputs)
        {
            this.outputs = outputs;
        }

        public IThermometerOutput GetOutputForTemperature(int temperature)
        {
            var output = outputs
                .Where(to => temperature >= to.Temperature)
                .OrderBy(to => to.Temperature)
                .Last();
            return output;
        }
    }
}
