namespace Memento
{
    public interface IMemento
    {
       public string GetName();
       public string GetState();
       public DateTime GetDate();
    }
}
