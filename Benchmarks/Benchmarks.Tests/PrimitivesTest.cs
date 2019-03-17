// <copyright file="PrimitivesTest.cs">Copyright ©  2019</copyright>
using System;
using Benchmarks;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Benchmarks
{
    /// <summary>This class contains parameterized unit tests for Primitives</summary>
    [PexClass(typeof(Primitives))]
    //[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    //[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class PrimitivesTest
    {
        /// <summary>Test stub for Sum(Int32, Int32)</summary>
        [PexMethod]
        public int PUT_Sum(int x, int y)
        {
            int result = new Primitives().Sum(x, y);
            return result;
            // TODO: add assertions to method PrimitivesTest.PUT_Sum(Int32, Int32)
        }

        [TestMethod]
        public void CUT_Sum()
        {
            int result = new Primitives().Sum(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}
