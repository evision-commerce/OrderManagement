// <copyright file="CoreTest.cs">Copyright ©  2020</copyright>
using System;
using System.Threading.Tasks;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using OrderManagement;

namespace OrderManagement.Tests
{
    /// <summary>This class contains parameterized unit tests for Core</summary>
    [PexClass(typeof(Core))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    public partial class CoreTest
    {
        /// <summary>Test stub for InitializeCore()</summary>
        [PexMethod]
        public Task InitializeCoreTest()
        {
            Task result = Core.InitializeCore();
            return result;
            // TODO: add assertions to method CoreTest.InitializeCoreTest()
        }
    }
}
