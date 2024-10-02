using Tyuiu.BondarevTK.Sprint1.Task0.V20.Lib;
namespace Tyuiu.BondarevTK.Sprint1.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.AreEqual(ds.Calculate(), 13);
        }
    }
}