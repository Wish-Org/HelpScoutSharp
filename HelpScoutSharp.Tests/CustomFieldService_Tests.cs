using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace HelpScoutSharp.Tests
{
    [TestClass]
    public class CustomFieldService_Tests
    {
        private MailboxService _mailboxService;
        private CustomFieldService _service;

        [TestInitialize]
        public async Task Initialize()
        {
            HelpScoutHttpClient.RateLimitBreachBehavior = RateLimitBreachBehavior.WaitAndRetryOnce;
            var authSvc = new AuthenticationService();
            var token = await authSvc.GetApplicationTokenAsync(TestHelper.ApplicationId, TestHelper.ApplicationSecret);
            _mailboxService = new MailboxService(token.access_token);
            _service = new CustomFieldService(token.access_token);
        }

        [TestMethod]
        public async Task ListMailboxCustomFieldsAsync_Works()
        {
            var maiboxId = (await _mailboxService.ListAsync()).entities[0].id;
            var res = await _service.ListAsync(maiboxId);
            Assert.IsTrue(res.page.size > 0);
            Assert.IsNotNull(res.entities);
        }
    }
}
