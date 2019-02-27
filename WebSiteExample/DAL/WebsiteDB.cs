using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

using WebSiteExample.Models;

namespace WebSiteExample.DAL
{
    public class WebsiteDB : DbContext
    {
        public WebsiteDB() : base("name=WebsiteDB")
        {

        }
        public virtual DbSet<Contact> Contacts { get; set; }

        public virtual DbSet<Products> Products { get; set; }

        public virtual DbSet<Yetki> Yetkis { get; set; }

        public virtual DbSet<Uye> Uyes { get; set; }

        public virtual DbSet<Category> Category { get; set; } 

        public virtual DbSet<Basket> Basket { get; set; }

        public virtual DbSet<TotalOrders> TotalOrders { get; set; }

        public virtual DbSet<Order> Order { get; set; }

    }
}