using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.Models
{
    public class 客戶主資料表
    {
        [Key]
        public int 客戶ID { get; set; }
        public string 客戶帳號 { get; set; }
        public string 客戶密碼 { get; set; }
        public string 客戶姓名 { get; set; }
        public string 客戶Email { get; set; }
        public string 客戶手機 { get; set; }
        public string 客戶地址 { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime 客戶生日 { get; set; }
        public string 客戶性別 { get; set; }
        public DateTime 建立日期 { get; set; }
        public DateTime 修改日期 { get; set; }
    }
}