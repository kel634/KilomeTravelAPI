using KilomeTravelAPI.WebAPI.Models;

namespace KilomeTravelAPI.Tests
{
    public class RentOrderTests
    {
        [Fact]
        public void ReturnARentOrder()
        {
            var resTime = DateTime.Now.AddDays(1);
            var name = "Bobby";
            var phone = "+40 123";

            var order = new RentOrder
            {
                ReservationTime = resTime,
                CustomerName = name,
                CustomerPhoneNumber = phone,
            };

            Assert.Equal(name, order.CustomerName);
            Assert.Equal(phone, order.CustomerPhoneNumber);
        }
    }
}