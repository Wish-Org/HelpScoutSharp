using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace HelpScoutSharp.Tests
{
    [TestClass]
    public class TagService_Tests
    {
        private TagService _service;

        [TestInitialize]
        public async Task Initialize()
        {
            HelpScoutHttpClient.RateLimitBreachBehavior = RateLimitBreachBehavior.WaitAndRetryOnce;
            var authSvc = new AuthenticationService();
            var token = await authSvc.GetApplicationTokenAsync(TestHelper.ApplicationId, TestHelper.ApplicationSecret);
            _service = new TagService(token.access_token);
        }

        [TestMethod]
        public async Task LisTagsAsync_Works()
        {
            var res = await _service.ListAsync();
            Assert.IsTrue(res.page.size > 0);
        }
    }
}
