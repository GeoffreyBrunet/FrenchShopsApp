using System.Collections.Generic;
using FrenchShopsApp.Data;
using FrenchShopsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrenchShopsApp.Controllers
{
    public class ShopsController : Controller
    {
        private readonly ApplicationDbContext _BDD;

        public ShopsController(ApplicationDbContext BDD)
        {
            _BDD = BDD;
        }

        [HttpGet]
        public IActionResult List()
        {
            List<Shop> listShops = new List<Shop>();

            IEnumerable<T_Shop> listeShops = _BDD.T_Shop;
            return View(listeShops);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Add(T_Shop shop)
        {
            _BDD.T_Shop.Add(shop);
            _BDD.SaveChanges();
            return RedirectToAction("Add");
        }
    }
}
