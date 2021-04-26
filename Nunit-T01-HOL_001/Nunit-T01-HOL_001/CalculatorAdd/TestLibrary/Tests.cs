using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add reference of CalculatorLib
using CalculatorLib;
//add NUnit FrameWork package
using NUnit.Framework;

namespace TestLibrary
{
    //To understand Tests is a TestClass we add [TestFixture] for NUnit Framework to recognise
    [TestFixture]
    public class Tests
    {
        //The below method is a Test method we add [TestCase] for NUnit Framework to recognise
        [TestCase]
        public void TestAdditionIfArgsAreGreaterThanZero()
        {
            Calculator c = new Calculator();
            int result = c.Add(2, 3);
            //Assert.That():Assert class of NUnit contains static method That()
            //That() takes two arguments
            //That(actual_result,Is.EqualTo(desired_result)) returns a boolean result.
            //If result is true testcases pass else fail
            Assert.That(result, Is.EqualTo(5));

        }
        [TestCase]
        public void TestAdditionForNumberLessOrEqualToZero()
        {
            Calculator c = new Calculator();
            int result = c.Add(-8, -1);
            Assert.That(result,Is.EqualTo(0));
        }
    }
}
