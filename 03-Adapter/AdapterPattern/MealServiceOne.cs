using System;

namespace AdapterPattern
{
    //Get meal via string
    public class MealServiceOne
    {
        public string GetMeal()
        {
            Console.Write("What meal would you like? (Breakfast, Lunch, or Dinner):\n");
            var meal = Console.ReadLine();
            if (meal != null)
            {
                switch (meal.ToLower())
                {
                    case "breakfast":
                    case "lunch":
                    case "dinner":
                        return meal;
                }

            }

            Console.Write("That's not a meal. Try again...\n\n");
            return GetMeal();
        }

    }
}
