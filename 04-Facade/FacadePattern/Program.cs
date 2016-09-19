using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        //The Facade Pattern is all about making the code easier to use. This is done by separating concerns.
        //The code below gets the job doesn't make a lot of logical sense.
        //Our goal is to take these elements and apply them in a way that makes the code more readable and maintainable.
        //The Facade Pattern does this by creating a new way to interface with the existing logic that is specific to the needs at hand.
        //http://www.dofactory.com/net/facade-design-pattern
        static void Main(string[] args)
        {
            const string arsonistTendencies = "Desire For Camp Fire";

            DantesCircles dantesCircles = new DantesCircles();
            string fire = dantesCircles.Flames();

            DemonSpawn demonSpawn = new DemonSpawn();
            string fireWood = demonSpawn.Sticks(arsonistTendencies);

            Climate climate = new Climate();
            string dryWeatherConditions = climate.Arid();

            Console.WriteLine("For an amazing campfire please include the following " + fire + ", " + fireWood + " and " + dryWeatherConditions);
            Console.ReadKey();
        }
    }
}
