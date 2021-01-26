using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerApp.Services.Implemenations;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.Order;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IUserService _userService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            List<OrderDetailsViewModel> orderDetailsViewModels = _orderService.GetAllOrders();
            return View(orderDetailsViewModels);
        }
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return View("BadRequest");
            }
            try
            {
                OrderDetailsViewModel orderDetailsViewModel = _orderService.GetOrderByID(id.Value);
                return View(orderDetailsViewModel);
            }
            catch(Exception ex)
            {
                return View("ExceptionView");
            }
        }
        public IActionResult CreateOrder()
        {
            OrderViewModel orderViewModel = new OrderViewModel();

            ViewBag.Users = _userService.GetUsersForDropDown();
            return View(orderViewModel);
        }
    }
}
