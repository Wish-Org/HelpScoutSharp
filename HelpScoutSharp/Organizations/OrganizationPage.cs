namespace HelpScoutSharp;

public class OrganizationPage : IPage<Organization>
{
    public class Embedded
    {
        public Organization[] organizations { get; set; }
    }

    public Embedded _embedded { get; set; }

    public Page page { get; set; }

    public Organization[] entities => _embedded.organizations;
}
