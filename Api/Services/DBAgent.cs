namespace Api.Services;
internal class DBAgent
{    internal static Product GetProduct(SqlDataReader rdr)
    {
        return new()
        {
            Id = rdr["Id"] as int? ?? 0,
            Name = rdr["Name"] as string,
            Description = rdr["Description"] as string,
            Category =  rdr["Category"] as string,
            ImageUrl = rdr["ImageUrl"] as string,
            IsActive = rdr["IsActive"] as bool? ?? false,           
            Rating = rdr["Rating"] as int? ?? 0,
            CreatedAt = rdr["CreatedAt"] as DateTime? ?? null,
            UpdatedAt = rdr["UpdatedAt"] as DateTime? ?? null            
        };
    }   
}

