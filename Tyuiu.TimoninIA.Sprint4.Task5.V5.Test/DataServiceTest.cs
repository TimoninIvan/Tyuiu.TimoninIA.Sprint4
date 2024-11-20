using Tyuiu.TimoninIA.Sprint4.Task5.V5.Lib;
namespace Tyuiu.TimoninIA.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] ar = {{6, 5, 6, 7, 3 },

                        {5, 4, 6, 7, 3 },

                        {5, 5, 5, 6, 5 },

                        {6, 5, 4, 4, 3 },

                        {4, 5, 4, 5, 5 }};
            int wait = 123;
            int res = ds.Calculate(ar);
            Assert.AreEqual(wait, res);
        }
    }
}