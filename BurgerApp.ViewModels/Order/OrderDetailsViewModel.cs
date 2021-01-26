using BurgerApp.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BurgerApp.ViewModels.Order
{
    public class OrderDetailsViewModel
    {
        public int ID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        [Display(Name = "The name of the burger")]
        public List<string> BurgerNames { get; set; }
        public string UserFullName { get; set; }
        public string BurgerStore { get; set; }
        public double Price { get; set; }
        public bool Delivered { get; set; }
    }
}
