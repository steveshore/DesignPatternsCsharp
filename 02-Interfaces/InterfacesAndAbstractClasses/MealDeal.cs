using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    public abstract class MealDeal
    {
        //Move all like fields and methods to the abstract class so they can be shared
        public string Meal { get; set; }
        public string Entree { get; set; }
        public string Meat { get; set; }
        public string Bread { get; set; }
        public bool Cheese { get; set; }
        public string Drink { get; set; }
        public string Side { get; set; }

        protected abstract MealDeal GetMealDeal(string optionOne, string optionTwo);

        protected string GetDrink()
        {
            Console.Write("What would you like to drink?:\n");
            var drink = Console.ReadLine();

            if (drink != null)
                return drink.ToLower().Trim();

            Console.Write("Please enter a valid drink?:\n");
            return GetDrink();
        }

        protected string GetSide()
        {
            Console.Write("What side would you like?:\n");
            var side = Console.ReadLine();

            if (side != null)
                return side.ToLower().Trim();

            Console.Write("Please enter a valid side?:\n");
            return GetSide();
        }

        //Changed to take options so it can be inherited
        public string GetEntree(string optionOne, string optionTwo)
        {
            Console.Write("Would you like a " + optionOne + " or " + optionTwo + "?:\n");
            var entree = Console.ReadLine();

            if (entree != null)
            {
                entree = entree.ToLower().Trim();

                if (entree == optionOne.ToLower() || entree == optionTwo.ToLower())
                {
                    return entree;
                }
            }

            Console.Write("Your spelling's not great. Try again...\n\n");
            return GetEntree(optionOne, optionTwo);
        }
    }
}
