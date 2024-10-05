using Tyuiu.BondarevTK.Sprint1.Task7.V26.Lib;
namespace Tyuiu.BondarevTK.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.AreEqual(ds.Calculate(0, 0), 0.353);
        }
    }
}