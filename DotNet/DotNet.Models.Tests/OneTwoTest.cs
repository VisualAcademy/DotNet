using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNet.Models.Tests
{
    [TestClass]
    public class OneTwoTest
    {
        [TestMethod]
        public void OneTwoRepository_GetByMonth_Method_Test()
        {
            var repository = new OneTwoRepository();

            var expected = 333;
            var actual = repository.GetByMonth(3).Two;

            Assert.AreEqual(expected, actual);
        }
    }
}
