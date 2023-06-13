using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaria.Models;

namespace RazorPizzaria.Pages.Pizza
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita_Pizza",  BasePrice=2,    TomatoSauce=true,   Cheese=true,                                FinalPrice=4 },
            new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognses_Pizza",  BasePrice=2,    TomatoSauce=true,   Cheese=true, Beef=true,                     FinalPrice=6 },
            new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara_Pizza",  BasePrice=2,    Checken=true,       TomatoSauce=true, Cheese=true,              FinalPrice=6 },
            new PizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian_Pizza",    BasePrice=2,    TomatoSauce=true,   Cheese=true,Checken=true, Pineapple=true,   FinalPrice=16},
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName="MeatFeast_Pizza",  BasePrice=2,    TomatoSauce=true,   Cheese=true, Checken=true, Beef=true,       FinalPrice=8 },
            new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom_Pizza",    BasePrice=2,    Mushroom=true,      TomatoSauce=true, Cheese=true,              FinalPrice=5 },
            new PizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni_Pizza",  BasePrice=2,    Peperoni=true,      TomatoSauce=true, Cheese=true,              FinalPrice=5 },
            new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood_Pizza",      BasePrice=2,    TomatoSauce=true,   Cheese=true, Tuna=true,                     FinalPrice=5 },
            new PizzasModel(){ImageTitle="Vegetarian", PizzaName="Vegetarian_Pizza", BasePrice=2,   Pineapple=true,     TomatoSauce=true, Cheese=true,              FinalPrice=14},
        };

        public void OnGet()
        {
            
        }
    }
}
