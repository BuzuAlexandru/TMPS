namespace Kitchen;

public abstract class Subject<T>
{
    protected readonly List<IObserver<T>> observers = new();
    public virtual void Attach(IObserver<T> observer)
    {
        observers.Add(observer);
    }
    public virtual void Detach(IObserver<T> observer)
    {
        observers.Remove(observer);
    }
    public abstract void Notify();
}