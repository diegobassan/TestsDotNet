﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Name = "Conan";
            hero.HeroClass = "Babarian";
            hero.Level = 33;

            string name = new HeroService().GenerateHeroName(hero.Name, hero.HeroClass, hero.Level);

            Console.WriteLine("Teste");
            Console.ReadKey();
        }
    }
}
