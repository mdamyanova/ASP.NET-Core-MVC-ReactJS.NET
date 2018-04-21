using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreReactNET_Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}