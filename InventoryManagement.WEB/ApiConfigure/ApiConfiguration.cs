namespace InventoryManagement.WEB.ApiConfigure
{
    public class ApiConfiguration
    {
        public string BaseUrl { get; set; }
        public string CreateUser => $"{BaseUrl}/todos/1";
    }
}
