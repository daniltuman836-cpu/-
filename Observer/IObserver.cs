using System.Runtime.InteropServices.JavaScript;

namespace Observer
{
    public interface IObserver
    {
        void Update(TemperatureSensor subject);
    }
}
