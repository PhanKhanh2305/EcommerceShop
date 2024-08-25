using EcommerceShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Components
{
    public class ColorList : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public ColorList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View("Index", _context.Colors.ToList());
        }
    }
}
