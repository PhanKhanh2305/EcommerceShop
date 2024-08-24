using EcommerceShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Components
{
    public class BestSeller : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public BestSeller(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View("Index",_context.Products.Where(p => p.BestSeller == true).ToList());
        }
    }
}
