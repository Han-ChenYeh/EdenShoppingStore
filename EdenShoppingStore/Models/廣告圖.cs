using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.Models
{
    public class 廣告圖
    {
        public int id { get; set; }
        public bool 主圖 { get; set; }
        public string 圖片名稱 { get; set; }
        public DateTime 建立日期 { get; set; }
    }
}