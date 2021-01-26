using BurgerApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BurgerApp.DataAccess.Implementations
{
    public class OrderRepository : IRepository<Order>
    {
        public void DeleteByID(int id)
        {
            Order order = StaticDB.Orders.FirstOrDefault(o => o.ID == id);
            if (order == null)
            {
                throw new Exception($"Order with id {id} was not found.");
            }
            
            StaticDB.Orders.Remove(order);


        }

        public List<Order> GetAll()
        {
            return
            StaticDB.Orders;
        }

        public Order GetByID(int id)
        {
            return StaticDB.Orders.FirstOrDefault(o => o.ID == id);
        }

        public int Insert(Order entity)
        {
            StaticDB.OrderID++;
            entity.ID = StaticDB.BurgerID;
            StaticDB.Orders.Add(entity);
            return entity.ID;
        }

        public void Update(Order entity)
        {
            Order order = StaticDB.Orders.FirstOrDefault(o => o.ID == entity.ID);
            if (order == null)
            {
                throw new Exception($"Order with id {entity.ID} was not found.");
            }
            int index = StaticDB.Orders.IndexOf(order);
            StaticDB.Orders[index] = entity;
        }
       
        
    }
}
