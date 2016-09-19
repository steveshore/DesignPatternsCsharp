using System;

namespace AdapterPattern
{
    class Program
    {
        private static ITarget _target = new MealAdapter();

        public Program(ITarget target)
        {
            _target = target;
        }

        static void Main(string[] args)
        {
            //The application needing this information implements ITarget interface.
            //Implement an Adapter so it to make it work
            //Read this for reference
            //http://www.dotnet-tricks.com/Tutorial/designpatterns/Y3OI080713-Adapter-Design-Pattern---C

            //var meal = new MealEnumService().GetMealEnum();


            var meal = _target.GetMealString();

            Console.Write("you chose: " + meal);
            Console.ReadKey();
        }
    }
}

