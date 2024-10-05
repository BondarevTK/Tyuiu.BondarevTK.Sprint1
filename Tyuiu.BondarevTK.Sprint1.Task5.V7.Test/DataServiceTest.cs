using Tyuiu.BondarevTK.Sprint1.Task5.V7.Lib;
namespace Tyuiu.BondarevTK.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.AreEqual(ds.AngleToHoursMinutes(360), 12);
        }
    }
}