using Microsoft.VisualStudio.TestTools.UnitTesting;
using AWS.LibOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS.LibOne.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void SumTest()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual(5, class1.Sum(1 , 4));
            
        }
    }
}