using Observer;

namespace ProgramObserver
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sensor = new TemperatureSensor();
            var conditioner = new AirConditioner();
            sensor.Attach(conditioner);
            var windows = new Windows();
            sensor.Attach(windows);
            sensor.ChangeTemperature();
            sensor.ChangeTemperature();
            sensor.ChangeTemperature();
            sensor.Detach(windows);
            sensor.ChangeTemperature();
            Console.WriteLine("\n");
            var sensorEvent = new TemperatureSensorEvent();
            sensorEvent.TemperatureChanged += conditioner.TemperatureChanged;
            sensorEvent.TemperatureChanged += windows.TemperatureChanged;
            sensorEvent.ChangeTemperature();
            sensorEvent.ChangeTemperature();
            sensorEvent.ChangeTemperature();
            sensorEvent.TemperatureChanged -= windows.TemperatureChanged;
            sensorEvent.ChangeTemperature();
        }
    }
}