using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelpScoutSharp.Tests;

[TestClass]
public class TeamService_Tests
{
    private TeamService _service;

    [TestInitialize]
    public async Task Initialize()
    {
        HelpScoutHttpClient.RateLimitBreachBehavior = RateLimitBreachBehavior.WaitAndRetryOnce;
        var authSvc = new AuthenticationService();
        var token = await authSvc.GetApplicationTokenAsync(TestHelper.ApplicationId, TestHelper.ApplicationSecret);
        _service = new TeamService(token.access_token);
    }

    [TestMethod]
    public async Task ListTeamsAsync_Works()
    {
        var res = await _service.ListAsync();
        Assert.IsTrue(res.page.size > 0);
        Assert.IsNotNull(res.entities[0].name);
    }
}
