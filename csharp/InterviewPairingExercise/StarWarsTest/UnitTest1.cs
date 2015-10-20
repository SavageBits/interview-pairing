using System;
using NUnit.Framework;
using StarWars;

namespace StarWarsTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void DoSomething_ShouldReturn1()
        {
            Class1 testClass1 = new Class1();

            Assert.AreEqual(1, testClass1.DoSomething());
        }
    }
}
