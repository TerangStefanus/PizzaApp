using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;

namespace PizzaApp.Data
{
	public class ApplicationDBContext: DbContext
	{
		public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
            : base(options)
        {
            
        }
    }
}
