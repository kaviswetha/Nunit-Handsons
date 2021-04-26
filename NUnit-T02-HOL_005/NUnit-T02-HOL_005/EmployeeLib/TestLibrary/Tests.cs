using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;
using NUnit.Framework;

namespace TestLibrary
{
    [TestFixture]
    public class Tests
    {
        EmployeeManager em = new EmployeeManager();
        [TestCase]
        public void TestCase_AddEmployees()
        {
            try
            {
                int beforeInsert = em.HeadCount;
                Employee e = new Employee
                {
                    Id = 101,
                    Name = "Steve"
                };
                em.AddEmployee(e);
                int afterInsert = em.HeadCount;
                Assert.AreNotEqual(beforeInsert, afterInsert);
            }
            catch(Exception)
            {
                Assert.Fail("Insertion failed");
            }
        }
        [TestCase]
        public void TestCase_NullException()
        {
            Employee e = new Employee
            {
                Id = 103,
                Name =null
            };
            Assert.Throws<ArgumentNullException>(() => em.AddEmployee(e));
        }

    }
}
