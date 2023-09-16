namespace dotnetunit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 10;
            var b = 20;
            var c = a + b;
            var result = 30;
            Assert.AreEqual(c, result);
        }
    }
}