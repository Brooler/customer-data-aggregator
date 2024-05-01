namespace CustomerDataAgregator.Core.Models;

public class Tenant
{
    public long Id { get; set; }

    public string OrganisationName { get; set; }

    // First letter of each word in the OrganisationName
    public string FinTag => string.Join("", OrganisationName.Split(' ').Select(w => w.First()));
}
