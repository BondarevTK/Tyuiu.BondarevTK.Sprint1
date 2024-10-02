using Tyuiu.BondarevTK.Sprint1.Task1.V30.Lib;
namespace Tyuiu.BondarevTK.Sprint1.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.AreEqual(ds.Calculate(0), 1);
        }
    }
}