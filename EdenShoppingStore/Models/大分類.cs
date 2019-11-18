using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.Models
{
    public class 大分類
    {
        [Key]
        public int 大分類ID { get; set; }
        public string 大分類預覽圖 { get; set; }
        public string 大分類名稱 { get; set; }
        public DateTime 建立日期 { get; set; }
    }
}