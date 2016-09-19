using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class DemonSpawn
    {
        public string Lucifer(string expectedOutcomeFromInteractions)
        {
            return "Discomfort";
        }

        public string Mephisto(string expectedOutcomeFromInteractions)
        {
            return Lucifer(expectedOutcomeFromInteractions);
        }

        public string Trigon(string expectedOutcomeFromInteractions)
        {
            return Lucifer(expectedOutcomeFromInteractions);
        }

        public string Balrog(string Gandolf)
        {
            return "Not Passing";
        }

        public string PitchForks(string badIntentions)
        {
            return "Puncture Wounds";
        }

        public string Sticks(string arsonistTendencies)
        {
            return "Kindling";
        }
    }
}
