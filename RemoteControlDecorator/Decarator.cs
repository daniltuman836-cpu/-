namespace RemoteControlDecorator
{
    public abstract class Decorator : Driver
    {
        private Driver _driver;

        public Decorator(Driver driver)
        {
            _driver = driver;
        }

        public override void Operation()
        {
            _driver.Operation();
        }
    }
}

