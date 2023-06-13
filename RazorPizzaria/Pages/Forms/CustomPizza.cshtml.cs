using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaria.Models;

namespace RazorPizzaria.Pages.Forms
{
    public class CustomPizzModel : PageModel
    {
        [BindProperty]

        public PizzasModel? pizzas { get; set; }

        public float PizzaPrice { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            PizzaPrice = pizzas.BasePrice;

            if (pizzas.Beef) PizzaPrice += 2;
            if (pizzas.Checken) PizzaPrice += 2;
            if (pizzas.Cheese) PizzaPrice += 1;
            if (pizzas.Mushroom) PizzaPrice += 1;
            if (pizzas.Peperoni) PizzaPrice += 1;
            if (pizzas.Pineapple) PizzaPrice += 10;
            if (pizzas.TomatoSauce) PizzaPrice += 1;
            if (pizzas.Tuna) PizzaPrice += 1;

            return RedirectToPage("Checkout/Checkout", new { pizzas.PizzaName, PizzaPrice });
        }
    }
}
