namespace State
{
    public interface IState
    {
            IState InsertQuarter();
            IState EjectQuarter();
            IState TurnCrank();
            IState Dispense();
        
    }
}
