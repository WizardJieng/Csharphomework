using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OrderApp
{
    public class OrderServiceContext:DbContext
    {
        public OrderServiceContext() : base("BlogDataBase")
        {
            Database.SetInitializer(
              new DropCreateDatabaseIfModelChanges<OrderServiceContext>());
        }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }     
    }
}
