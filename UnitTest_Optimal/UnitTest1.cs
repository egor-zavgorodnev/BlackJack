using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using BlackJack;

namespace UnitTest
{
    [TestClass]
    public class OptimalTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Optimal opt = new Optimal(new List<int>() { 10, 7, 4, 2, 7, 6 });
            int expected_output = 1;

            int output = opt.GetWinsCount();

            Assert.AreEqual(expected_output, output);
        }

        [TestMethod]  
        public void TestMethod2()
        {
            Optimal opt = new Optimal(new List<int>() { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });
            int expected_output = 3;

            int output = opt.GetWinsCount();

            Assert.AreEqual(expected_output, output);
        }
 
        [TestMethod] 
        public void TestMethod3()
        {
            Optimal opt = new Optimal(new List<int>() { 10, 10, 10, 10, 8 });
            int expected_output = 0;

            int output = opt.GetWinsCount();

            Assert.AreEqual(expected_output, output);
        }
         
        [TestMethod]
        public void TestMethod4() 
        {
            Optimal opt = new Optimal(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            int expected_output = 1;
             
            int output = opt.GetWinsCount();

            Assert.AreEqual(expected_output, output);
        }  
    }  
}
    
  