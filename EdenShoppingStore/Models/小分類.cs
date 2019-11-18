using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.Models
{
    public class 小分類
    {
        [Key]
        public int 小分類ID { get; set; }
        public int 大分類ID { get; set; }
        public string 小分類名稱 { get; set; }
        public DateTime 建立日期 { get; set; }
    }
}