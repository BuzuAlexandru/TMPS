namespace Kitchen;

public class Cook: ICook
{
    public string name;
    private State state;

    public Cook(string name)
    {
        this.name = name;
        state = new EnergizedState(this);
    }

    public double Energy
    {
        get { return state.Energy; }
    }
    public State State
    {
        get { return state; }
        set { state = value; }
    }

    public void Rest()
    {
        state.Rest();
    }

    public void Work()
    {
        state.Work();
    }
}