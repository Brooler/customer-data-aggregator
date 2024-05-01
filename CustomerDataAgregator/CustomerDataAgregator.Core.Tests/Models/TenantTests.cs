using CustomerDataAgregator.Core.Models;
using FluentAssertions;

namespace CustomerDataAgregator.Core.Tests.Models;

public class TenantTests
{
    [Test]
    public void FinTag_ShouldReturnFirstLetterOfEachWordInOrganisationName()
    {
        // Arrange
        var tenant = new Tenant
        {
            OrganisationName = "Customer Data Aggregator"
        };

        // Act
        var result = tenant.FinTag;

        // Assert
        result.Should().Be("CDA");
    }
}
