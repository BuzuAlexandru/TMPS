namespace Kitchen;

class ConsolePrinter
{
    public static void PresentDish(Dish dish)
    {
        Console.WriteLine(dish.name);
        Console.WriteLine();
        foreach (var ingredient in dish.ingredients)
        {
            Console.WriteLine(ingredient.name);
            foreach (var property in ingredient.state)
            {
                Console.WriteLine($"\t{property}");
            }
            Console.WriteLine();
        }
    }
}