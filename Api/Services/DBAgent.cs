namespace Api.Services;
internal class DBAgent
{    internal static Product GetProduct(SqlDataReader rdr)
    {
        return new()
        {
            Id = rdr["Id"] as int? ?? 0,
            Name = rdr["Name"] as string,
            Description = rdr["Description"] as string,
            IsActive = rdr["IsActive"] as bool? ?? false,
            Url = rdr["Url"] as string,
            Rating = rdr["Rating"] as int? ?? 0,
            CreatedAt = rdr["CreatedAt"] as DateTime? ?? null,
            UpdatedAt = rdr["UpdatedAt"] as DateTime? ?? null            
        };
    }

    internal static Category GetCategory(SqlDataReader rdr)
    {
        return new()
        {
            Id = rdr["Id"] as int? ?? 0,           
            Name = rdr["Name"] as string,
            Description = rdr["Description"] as string,
            CreatedAt = rdr["CreatedAt"] as DateTime? ?? null,
            UpdatedAt = rdr["UpdatedAt"] as DateTime? ?? null
        };
    }

    internal static CategoryProduct GetCategoryProduct(SqlDataReader rdr)
    {
        return new()
        {
            CategoryId = rdr["CategoryId"] as int? ?? 0,
            ProductId = rdr["ProductId"] as int? ?? 0,
            CreatedAt = rdr["CreatedAt"] as DateTime? ?? null
        };
    }
}

