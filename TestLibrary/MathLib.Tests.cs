using Common;
namespace TestLibrary
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5,4,9)]
        public void TestAdd(int x, int y, int z)
        {
            MathLib objMath = new MathLib();
            int result = objMath.Add(x,y);
            Assert.AreEqual(z, result);
        }
    }
}