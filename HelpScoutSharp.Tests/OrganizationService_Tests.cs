using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelpScoutSharp.Tests;

[TestClass]
public class OrganizationService_Tests
{
    private OrganizationService _service;

    [TestInitialize]
    public async Task Initialize()
    {
        HelpScoutHttpClient.RateLimitBreachBehavior = RateLimitBreachBehavior.WaitAndRetryOnce;
        var authSvc = new AuthenticationService();
        var token = await authSvc.GetApplicationTokenAsync(TestHelper.ApplicationId, TestHelper.ApplicationSecret);
        _service = new OrganizationService(token.access_token);
    }

    [TestMethod]
    public async Task GetOrganizationAsync_Works()
    {
        var res = await _service.ListAsync();
        var organization = await _service.GetAsync(res.entities[0].id);
        Assert.IsTrue(organization.id > 0);
    }

    [TestMethod]
    public async Task ListOrganizationsAsync_Works()
    {
        var res = await _service.ListAsync(new ListOrganizationsOptions());
        Assert.IsTrue(res.page.size > 0);
    }
}
