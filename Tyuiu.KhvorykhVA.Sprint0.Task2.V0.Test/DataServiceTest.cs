using Tyuiu.KhvorykhVA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KhvorykhVA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVaild()
        {
            var name = "������";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("������, ������", res);




        }


    }
}