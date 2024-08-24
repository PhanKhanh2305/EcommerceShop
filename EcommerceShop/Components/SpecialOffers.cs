using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Components
{
    public class SpecialOffers : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Index");
        }
    }
}
