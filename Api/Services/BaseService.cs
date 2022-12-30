namespace Api.Services;
internal static class BaseService
{
    internal static readonly string ConnectionString;
    static BaseService()
    {
        ConnectionString = Environment.GetEnvironmentVariable("ConnectionString", EnvironmentVariableTarget.Process);
    }

}
