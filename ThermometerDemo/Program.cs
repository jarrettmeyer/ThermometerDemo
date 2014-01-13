using System;
using Ninject;

namespace ThermometerDemo
{
    class Program
    {
        private static IKernel kernel;

        static void Main(string[] args)
        {
            ConfigureKernel();

            Console.Write("Enter a temp: ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            var factory = new ThermometerOutputFactory(kernel);
            var output = factory.GetOutputForTemperature(temperature);

            Console.Write(output.Message);
            Console.ReadLine();
        }

        private static void ConfigureKernel()
        {
            kernel = new StandardKernel();

            // By putting all your bindings here, if you come up with a new output,
            // there is no need to modify your ThermometerOutputFactory class.
            kernel.Bind<IThermometerOutput>().To<ReallyColdThermometerOutput>();
            kernel.Bind<IThermometerOutput>().To<NormalThermometerOutput>();
            kernel.Bind<IThermometerOutput>().To<ReallyHotThermometerOutput>();
        }
    }
}
