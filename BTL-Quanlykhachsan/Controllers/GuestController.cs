using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BTL_Quanlykhachsan.Models;
namespace BTL_Quanlykhachsan.Controllers
{
    public class GuestController : Controller
    {
        private List<Guest> listGuests = new List<Guest>();
        public GuestController()
        {
            listGuests = new List<Guest>()
            {
                new Guest() {Id = 101, Name = "Le Hoang Long", CheckinDate = "2023/10/1", CheckoutDate = "2023/10/5", Email = "Long@gmail.com"},
                new Guest() {Id = 102, Name = "Le Hoang Phuc", CheckinDate = "2023/10/2", CheckoutDate = "2023/10/6", Email = "Phuc@gmail.com"},
                new Guest() {Id = 103, Name = "Nguyen Quoc Duy", CheckinDate = "2023/10/3", CheckoutDate = "2023/10/7", Email = "Duy@gmail.com"},
                new Guest() {Id = 104, Name = "Tran Thi Thu Thuy", CheckinDate = "2023/10/4", CheckoutDate = "2023/10/8", Email = "Thuy@gmail.com"}
            };
        }
        public IActionResult Index()
        {
            return View(listGuests);
        }
    }
}
