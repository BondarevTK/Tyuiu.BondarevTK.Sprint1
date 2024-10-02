using Tyuiu.BondarevTK.Sprint1.Task2.V5.Lib;

namespace Tyuiu.BondarevTK.Sprint1.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.AreEqual(ds.CalculateSideSquare(2), 4);
        }
    }
}