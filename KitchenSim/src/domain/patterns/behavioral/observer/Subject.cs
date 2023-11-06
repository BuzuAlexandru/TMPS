namespace Kitchen;

public abstract class Subject
{
    private readonly List<IObserver> observers = new List<IObserver>();
    public virtual void Attach(IObserver observer)
    {
        observers.Add(observer);
    }
    public virtual void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }
    public virtual void Notify()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(this);
        }
    }
}