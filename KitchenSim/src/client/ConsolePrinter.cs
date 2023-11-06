namespace Kitchen;

class ConsolePrinter: IPrinter
{
    public void PresentDish(Dish dish)
    {
        Console.WriteLine(dish.name);
        Console.WriteLine();
        foreach (var ingredient in dish.ingredients)
        {
            Console.WriteLine($"\t{ingredient.GetName()}");
            foreach (var property in ingredient.GetState())
            {
                Console.WriteLine($"\t\t{property}");
            }
            Console.WriteLine();
        }
    }

    public void PrintLogs(ILogger logger)
    {
        List<string> log = logger.GetLogs();

        foreach (var entry in log)
        {
            Console.WriteLine(entry);
        }
    }
}