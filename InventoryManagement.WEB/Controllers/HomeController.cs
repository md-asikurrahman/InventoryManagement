using InventoryManagement.WEB.ApiConfigure;
using InventoryManagement.WEB.Models;
using InventoryManagement.WEB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InventoryManagement.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ApiService _apiService;
        private readonly ILogger<HomeController> _logger;
        private readonly ApiConfiguration _apiConfiguration;

        public HomeController(ILogger<HomeController> logger, ApiConfiguration apiConfiguration, HttpClient httpClient, ApiService apiService)
        {
            _logger = logger;
            _apiConfiguration = apiConfiguration;
            _httpClient = httpClient;
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var todo = new TodoVm();
            var id = 1;
            var name = string.Empty;
            var todoList =await _apiService.GetAsync<TodoVm>(_apiConfiguration.CreateUser(id));
            var userList = await _apiService.GetAsync<TodoVm>(_apiConfiguration.GetUserWithMultiValue(id,name));

            todo = todoList;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
