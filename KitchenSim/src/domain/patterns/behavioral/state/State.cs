namespace Kitchen;

public abstract class State
{
    protected int energy;
    public Cook? cook;

    public int Energy
    {
        get {return energy;}
        set {energy = value;}
    }

    public abstract void Work();
    public abstract void Rest();
}