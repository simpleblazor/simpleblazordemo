namespace Api.Services;

using static BaseService;
internal static class ProductService
{
    internal static async Task<List<Product>> GetAll()
    {
        List<Product> products = new();

        using SqlConnection dbConn = new(ConnectionString);

        var sql = @"SELECT * FROM PRODUCTS ORDER BY ID";

        SqlCommand cmd = new(sql, dbConn);

        await dbConn.OpenAsync();
        using SqlDataReader reader = await cmd.ExecuteReaderAsync();
        while (reader.Read())
        {
            Product product = DBAgent.GetProduct(reader);
            products.Add(product);
        }
        await reader.CloseAsync();
        await dbConn.CloseAsync();

        return products;
    }
}
