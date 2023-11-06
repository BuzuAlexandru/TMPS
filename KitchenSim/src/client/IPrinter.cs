namespace Kitchen;

public interface IPrinter
{
    public void PresentDish(Dish dish);
    public void PrintLogs(ILogger logger);
} 