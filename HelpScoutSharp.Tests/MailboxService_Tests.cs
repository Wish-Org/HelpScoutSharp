using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace HelpScoutSharp.Tests;

[TestClass]
public class MailboxService_Tests
{
    private MailboxService _service;

    [TestInitialize]
    public async Task Initialize()
    {
        HelpScoutHttpClient.RateLimitBreachBehavior = RateLimitBreachBehavior.WaitAndRetryOnce;
        var authSvc = new AuthenticationService();
        var token = await authSvc.GetApplicationTokenAsync(TestHelper.ApplicationId, TestHelper.ApplicationSecret);
        _service = new MailboxService(token.access_token);
    }

    [TestMethod]
    public async Task ListMailboxesAsync_Works()
    {
        var res = await _service.ListAsync();
        Assert.IsTrue(res.page.size > 0);
        Assert.IsNotNull(res.entities[0].email);
    }
}
