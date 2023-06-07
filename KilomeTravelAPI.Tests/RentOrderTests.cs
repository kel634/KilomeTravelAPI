using KilomeTravelAPI.WebAPI.Models;

namespace KilomeTravelAPI.Tests
{
    public class RentOrderTests
    {
        [Fact]
        public void RentalItem_Properties()
        {
            RentalItem rentalItem = new RentalItem
            {
                Id = 1,
                Name = "Item 1",
                RentalItemTypeId = 2,
                PricePerDay = 10.99m
            };

            Assert.Equal(1, rentalItem.Id);
            Assert.Equal("Item 1", rentalItem.Name);
            Assert.Equal(2, rentalItem.RentalItemTypeId);
            Assert.Equal(10.99m, rentalItem.PricePerDay);
        }

        [Fact]
        public void RentalItemType_Properties()
        {
            RentalItemType rentalItemType = new RentalItemType
            {
                Id = 1,
                Name = "Type 1",
                Enabled = true,
                HasFuel = false
            };

            Assert.Equal(1, rentalItemType.Id);
            Assert.Equal("Type 1", rentalItemType.Name);
            Assert.True(rentalItemType.Enabled);
            Assert.False(rentalItemType.HasFuel);
        }

        [Fact]
        public void RentOrder_Properties()
        {
            DateTime reservationTime = DateTime.Now;
            string customerName = "Johny";
            string customerPhoneNumber = "123";
            RentalItem rentalItem = new RentalItem
            {
                Id = 1,
                Name = "Item 1",
                RentalItemTypeId = 2,
                PricePerDay = 10.99m
            };
            RentOrder rentOrder = new RentOrder
            {
                Id = 1,
                RentalItem = rentalItem,
                ReservationTime = reservationTime,
                CustomerName = customerName,
                CustomerPhoneNumber = customerPhoneNumber
            };

            Assert.Equal(1, rentOrder.Id);
            Assert.Equal(rentalItem, rentOrder.RentalItem);
            Assert.Equal(reservationTime, rentOrder.ReservationTime);
            Assert.Equal(customerName, rentOrder.CustomerName);
            Assert.Equal(customerPhoneNumber, rentOrder.CustomerPhoneNumber);
        }

        [Fact]
        public void RentReturn_SetAndGetProperties_Success()
        {
            RentalItem rentalItem = new RentalItem
            {
                Id = 1,
                Name = "Item 1",
                RentalItemTypeId = 2,
                PricePerDay = 10.99m
            };
            DateTime reservationTime = DateTime.Now;
            string customerName = "Johny";
            string customerPhoneNumber = "123";
            RentOrder rentOrder = new RentOrder
            {
                Id = 1,
                RentalItem = rentalItem,
                ReservationTime = reservationTime,
                CustomerName = customerName,
                CustomerPhoneNumber = customerPhoneNumber
            };
            DateTime returnTime = DateTime.Now;
            decimal fuelPenalty = 20.99m;
            decimal damagePenalty = 50.99m;
            string damageDescription = "Scratches on the body";

            RentReturn rentReturn = new RentReturn
            {
                Id = 1,
                RentOrder = rentOrder,
                ReturnTime = returnTime,
                FuelPenalty = fuelPenalty,
                DamagePenalty = damagePenalty,
                DamageDescription = damageDescription
            };

            // Assert
            Assert.Equal(1, rentReturn.Id);
            Assert.Equal(rentOrder, rentReturn.RentOrder);
            Assert.Equal(returnTime, rentReturn.ReturnTime);
            Assert.Equal(fuelPenalty, rentReturn.FuelPenalty);
            Assert.Equal(damagePenalty, rentReturn.DamagePenalty);
            Assert.Equal(damageDescription, rentReturn.DamageDescription);
        }
    }
}