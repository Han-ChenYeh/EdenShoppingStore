using EdenShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EdenShoppingStore.ViewModels;

namespace EdenShoppingStore.Controllers
{
    public class PersonController : Controller
    {
        private EdenContext db = new EdenContext();
        // GET: Person
        public ActionResult Index(int? id)
        {
            return RedirectToAction("Profile");
        }
        public ActionResult Profile(int? id) {
            if (id == null) {
                id = 1;
            }
            客戶主資料表 Cust = db.Customers.Find(id);
            if (Cust == null) {
                return HttpNotFound();
            }
            return View(Cust);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Profile([Bind(Include = "客戶ID,客戶姓名,客戶Email,客戶手機,客戶地址,客戶生日,客戶性別")] 客戶主資料表 Cust) {

            //修改指定欄位的方式
            客戶主資料表 newCust = db.Customers.Where(x => x.客戶ID == Cust.客戶ID).FirstOrDefault<客戶主資料表>();
            newCust.客戶姓名 = Cust.客戶姓名;
            newCust.客戶Email = Cust.客戶Email;
            newCust.客戶手機 = Cust.客戶手機;
            newCust.客戶地址 = Cust.客戶地址;
            newCust.客戶生日 = Cust.客戶生日;
            newCust.客戶性別 = Cust.客戶性別;
            newCust.修改日期 = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("Index");

            /*
            //修改指定欄位的方式
            客戶主資料表 c = new 客戶主資料表();
            c.客戶ID = Cust.客戶ID;
            var newCust = db.Customers.Attach(c);
            //newCust = Cust;
            newCust.客戶帳號 = Cust.客戶帳號;
            newCust.客戶姓名 = Cust.客戶姓名;
            newCust.客戶Email = Cust.客戶Email;
            db.SaveChanges();
            return RedirectToAction("Index");
            */
            /*
            if (ModelState.IsValid) {
                //修改該ID的全部欄位
                
                Cust.修改日期 = DateTime.Now;
                Cust.客戶密碼 = "123456789";
                db.Entry(Cust).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View("~/Views/Person/Profile.cshtml", Cust);
            */
        }

        public ActionResult Address(int? id) {
            if (id == null) {
                id = 1;
            }
            AddressViewModel viewModel = new AddressViewModel();
            //viewModel.address = db.Address.FirstOrDefault(x => x.收貨ID == id);
            viewModel.address = new 收貨地址();
            using (db) {
                var result = from p in db.Address where p.客戶ID == id select p;
                viewModel.addressList = result.ToList();
                return View(viewModel);
            }
        }

        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddressDelete([Bind(Include = "收貨ID")] 收貨地址 address) {
            收貨地址 ad = db.Address.Find(address.收貨ID);
            db.Address.Remove(ad);
            db.SaveChanges();
            return RedirectToAction("Address");
        }
        */
        [HttpGet]
        public ActionResult AddressDelete(int? id) {
            收貨地址 ad = db.Address.Find(id);
            db.Address.Remove(ad);
            db.SaveChanges();
            return RedirectToAction("Address");
        }
        public ActionResult AddressInsert([Bind(Include = "收貨姓名,收貨電話,地址")] 收貨地址 address) {
            
            if (ModelState.IsValid) {
                address.客戶ID = 1;
                db.Address.Add(address);
                db.SaveChanges();
            }

            return RedirectToAction("Address");
        }
        public ActionResult History() {
            return View();
        }
        public ActionResult Pw() {
            return View();
        }
        public ActionResult SpCar() {
            return View();
        }
    }
}