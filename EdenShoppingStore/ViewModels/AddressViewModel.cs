using EdenShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EdenShoppingStore.ViewModels {
    public class AddressViewModel {
        public 收貨地址 address { get; set; }
        public List<收貨地址> addressList { get; set; }
    }
}