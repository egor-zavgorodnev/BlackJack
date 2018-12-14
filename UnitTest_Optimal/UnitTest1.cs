using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest_Optimal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Optimal = new BlackJack.Optimal();

             Optimal.c = new List<int>{ 1,2, 3,4,5,10,8,7};
             var s = Optimal.GetWinsCount();


        }
    }
}
