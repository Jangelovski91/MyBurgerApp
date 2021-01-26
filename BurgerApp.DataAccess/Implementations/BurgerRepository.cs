using BurgerApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BurgerApp.DataAccess.Implementations
{
    public class BurgerRepository : IRepository<Burger>
    {
        public void DeleteByID(int id)
        {
            Burger burger = StaticDB.Burgers.FirstOrDefault(b => b.ID == id);
            if (burger == null)
            {
                throw new Exception($"Burger with id {id} was not found.");
            }
            int index = StaticDB.Burgers.IndexOf(burger);
            StaticDB.Burgers.RemoveAt(index);

            
        }

        public List<Burger> GetAll()
        {
            return
            StaticDB.Burgers;
        }

        public Burger GetByID(int id)
        {
            return StaticDB.Burgers.Where(b => b.ID == id).FirstOrDefault();
        }

        public int Insert(Burger entity)
        {
            StaticDB.BurgerID++;
            entity.ID = StaticDB.BurgerID;
            StaticDB.Burgers.Add(entity);
            return entity.ID;
        }

        public void Update(Burger entity)
        {
            Burger burger = StaticDB.Burgers.FirstOrDefault(b => b.ID == entity.ID);
            if(burger == null)
            {
                throw new Exception($"Burger with id {entity.ID} was not found.");
            }
            int index = StaticDB.Burgers.IndexOf(burger);
            StaticDB.Burgers[index] = entity;
        }
    }
}
