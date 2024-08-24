using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Components
{
    public class BannerPart : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Index");  
        }
    }
}
