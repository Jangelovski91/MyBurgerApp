using BurgerApp.DataAccess;
using BurgerApp.DataAccess.Implementations;
using BurgerApp.DomainModels.Models;
using BurgerApp.Mappers.Order;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.Services.Implemenations
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<OrderDetailsViewModel> GetAllOrders()
        {
            List<Order> orders = _orderRepository.GetAll();
            List<OrderDetailsViewModel> viewModels = new List<OrderDetailsViewModel>();
            foreach(Order order in orders)
            {
                viewModels.Add(order.ToOrderDetailsViewModel());
            }
            return viewModels;
        }

        public OrderDetailsViewModel GetOrderByID(int id)
        {
            Order order = _orderRepository.GetByID(id);
            if(order == null)
            {
                throw new Exception($"Order with id {id} was not found.");
            }
            return order.ToOrderDetailsViewModel();
        }
    }
}
  