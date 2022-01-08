using System.Diagnostics;
using System.Threading.Tasks;
using BtBtShop.Business.Abstract;
using BtBtShop.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BtBtShop.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IProductService productService,
            IUserService userService)
        {
            _logger = logger;
            _productService = productService;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
           var users= await _userService.GetAllUsers();
           return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}