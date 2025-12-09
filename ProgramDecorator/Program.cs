using RemoteControlLibrary;
using RemoteControlDecorator;

namespace ProgramDecorator
{
    class ProgramDecorator
    {
        static void Main(string[] args)
        {
            Power power = new Power();
            Settings settings = new Settings();
            Sound sound = new Sound();
            Channel channel = new Channel();

            SettingsDriver settingsDriver = new SettingsDriver(settings);
            SoundDriver soundDriver = new SoundDriver(sound);
            ChannelDriver channelDriver = new ChannelDriver(channel);

            Console.WriteLine("Работа пульта\n");
            Driver mainDriver = new Driver();
            RemoteControl.Use(power, mainDriver);

            Console.WriteLine("Пульт с настройками\n");
            mainDriver = new SettingsDecorator(mainDriver, settingsDriver);
            RemoteControl.Use(power, mainDriver);

            Console.WriteLine("Пульт с настройками и звуком\n");
            mainDriver = new SoundDecorator(mainDriver, soundDriver);
            RemoteControl.Use(power, mainDriver);

            Console.WriteLine("Пульт с настройками, звуком и переключением каналов\n");
            mainDriver = new ChannelDecorator(mainDriver, channelDriver);
            RemoteControl.Use(power, mainDriver);
        }
    }
}