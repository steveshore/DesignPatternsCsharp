using System;

namespace AdapterPattern
{
    //Get meal via int
    public class MealServiceTwo
    {
        public string GetMeal()
        {
            Console.Write("What meal would you like? Please enter the correct number \n(Breakfast = 1, Lunch = 2, or Dinner = 3):\n");
            
            //gets numeric value and converts it to enum
            var meal = (MealEnum)Convert.ToInt32(Console.ReadLine());

                switch (meal)
                {
                    case MealEnum.Breakfast:
                    case MealEnum.Lunch:
                    case MealEnum.Dinner:
                        return meal.ToString();
                }

            Console.Write("That's not a meal. Try again...\n\n");
            return GetMeal();
        }

    }
}