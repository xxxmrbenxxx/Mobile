using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MobileStore.Models
{
    public class MobileContext : DbContext
    {
        public MobileContext() : base("MobileStore")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}