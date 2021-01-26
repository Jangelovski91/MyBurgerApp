using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.DomainModels.Models
{
    public class Burger
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsOnPromotion { get; set; }
        public List<BurgerOrder> BurgerOrders { get; set; }
    }
}
