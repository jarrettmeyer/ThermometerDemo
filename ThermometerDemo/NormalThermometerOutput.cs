namespace ThermometerDemo
{
    public class NormalThermometerOutput : IThermometerOutput
    {
        public string Message
        {
            get { return "It feels good outside!"; }
        }

        public int Temperature
        {
            get { return 32; }
        }
    }
}
