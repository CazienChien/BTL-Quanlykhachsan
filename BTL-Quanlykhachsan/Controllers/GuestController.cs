using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BTL_Quanlykhachsan.Models;
using System.Reflection;

namespace BTL_Quanlykhachsan.Controllers
{
    public class GuestController : Controller
    {
        private List<Guest> listGuests = new List<Guest>();
        public GuestController()
        {
            listGuests = new List<Guest>()
            {
                new Guest() {Id = 101, Name = "Le Hoang Long", CheckinDate = "01/10/2023", CheckoutDate = "05/10/2023", Email = "Long@gmail.com"},
                new Guest() {Id = 102, Name = "Le Hoang Phuc", CheckinDate = "02/10/2023", CheckoutDate = "06/10/2023", Email = "Phuc@gmail.com"},
                new Guest() {Id = 103, Name = "Nguyen Quoc Duy", CheckinDate = "03/10/2023", CheckoutDate = "07/10/2023", Email = "Duy@gmail.com"},
                new Guest() {Id = 104, Name = "Tran Thi Thu Thuy", CheckinDate = "04/10/2023", CheckoutDate = "08/10/2023", Email = "Thuy@gmail.com"}
            };
        }
        public IActionResult Index()
        {
            return View(listGuests);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Guest s)
        {
            s.Id = listGuests.Last<Guest>().Id + 1;
            listGuests.Add(s);
            return View("Index", listGuests);
        }
    }
}
