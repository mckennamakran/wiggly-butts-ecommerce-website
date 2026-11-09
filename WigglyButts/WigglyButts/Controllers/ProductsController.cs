using Microsoft.AspNetCore.Mvc;
using WigglyButts.Data;

namespace WigglyButts.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context) { _context = context; }

        public IActionResult Index()
        {
            var products = _context.Products.ToList(); // Original line causing SQL exception
            return View(products); //pass to page
        }
    }
}
