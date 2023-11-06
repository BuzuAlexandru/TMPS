namespace Kitchen;

public class PrinterCommand: ICommand
{
    readonly IPrinter printer;
    Dish dish; 
    public PrinterCommand(IPrinter printer, Dish dish)
    {
        this.printer = printer;
        this.dish = dish;
    }

    public Dish Dish
    {
        set { dish = value; }
    }

    public void Execute()
    {
        printer.PresentDish(dish);
    }
}