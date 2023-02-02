using Azure.Data.Tables;
namespace azurite_table_service_test;


public class UnitTest1
{
    [Fact]
    public async Task CreateTable()
    {
        var client = new TableServiceClient("UseDevelopmentStorage=true;");
        await client.CreateTableIfNotExistsAsync("Test");
        var tableClient = client.GetTableClient("Test");
        Assert.NotNull(tableClient);
        Assert.Equal(tableClient.Name, "Test");
    }
}