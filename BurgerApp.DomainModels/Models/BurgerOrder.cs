using BurgerApp.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.DomainModels.Models
{
     public class BurgerOrder
    {
        public int ID { get; set; }
        public Burger Burger { get; set; }
        public int BurgerID { get; set; }
        public Order Order { get; set; }
        public int OrderID { get; set; }
        public BurgerSize BurgerSize { get; set; }
        public double Price { get; set; }


    }
}
