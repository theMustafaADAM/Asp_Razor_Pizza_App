using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaria.Data;
using RazorPizzaria.Models;

namespace RazorPizzaria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]

    public class CheckoutModel : PageModel
    {
        public string? PizzaName { get; set; }
        public string? ImageTitle { get; set; }
        public float PizzaPrice { get; set; }

        private readonly ApplicationDbContext _context;

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom Pizza";
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "CreateIn";

            }

            PizzaOrders pizzaOrders = new PizzaOrders();

            pizzaOrders.PizzaName = PizzaName;
            pizzaOrders.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrders);
            _context.SaveChanges();

        }
    }
}
