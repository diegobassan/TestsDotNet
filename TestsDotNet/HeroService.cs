using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsDotNet
{
    public class HeroService
    {
        public string GenerateHeroName(string name, string heroClass, double level)
        {
            string heroName = string.Empty;

            heroName = string.Format(name + " " + heroClass + " #" + level);

            return heroName;
        }
    }
}
