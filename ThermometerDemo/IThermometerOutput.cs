namespace ThermometerDemo
{
    public interface IThermometerOutput
    {
        string Message { get; }
        int Temperature { get; }
    }
}
