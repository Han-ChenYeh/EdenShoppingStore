using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.Models
{
    public class 購物車
    {
        public int id { get; set; }
        public int 客戶ID { get; set; }
        public int 產品ID { get; set; }
        public int 數量 { get; set; }
        public DateTime 建立日期 { get; set; }
    }
}