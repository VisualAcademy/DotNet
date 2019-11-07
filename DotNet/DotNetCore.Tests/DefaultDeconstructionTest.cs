using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetCore.Tests
{
    [TestClass]
    public class DefaultDeconstructionTest
    {
        [TestMethod]
        public void DefaultTest()
        {
            (int number, string? name) = (default, default);

            Assert.AreEqual(0, number);
            Assert.IsNull(name);
        }
    }
}
