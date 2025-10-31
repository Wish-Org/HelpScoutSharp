namespace HelpScoutSharp;

public class CustomerPropertyService : ServiceBase
{
    public CustomerPropertyService(string accessToken)
        : base(accessToken, "customer-properties ")
    {
    }

    public async Task<CustomerPropertiesResult> ListAsync(ListOptions options = null)
    {
        return await _client.GetAsync<CustomerPropertiesResult>(_serviceUri, options);
    }
}
