using System;

public interface IMealPlan
{
    string Name { get; }

    bool Validate();

    void DisplayPlan();
}

public class VegetarianMeal : IMealPlan
{
    public string Name => "Vegetarian";

    public bool Validate()
    {
        return true;
    }

    public void DisplayPlan()
    {
        Console.WriteLine("Vegetarian Meal Plan");
        Console.WriteLine("Food: Vegetables, dairy, grains");
    }
}

public class VeganMeal : IMealPlan
{
    public string Name => "Vegan";

    public bool Validate()
    {
        return true;
    }

    public void DisplayPlan()
    {
        Console.WriteLine("Vegan Meal Plan");
        Console.WriteLine("Food: Vegetables, fruits, grains, legumes");
    }
}

public class KetoMeal : IMealPlan
{
    public string Name => "Keto";

    public bool Validate()
    {
        return true;
    }

    public void DisplayPlan()
    {
        Console.WriteLine("Keto Meal Plan");
        Console.WriteLine("Food: Meat, eggs, cheese, low-carb vegetables");
    }
}

public class HighProteinMeal : IMealPlan
{
    public string Name => "High-Protein";

    public bool Validate()
    {
        return true;
    }

    public void DisplayPlan()
    {
        Console.WriteLine("High-Protein Meal Plan");
        Console.WriteLine("Food: Chicken, eggs, fish, beans");
    }
}

public class Meal<T> where T : IMealPlan
{
    public T MealPlan { get; set; }

    public Meal(T mealPlan)
    {
        MealPlan = mealPlan;
    }

    public void Display()
    {
        Console.WriteLine($"Category: {MealPlan.Name}");

        MealPlan.DisplayPlan();

        Console.WriteLine("----------------------------");
    }
}

public static class MealPlanGenerator
{
    public static T GenerateMealPlan<T>()
        where T : IMealPlan, new()
    {
        T mealPlan = new T();

        if (mealPlan.Validate())
        {
            return mealPlan;
        }

        throw new Exception("Invalid meal plan.");
    }
}