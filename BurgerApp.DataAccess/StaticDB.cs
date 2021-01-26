using BurgerApp.DomainModels.Enums;
using BurgerApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BurgerApp.DataAccess
{
    public static class StaticDB
{ 
        static StaticDB()
    {
            BurgerID = 3;
            OrderID = 2;
            UserID = 2;
            BurgerOrderID = 4;
            
            Burgers = new List<Burger>
            {
                new Burger
                {
                    ID = 1,
                    Name = "Hamburger",
                    IsOnPromotion = false,
                    BurgerOrders = new List<BurgerOrder>{}
                    
                },
                 new Burger
                 {
                    ID = 2,
                    Name = "Cheesburger",
                    IsOnPromotion = true,
                    BurgerOrders = new List<BurgerOrder>{}
                    
                 },
                 new Burger
                 {
                    ID = 3,
                    Name = "Veggieburger",
                    IsOnPromotion = false,
                    BurgerOrders = new List<BurgerOrder>{}
                    
                 }

        };
            Users = new List<User>
            {
                new User
                {
                    ID = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "Address1",
                    Orders = new List<Order>{}
                },
                 new User
                 {
                    ID = 2,
                    FirstName = "Jack",
                    LastName = "Johns",
                    Address = "Address2",
                    Orders = new List<Order>{}
                 }

        };
            Orders = new List<Order>
            {
                new Order
                {
                    ID = 1,
                    PaymentMethod = PaymentMethod.Cash,
                    BurgerStore = "Aerodrom",
                    BurgerOrders = new List<BurgerOrder>
                    {
                        new BurgerOrder
                        {
                            ID = 1,
                            Burger = Burgers[0],
                            BurgerSize = BurgerSize.medium,
                            Price = 150
                        },
                        new BurgerOrder
                        {
                            ID =2,
                            Burger = Burgers[1 ],
                            BurgerSize = BurgerSize.large,
                            Price = 180
                        }

                    },
                    User = Users[0]
                },
                 new Order
                {
                    ID = 2,
                    PaymentMethod = PaymentMethod.Card,
                    BurgerStore = "Debar Maalo",
                    BurgerOrders = new List<BurgerOrder>
                    {
                        new BurgerOrder
                        {
                            ID = 3,
                            Burger = Burgers[0],
                            BurgerSize = BurgerSize.small,
                            Price = 120
                        },
                        new BurgerOrder
                        {
                            ID =4,
                            Burger = Burgers[2],
                            BurgerSize = BurgerSize.large,
                            Price  = 180
                        }

                    },
                    User = Users[1]
                },

        };

        }
    
        public static int BurgerID { get; set; }
        public static int OrderID { get; set; }
        public static int UserID { get; set; }
        public static int BurgerOrderID { get; set; }
        public static List<Burger> Burgers { get; set; }
        public static List<Order> Orders { get; set; }
        public static List<User> Users   { get; set; }

    }
}
