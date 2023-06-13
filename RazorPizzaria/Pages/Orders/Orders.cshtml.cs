using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaria.Models;
using RazorPizzaria.Data;

namespace RazorPizzaria.Pages.Orders
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrders> pizzaorders = new List<PizzaOrders>();

        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public void OnGet()
        {
            pizzaorders = _context.PizzaOrders.ToList();
        }
    }
}
