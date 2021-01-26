using BurgerApp.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderDetailsViewModel> GetAllOrders();
        OrderDetailsViewModel GetOrderByID(int id);
    }
}
