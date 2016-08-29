using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MealServiceTwo
    {
        public string GetMeal()
        {
            Console.Write("What meal would you like? Please enter the correct number (Breakfast = 1, Lunch = 1, or Dinner = 4):\n");
            var meal = Convert.ToInt32(Console.ReadLine());
            if (meal != null)
            {
                switch ((MealEnum)meal)
                {
                    case meal.Breakfast:
                    case meal.Lunch:
                    case meal.Dinner:
                        return meal.ToString();
                }

            }

            Console.Write("That's not a meal. Try again...\n\n");
            return GetMeal();
        }

    }
}