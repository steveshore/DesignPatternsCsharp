using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MealAdapter : MealEnumService, ITarget
    {
        public string GetMealString()
        {
            return GetMealEnum().ToString();
        }
    }
}
