using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class CampFire : ICampFire
    {
        readonly DantesCircles _dantesCircles;
        readonly DemonSpawn _demonSpawn;
        readonly Climate _climate;

        public CampFire() : this(new DantesCircles(), new DemonSpawn(), new Climate()) { }

        public CampFire(DantesCircles dantesCircles, DemonSpawn demonSpawn, Climate climate)
        {
            _dantesCircles = dantesCircles;
            _demonSpawn = demonSpawn;
            _climate = climate;
        }

        public CampFireIngredients GetCampFireIngredients(string needForFire)
        {
            return new CampFireIngredients
            {
                Fire = _dantesCircles.Flames(),
                DryWeatherConditions = _climate.Arid(),
                FireWood = _demonSpawn.Sticks(needForFire)
            };
        }
    }
}
