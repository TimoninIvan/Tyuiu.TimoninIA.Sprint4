using Tyuiu.TimoninIA.Sprint4.Task6.V29.Lib;
namespace Tyuiu.TimoninIA.Sprint4.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string[] array = new string[4] { "�����", "����", "�����", "����" };
            int res = ds.Calculate(array);
            int wait = 2;

            Assert.AreEqual(wait, res);

        }
    }
}