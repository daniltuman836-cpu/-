using RemoteControlLibrary;
using RemoteControlProxy;

namespace ProgramProxy
{
    class ProgramProxy
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
            Console.WriteLine("Пульт с настройками\n");
            RemoteControl.Use(power, settingsDriver);
            Console.WriteLine("Пульт с звуком\n");
            RemoteControl.Use(power, soundDriver);
            Console.WriteLine("Пульт с переключением каналов\n");
            RemoteControl.Use(power, channelDriver);
            Proxy guestProxySettings = new Proxy(settingsDriver, Role.Guest);
            Proxy userProxySound = new Proxy(soundDriver, Role.User);
            Proxy adminProxyChannel = new Proxy(channelDriver, Role.Admin);
            Console.WriteLine("Пульт с настройками в роли Guest");
            RemoteControl.Use(power, guestProxySettings);
            Console.WriteLine("Пульт с звуком в роли User");
            RemoteControl.Use(power, userProxySound);
            Console.WriteLine("Пульт с переключением каналов в роли Admin");
            RemoteControl.Use(power, adminProxyChannel);
        }
    }
}