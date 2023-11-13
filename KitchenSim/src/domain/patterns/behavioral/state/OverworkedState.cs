namespace Kitchen;

public class OverworkedState : State
{
    public OverworkedState(State state)
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
        Console.WriteLine($"Overworked {cook.name} cannot cook anymore.");
    }
}