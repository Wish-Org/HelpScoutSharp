namespace HelpScoutSharp
{
    public class CustomFieldPage : IPage<CustomField>
    {
        public class Embedded
        {
            public CustomField[] fields { get; set; }
        }

        public Embedded _embedded { get; set; }

        public Page page { get; set; }

        public CustomField[] entities => _embedded.fields;
    }
}
