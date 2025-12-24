using Observer;

namespace ProgramObserver
{
    class Program
    {
        static void Main()
        {
            var sensor = new TemperatureSensor();
            var conditioner = new AirConditioner();
            var windows = new Windows();
            sensor.Attach(conditioner);
            sensor.Attach(windows);
            sensor.ChangeTemperature();
            sensor.ChangeTemperature();
            sensor.Detach(windows);
            sensor.ChangeTemperature();
        }
    }

}