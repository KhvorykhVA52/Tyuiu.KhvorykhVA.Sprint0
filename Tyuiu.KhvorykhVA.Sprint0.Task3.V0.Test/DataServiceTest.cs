using Tyuiu.KhvorykhVA.Sprint0.Task3.V0.Lib;
namespace Tyuiu.KhvorykhVA.Sprint0.Task3.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckValid()

        {
            Assert.AreEqual(10, DataServise.Sum(5, 5));
        }
    }
}