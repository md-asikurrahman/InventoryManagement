namespace InventoryManagement.WEB.ApiConfigure
{
    public class ApiConfiguration
    {
        public string BaseUrl { get; set; }
        public string CreateUser(int id) => $"{BaseUrl}/todos/{id}";
        public string GetUserWithMultiValue(int id,string name)
        {
            return $"{BaseUrl}/todos?id={id}&name={name}";
        }
    }
}
