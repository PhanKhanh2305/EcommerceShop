using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Components
{
    public class FeatureCategory : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Index");
        }
    }
}
