namespace Kitchen;

class ConsolePrinter
{
    public static void PresentDish(Dish dish)
    {
        Console.WriteLine(dish.name);
        Console.WriteLine();
        foreach (var ingredient in dish.ingredients)
        {
            Console.WriteLine($"\t{ingredient.name}");
            foreach (var property in ingredient.state)
            {
                Console.WriteLine($"\t\t{property}");
            }
            Console.WriteLine();
        }
    }

    public static void PrintLogs()
    {
        List<string> log = Logger.Instance.GetLogs();

        foreach (var entry in log)
        {
            Console.WriteLine(entry);
        }
    }
}