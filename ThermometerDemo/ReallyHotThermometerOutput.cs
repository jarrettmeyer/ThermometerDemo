namespace ThermometerDemo
{
    public class ReallyHotThermometerOutput : IThermometerOutput
    {
        public string Message
        {
            get { return "It is really hot out."; }
        }

        public int Temperature
        {
            get { return 100; }
        }
    }
}
