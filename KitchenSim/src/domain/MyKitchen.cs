namespace Kitchen;
using System;
using System.Collections.Generic;

public class MyKitchen
{
    public static void UseAppliance(IAppliance appliance, Ingredient ingredient)
    {
        appliance.Use(ingredient);
    }

    public static void UseCondiment(ICondiment condiment, Ingredient ingredient)
    {
        condiment.Use(ingredient);
    }
}