using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.Models
{
    public class EdenContext:DbContext
    {
        public EdenContext() : base("name=EdenContext")
        {
        }
        public DbSet<大分類> BigTypes { get; set; }
        public DbSet<小分類> SmallTypes { get; set; }
        public DbSet<收貨地址> Address { get; set; }
        public DbSet<客戶主資料表> Customers { get; set; }
        public DbSet<訂單> Orders { get; set; }
        public DbSet<首頁資料> IndexDatas { get; set; }
        public DbSet<產品> Products { get; set; }
        public DbSet<廣告圖> Ads { get; set; }
        public DbSet<購物車> ShoppingCars { get; set; }

    }
}