using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsDotNet.Tests
{
    [TestFixture]
    public class HeroTest
    {
        [Test]
        public void TestHeroName()
        {
            Hero hero = new Hero();
            hero.Name = "Conan";
            hero.HeroClass = "Babarian";
            hero.Level = 33;

            string name = new HeroService().GenerateHeroName(hero.Name, hero.HeroClass, hero.Level);

            Assert.AreEqual("Conan Babarian #33", new HeroService().GenerateHeroName(hero.Name, hero.HeroClass, hero.Level));
        }
    }
}
