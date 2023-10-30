namespace Kitchen;
using System;
using System.Collections.Generic;

public class MyKitchen
{
    public static void UseAppliance(IAppliance appliance, Ingredient ingredient)
    {
        ILogger logger = new LoggerProxy(Logger.Instance, "1111");
        appliance.UseAppliance(ingredient, logger);
    }

    public static void UseCondiment(ICondiment condiment, Ingredient ingredient)
    {
        ILogger logger = new LoggerProxy(Logger.Instance, "1111");
        condiment.UseCondiment(ingredient, logger);
    }
}