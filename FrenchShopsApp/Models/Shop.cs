using System.ComponentModel.DataAnnotations;

namespace FrenchShopsApp.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string NomShop { get; set; }
        public string AdressShop { get; set; }
        public string UrlShop { get; set; }
    }
}