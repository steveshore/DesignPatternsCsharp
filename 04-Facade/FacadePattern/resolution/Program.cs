using System;

namespace FacadePattern
{
    class ProgramResolution
    {
        //This uses the Facade Pattern 
        static void Main1(string[] args)
        {
            const string needForFire = "Desire For Camp Fire";

            var campFire = new CampFire();

            var campFireIngredients = campFire.GetCampFireIngredients(needForFire);

            Console.WriteLine("FACADE PATTERN: For an amazing campfire please include the following " + campFireIngredients.Fire + ", " + campFireIngredients.FireWood + " and " + campFireIngredients.DryWeatherConditions);
            Console.ReadKey();
        }
    }
}
