using Tyuiu.BondarevTK.Sprint1.Task6.V17.Lib;
namespace Tyuiu.BondarevTK.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.IsTrue(ds.CheckPalindrome("lol"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(DataService.Reverse("lolol"), "lolol");
        }
    }
}