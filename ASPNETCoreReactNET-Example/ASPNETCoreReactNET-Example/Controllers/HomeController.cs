namespace ASPNETCoreReactNET_Example.Controllers
{
    using ASPNETCoreReactNET_Example.Models;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Test()
        {
            // Some hardcoded model for test.
            var user = new UserModel { Name = "Test User", Age = 18 };

            return this.View(user);
        }
    }
}