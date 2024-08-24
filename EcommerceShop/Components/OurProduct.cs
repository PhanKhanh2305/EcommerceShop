using EcommerceShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Components
{
    public class OurProduct : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public OurProduct(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View("Index",_context.Products.ToList());
        }
    }
}
