using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.Models
{
    public class 產品
    {
        [Key]
        public int 產品ID { get; set; }
        public int 小分類ID { get; set; }
        public int 大分類ID { get; set; }
        public string 產品名稱 { get; set; }
        public decimal 產品單價 { get; set; }
        public decimal 產品尺寸 { get; set; }
        public string 產品材質 { get; set; }
        public string 產品內容 { get; set; }
        public string 產品圖片 { get; set; }
        public decimal 折扣 { get; set; }

        public DateTime 建立日期 { get; set; }
    }
}