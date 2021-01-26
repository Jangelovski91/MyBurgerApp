using BurgerApp.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BurgerApp.ViewModels.Order
{
    public class OrderViewModel
    {
        public int ID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string BurgerStore  { get; set; }

        public bool Delivered { get; set; }
        [Display(Name = "User")]
        public int UserID { get; set; }
    }
}
