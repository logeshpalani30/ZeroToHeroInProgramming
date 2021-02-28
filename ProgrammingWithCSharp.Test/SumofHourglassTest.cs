using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingwithCSharp;
using System;

namespace ProgrammingWithCSharp.Test
{
    [TestClass]
    public class SumofHourglassTest
    {
        [TestMethod]
        public void TestBasicArray()
        {
            var someOfHours = new SumofHourglass();
            var arr = new int[6][]
            {
                new []{1,1,1,0,0,0 },
                new []{0,1,0,0,0,0 },
                new []{1,1,1,0,0,0 },
                new []{0,0,0,0,0,0 },
                new []{0,0,0,0,0,0 },
                new []{0,0,0,0,0,0 }
            };
            Assert.AreEqual(7, someOfHours.GetMaxSumofHourglass(arr));
        }
           
        [TestMethod]
        public void TestMediumArray()
        {
            var someOfHours = new SumofHourglass();
           var arr = new int[6][]
            {
                new []{1,1,1,0,0,0 },
                new []{0,1,0,0,0,0 },
                new []{1,1,1,0,0,0 },
                new []{0,0,2,4,4,0 },
                new []{0,0,0,2,0,0 },
                new []{0,0,1,2,4,0 }
            };
            Assert.AreEqual(19, someOfHours.GetMaxSumofHourglass(arr));
        }

        [TestMethod]
        public void TestComplexArray()
        {
            var arrString = "-1 -1 0 -9 -2 -2 " +
                "-2 -1 -6 -8 -2 -5 " +
                "-1 -1 -1 -2 -3 -4 " +
                "-1 -9 -2 -4 -4 -5 " +
                "-7 -3 -3 -2 -9 -9 " +
                "-1 -3 -1 -2 -4 -5";
            var arr = new int[6][];

            for (int i = 0;i < 6; i++) 
                arr[i] = Array.ConvertAll(arrString.Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            
            var someOfHours = new SumofHourglass();
            Assert.AreEqual(-5, someOfHours.GetMaxSumofHourglass(arr));
        }
    }
}
