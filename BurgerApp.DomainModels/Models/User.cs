using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.DomainModels.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public List<Order>  Orders { get; set; }

    }
}
