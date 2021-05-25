using NUnit.Framework;

namespace Tests
{
    public class MainTests
    {
        [Test]
        public void MainTestsSimplePasses()
        {
            Assert.AreEqual(2 + 2, 4);
        }
    }
}
