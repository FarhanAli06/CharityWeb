
using System.Threading.Tasks;
using BusinessLogic.IService;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _homeService.CallApiMethodAsync();
            return View();

            //return PartialView("_Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
