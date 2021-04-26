using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using NUnit.Framework;


namespace TestLibrary
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCaseSource(nameof(CompareTwoNumbersTestData))]
        public void TestCheck_TwoNumbersComparison(int firstNo,int secondNo,int test_result)
        {
            try
            {
                MathLib ml = new MathLib();
                int result = ml.CompareTwoNumbers(firstNo, secondNo);
                Assert.AreEqual(result, test_result);
            }
            catch(Exception)
            {
                Assert.Fail("Both results does not match");
            }
        }
     

        private static IEnumerable<TestCaseData> CompareTwoNumbersTestData
        {
            get
            {
                yield return new TestCaseData(-1, 0, 0);
                yield return new TestCaseData(1, 2, -1);
                yield return new TestCaseData(2, 1, 1) ;
            }
            
         
                
            
        }

    }
}
