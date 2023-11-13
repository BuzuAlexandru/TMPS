namespace Kitchen;
public class EnergizedState : State
{
    public EnergizedState(State state)
    {
        energy = 100;
        cook = state.cook;
    }

    public EnergizedState(Cook cook)
    {
        energy = 100;
        this.cook = cook;
    }

    public override void Rest()
    {
        energy = 100;
    }

    public override void Work()
    {
        energy -= 10;
        Thread.Sleep(1000);
        Console.WriteLine($"Energized {cook.name} cooked.");
        if(energy <= 50) cook.State = new TiredState(this);
    }
}