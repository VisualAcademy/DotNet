using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DotNetCore.Tests
{
    class Person
    {
        public string? Name { get; set; } 
    }

    [TestClass]
    public class NullableReferenceTypeTest
    {
        [TestMethod]
        public void NullableEnableTest()
        {
            Console.WriteLine((new Person()).Name);
        }
    }
}
