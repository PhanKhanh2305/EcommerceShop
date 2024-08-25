using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Controllers
{
    public class CheckOutController : Controller
    {
        public IActionResult Index()
        {
            return View("CheckOut");
        }
    }
}
