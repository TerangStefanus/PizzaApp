using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Data;
using PizzaApp.Models;

namespace PizzaApp.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();

        private readonly ApplicationDBContext _Context;

        public OrdersModel(ApplicationDBContext context )
        {
            _Context = context;
        }

        public void OnGet()
        {
			PizzaOrders = _Context.PizzaOrders.ToList();
		}
    }
}
