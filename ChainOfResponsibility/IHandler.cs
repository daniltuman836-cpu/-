namespace ChainOfResponsibility
{
    public interface IHandler
    {
        object Handle(object request);
    }
}
