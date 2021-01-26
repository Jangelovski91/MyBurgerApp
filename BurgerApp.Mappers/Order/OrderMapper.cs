using BurgerApp.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Text;
using BurgerApp.DomainModels.Models;
using System.Linq;

namespace BurgerApp.Mappers.Order
{
    public static class OrderMapper
    {
        public static OrderDetailsViewModel ToOrderDetailsViewModel(this DomainModels.Models.Order order)
        {
            double price = 0;
            foreach(var burgerOrder in order.BurgerOrders)
            {
                price += burgerOrder.Price;
            }
            return new OrderDetailsViewModel
            {
                ID = order.ID,
                Delivered = order.Delivered,
                PaymentMethod = order.PaymentMethod,
                BurgerStore = order.BurgerStore,
                UserFullName = $"{order.User.FirstName } {order.User.LastName }",
                BurgerNames = order.BurgerOrders.Select(x => x.Burger.Name).ToList(),
                Price = price
            
            };
        }
    }
}
