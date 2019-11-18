using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.Models
{
    public class 收貨地址
    {
        [Key]
        public int 收貨ID { get; set; }
        public int 客戶ID { get; set; }
        public string 收貨姓名 { get; set; }
        public string 收貨電話 { get; set; }
        public string 地址 { get; set; }

    }
}