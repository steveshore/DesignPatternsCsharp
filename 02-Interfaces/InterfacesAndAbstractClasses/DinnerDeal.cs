using System;

namespace InterfacesAndAbstractClasses
{
    //Implement Meal and IOrder
    public class DinnerDeal : MealDeal, IOrder
    {

        //These all look different, but share very 
        //similar signatures and similar functionality

        //This method finishes the dinner order by 
        //filling in the final entree specific details
        public MealDeal GetOrder(string optionOne, string optionTwo)
        {
            var meal = GetMealDeal(optionOne, optionTwo);

            if (meal.Entree == optionOne)
            {
                Console.Write("Would you like ribeye or sirloin steak?:\n");
                meal.Meat = Console.ReadLine().ToLower().Trim();
            }

            if (meal.Entree == optionTwo)
            {
                Console.Write("Would you like chicken breast or thigh?:\n");
                meal.Meat = Console.ReadLine().ToLower().Trim();
            }

            Console.Write("Would you like an italian or rye bread roll?:\n");
            meal.Bread = Console.ReadLine().ToLower().Trim();

            Console.Write("Would you like a shredded parmesan cheese? (yes or no):\n");
            meal.Cheese = Console.ReadLine().ToLower().Trim() == "yes";

            return meal;
        }

        //This method prints out a completed order
        public void PrintOrder(MealDeal meal)
        {
            var cheese = meal.Cheese ? "with shredded parmesan" : "without shredded parmesan";

            Console.Write("You ordered a " + meal.Meat + " " + meal.Entree + " " + cheese + " with a " + meal.Bread + " bread roll " + " and\n" + meal.Side + " on the side with " + meal.Drink + " to drink (press enter to exit)");
            Console.ReadKey();
        }

        //This method gets the basic Meal so the appropriate 
        //entree specific questions can then be asked
        override protected MealDeal GetMealDeal(string optionOne, string optionTwo)
        {
            return new DinnerDeal
            {
                Entree = GetEntree(optionOne, optionTwo),
                Drink = GetDrink(),
                Side = GetSide()
            };
        }
    }
}
