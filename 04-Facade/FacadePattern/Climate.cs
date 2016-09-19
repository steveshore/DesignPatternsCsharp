using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Climate
    {
        public string Tropical()
        {
            return "Wet Conditions";
        }

        public string Arid()
        {
            return "Dry Conditions";
        }

        public string Subtropical()
        {
            return "Humid Conditions";
        }
    }
}
