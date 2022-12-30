namespace Api.Categories;

public class GetCategory
{
    [Function("GetCategory")]
    public static async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route ="category/{id:int?}")]  HttpRequestData req, int? id)
    {
        var response = req.CreateResponse(HttpStatusCode.OK);  
        Category category = await CategoryService.Get(id);
        await response.WriteAsJsonAsync(category);

        return response;
    }
}
