using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.Models
{
    public class 訂單
    {
        [Key]
        public int 訂單ID { get; set; }
        public int 客戶ID { get; set; }
        public int 產品ID { get; set; }
        public int 數量 { get; set; }
        public int 訂單狀態 { get; set; }
        
        public DateTime 建立日期 { get; set; }
    }
}