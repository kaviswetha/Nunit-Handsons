using System;
using System.Collections;
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
    /*Optional Attribute:
     *[Category]:This is used to group same type of operations under  a category.
     
    * [Author]:Using this attribute we can write name,email etc of tester who
                have done unit testing.
    *[Ignore]:This attribute is used to ignore a testcase during testrun
    *[Order]:Order will specify the order in which test methods will be executed
    *[TestCaseSource]:This will define an array or IEnumerable collection
            of values against which testmethods can be tested

    */

    //Mandatory 
    //To understand Tests is a TestClass we add [TestFixture] for NUnit Framework to recognise
    [TestFixture,Author("Nikitha","nikitha.joy@cognizant.com")]
    public class Tests
    {
        //The below method is a Test method we add [TestCase] for NUnit Framework to recognise
        [TestCase,Category("Math"),Order(1)]
        
        public void TestAdditionIfArgsAreGreaterThanZero()
        {
            Calculator c = new Calculator();
            int result = c.Add(2,3);
            //Assert.That():Assert class of NUnit contains static method That()
            //That() takes two arguments
            //That(actual_result,Is.EqualTo(desired_result)) returns a boolean result.
            //If result is true testcases pass else fail
            Assert.That(result, Is.EqualTo(5));

        }
        [TestCase,Category("Math"),Order(2)]
        public void TestAdditionForNumberLessOrEqualToZero()
        {
            Calculator c = new Calculator();
            int result = c.Add(-8, -1);
            Assert.That(result,Is.EqualTo(0));
        }

        [TestCase,Category("Math"), Order(3)]
        public void TestDivisionIfArgsAreGreaterThanZero()
        {
            Calculator c = new Calculator();
            int result = c.Divide(4, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        //[Ignore("No need to run right now")]

        [TestCase,Category("Math"), Order(4)]
        public void TestDivisionForNumberLessOrEqualToZero()
        {
            Calculator c = new Calculator();
            int result = c.Divide(2, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase,Category("Math"), Order(5)]
        public void TestMultiplicationIfArgsAreGreaterThanZero()
        {
            Calculator c = new Calculator();
            int result = c.Multiply(4, 2);
            Assert.That(result, Is.EqualTo(8));
        }
        [TestCase,Category("Math"), Order(6)]
        public void TestMultiplicationForNumberLessOrEqualToZero()
        {
            Calculator c = new Calculator();
            int result = c.Multiply(2, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase,Category("Math"), Order(7)]
        public void TestSubtractionIfArgsAreGreaterThanZero()
        {
            Calculator c = new Calculator();
            int result = c.Subtract(4, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        [TestCase,Category("Math"),Order(8)]
        public void TestSubtractionForNumberLessOrEqualToZero()
        {
            Calculator c = new Calculator();
            int result = c.Subtract(-2, -4);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        //[TestCaseSource(nameof(AddTestCases))]
        [TestCaseSource(typeof(AddCases))]
        public void TestAddTestIfArgsAreGreaterThanZero(int a,int b)
        {
            Calculator c = new Calculator();
            int result = c.AddTest(a,b);
            Assert.That(result, Is.EqualTo(a+b));
        }

        /*static readonly object[] AddTestCases =
        {
            new object[]{1,1},
            new object[]{50,50},
            new object[]{22,13}
        };*/
        class AddCases:IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { 1, 1 };
                yield return new object[] { 5, 50 };
                yield return new object[] { 55, 56 };

            }
        }
    }
}
