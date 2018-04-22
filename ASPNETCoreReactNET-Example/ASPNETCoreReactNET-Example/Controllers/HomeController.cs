using ASPNETCoreReactNET_Example.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreReactNET_Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Test()
        {
            var user = new UserModel { Name = "Test User", Age = 18 };

            return this.View(user);
        }
    }
}