using System;
using System.Runtime.InteropServices;
using OrderManagement.Exceptions;
using Xunit;
using static Xunit.Assert;

namespace OrderManagement.Tests
{
    public class CoreTests
    {
        [Theory]
        [InlineData("devuser", "Etrade5678", "1c165e8e-b762-47a6-87c4-9aa2440ec45d", "29736")]
        public async void Test_Core_Success(string userName, string password, string accessToken, string companyId)
        {
            await Core.InitializeCore(userName, password, accessToken, companyId);
            Assert.NotNull(Core.Session);
            Assert.True(Core.Session.LoggedIn);
        }

        [Theory]
        [InlineData("devuser", "Etrade56788", "1c165e8e-b762-47a6-87c4-9aa2440ec45d", "29736")]
        public async void Test_Core_LoginFailedException(string userName, string password, string accessToken, string companyId)
        {
            Assert.Throws<CoreExceptions.LoginException>(() =>
                Core.InitializeCore(userName, password, accessToken, companyId).GetAwaiter().GetResult());
        }

        [Theory]
        [InlineData("devuser", "Etrade5678", "1c165e8e-b762-47a6-87c4-9aa2440ec45d", "297367")]
        public async void Test_Core_CompanyInitializeException(string userName, string password, string accessToken, string companyId)
        {
            Assert.Throws<CoreExceptions.CompanyInitializeException>(() =>
                Core.InitializeCore(userName, password, accessToken, companyId).GetAwaiter().GetResult());
        }
    }
}
