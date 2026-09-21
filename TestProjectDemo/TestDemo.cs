using ClassLibraryDemo;
namespace TestProjectDemo
{
    [TestClass]
    public sealed class TestDemo
    {
        [TestMethod]
        public void TestMethodSum()
        {
            int a = 1;
            int b = 2;

            //int res = a + b;
            ClassDemo cd = new ClassDemo();

            int res = cd.Sum(a, b);

            int resWaite = 3;

            Assert.AreEqual(resWaite, res);

        }

        [TestMethod]
        public void TestMethodMinus()
        {
            int a = 2;
            int b = 1;

            int res = ClassDemo.Minus(a, b);

            int resWaite = 1;

            Assert.AreEqual(resWaite, res);
        }
    }
}  
    