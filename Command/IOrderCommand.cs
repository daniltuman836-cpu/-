namespace Command
{
    public interface IOrderCommand
    {
        void Execute();
        void Undo();
    }
}
