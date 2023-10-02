namespace Kitchen;
using System;
using System.Collections.Generic;

class MyKitchen
{
    // public List<IAppliance> appliances = new();
    
    // public void AddAppliance (IAppliance aplnc)
    // {
    //     this.appliances.Add(aplnc);
    // }

    public static Ingredient UseAppliance(IAppliance appliance, Ingredient ingredient)
    {
        return appliance.Use(ingredient);
    }

    public static Ingredient UseCondiment(ICondiment condiment, Ingredient ingredient)
    {
        return condiment.Season(ingredient);
    }
}