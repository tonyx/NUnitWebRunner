using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace NunitWebRunner.tests
{
    [TestFixture]
    public class TemplateTestClass
    {
        [Test]
        public void TestThatPasses()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TestThatFails()
        {
            Assert.AreEqual(4,5);
        }

        [Test]
        [Ignore]
        public void IgnoredeTest()
        {
            Assert.IsTrue(false);
        }
    }
}
