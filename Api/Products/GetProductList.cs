namespace Api.Products;

public class GetCategory
{
    [Function("GetProductList")]
    public static async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "product/getlist")] HttpRequestData req)
    {
        var response = req.CreateResponse(HttpStatusCode.OK);
        List<Product> products =  await ProductService.GetAll();
        await response.WriteAsJsonAsync(products);
        return response;
    }
}
