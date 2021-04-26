using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;
using NUnit.Framework;

namespace TestLibrary
{
    [TestFixture]
    public class Tests
    {
        
        Calculator c = new Calculator();
        [TestCase]
        public void TestCheck_NullException()
        {
            
            Assert.Throws<ArgumentNullException>(() =>c.Divide(5,0) );
        }
       
    }
}
