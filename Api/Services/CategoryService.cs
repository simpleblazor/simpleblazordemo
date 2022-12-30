namespace Api.Services;

using static BaseService;

internal static class CategoryService
{
    internal static async Task<Category> Get(int? categoryId)
    {
        Category cat = new();

        using SqlConnection dbConn = new(ConnectionString);

        var sql = @"SELECT * FROM CATEGORIES WHERE ID = @CID ";

        SqlCommand cmd = new(sql, dbConn);
        cmd.Parameters.AddWithValue("@CID", categoryId ?? 0);

        await dbConn.OpenAsync();
        using SqlDataReader reader = await cmd.ExecuteReaderAsync();
        while (reader.Read())
        {
            cat = DBAgent.GetCategory(reader);
        }
        await reader.CloseAsync();
        await dbConn.CloseAsync();

        return cat;
    }
}
