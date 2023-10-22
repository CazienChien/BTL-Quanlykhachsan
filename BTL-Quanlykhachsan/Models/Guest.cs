using System.Reflection;

namespace BTL_Quanlykhachsan.Models
{
    public class Guest
    {
        public int Id { get; set; }//số phòng
        public string? Name { get; set; } //Họ tên khách hàng
        public string? Email { get; set; } //Email
        public string? CheckinDate { get; set; }// ngày nhận phòng
        public string? CheckoutDate { get; set; }//ngày trả phòng
       
    }
}
