using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Benchmarks.Tests
{
    [TestClass]
    public partial class StackTest
    {

        [TestMethod]
        public void StackPeek()
        {
            StackA s = new StackA(1);
            s.push(2);
            var result = s.peekA();
            Assert.AreEqual(2, result);
        }
    }
}
