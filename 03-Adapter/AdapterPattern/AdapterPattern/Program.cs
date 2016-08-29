using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = ChooseServiceType();
            if (service == "string")
            {
                var mealOne = new MealServiceOne().GetMeal();
                Console.Write("you chose: " + mealOne);
                Console.ReadKey();
            }
            if (service == "int")
            {
                var mealTwo = new MealServiceTwo().GetMeal();
                Console.Write("you chose: " + mealTwo);
                Console.ReadKey();
            }
        }
        //decides which service to use 
        public static string ChooseServiceType()
        {
            Console.Write("Would you like to choose by string or int:\n");
            var serviceType = Console.ReadLine();
            if (serviceType != null)
            {
                if (serviceType.ToLower() == "string" || serviceType.ToLower() == "int")
                {
                    return serviceType.ToLower();
                }
            }
            Console.Write("Type better. Enter string or int:");
            return ChooseServiceType();
        }
    }
}
