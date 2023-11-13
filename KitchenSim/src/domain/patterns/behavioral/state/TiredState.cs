namespace Kitchen;

public class TiredState : State
{
    public TiredState(State state)
    {
        energy = state.Energy;
        cook =  state.cook;
    }

    public override void Rest()
    {
        cook.State = new EnergizedState(this);
    }

    public override void Work()
    {
        energy -= 10;
        Thread.Sleep(2000);
        Console.WriteLine($"Tired {cook.name} cooked.");
        if(energy <= 0) cook.State = new OverworkedState(this);
    }
}