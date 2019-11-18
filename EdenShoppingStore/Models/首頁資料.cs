using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.Models
{
    public class 首頁資料
    {
        [Key]
        public int id { get; set; }
        public string LOGO圖片 { get; set; }
        public string 地址電話 { get; set; }
        public string LINEEmail { get; set; }
        public string 服務時間 { get; set; }
        public string 二維碼 { get; set; }

    }
}