using BurgerApp.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.DomainModels.Models
{
    public class Order
    {
        public int ID { get; set; }
        public PaymentMethod PaymentMethod  { get; set; }
        public bool Delivered  { get; set; }
        public string BurgerStore { get; set; }
        public List<BurgerOrder> BurgerOrders { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
