using Flurl;

namespace HelpScoutSharp;

public class OrganizationService : ServiceBase, IListableService<Organization, ListOrganizationsOptions>
{
    public OrganizationService(string accessToken)
        : base(accessToken, "organizations")
    {
    }

    public async Task<Organization> GetAsync(long organizationId)
    {
        return await _client.GetAsync<Organization>(new Url(_serviceUri).AppendPathSegment(organizationId).ToUri());
    }

    public async Task<IPage<Organization>> ListAsync(ListOrganizationsOptions options = null)
    {
        return await _client.GetAsync<OrganizationPage>(_serviceUri, options);
    }
}
