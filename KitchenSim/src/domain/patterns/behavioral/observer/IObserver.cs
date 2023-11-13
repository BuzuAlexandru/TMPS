namespace Kitchen;

public interface IObserver<T>
{
    public void Update(T subject);
}