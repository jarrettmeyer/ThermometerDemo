namespace ThermometerDemo
{
    public class ReallyColdThermometerOutput : IThermometerOutput
    {
        public string Message
        {
            get { return "It is really cold out."; }
        }

        public int Temperature
        {
            get { return int.MinValue; }
        }
    }
}
