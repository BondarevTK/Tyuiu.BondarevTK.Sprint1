using Tyuiu.BondarevTK.Sprint1.Task3.V3.Lib;
namespace Tyuiu.BondarevTK.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.AreEqual(ds.ParallelepipedVolume(2, 2, 2), 8);
        }
    }
}