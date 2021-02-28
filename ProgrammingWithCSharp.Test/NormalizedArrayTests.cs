using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingwithCSharp;

namespace ProgrammingWithCSharp
{
    [TestClass]
    public class NormalizedArrayTests
    {
        [TestMethod]
        public void NormalizeArrayTest1()
        {
            NormalizeArray normalizeArray = new NormalizeArray();
            var actualArray = new[] {1, 2, 3, 4, 5};
            var exceptedArray = new[] {1, 2, 3, 4, 5};

            var resultArray=   normalizeArray.DoNormalization(actualArray);

            Assert.AreEqual(actualArray.Length, resultArray.Length);
            for (int i = 0; i < actualArray.Length; i++)
            {
                Assert.AreEqual(exceptedArray[i], resultArray[i]);
            }
        }
        [TestMethod]
        public void NormalizeArrayTest2()
        {
            NormalizeArray normalizeArray = new NormalizeArray();
          
            var actualArray = new[] {1,2,5,1,2}; 
            var exceptedArray = new[] {0,3,5,1,2};

            var resultArray=   normalizeArray.DoNormalization(actualArray);
            Assert.AreEqual(actualArray.Length, resultArray.Length);
            for (int i = 0; i < actualArray.Length; i++)
            {
                Assert.AreEqual(exceptedArray[i], resultArray[i]);
            }
        }

        [TestMethod]
        public void NormalizeArrayTest3()
        {
            NormalizeArray normalizeArray = new NormalizeArray();
            var actualArray = new[] {5,7,4,3,3,1}; 
            var exceptedArray = new[] {5, 7, 4, 6, 3, 1};

            var resultArray=   normalizeArray.DoNormalization(new[] {5,7,4,3,3,1});
            for (int i = 0; i < actualArray.Length; i++)
            {
                Assert.AreEqual(exceptedArray[i], resultArray[i]);
            }
        }
    }
}
