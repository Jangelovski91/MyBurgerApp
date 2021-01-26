using BurgerApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BurgerApp.DataAccess.Implementations
{
    public class UserRepository : IRepository<User>
    {
        public void DeleteByID(int id)
        {
            User user = StaticDB.Users.FirstOrDefault(u => u.ID == id);
            if (user == null)
            {
                throw new Exception($"User with id {id} was not found.");
            }

            StaticDB.Users.Remove(user);


        }

        public List<User> GetAll()
        {
            return
            StaticDB.Users;
        }

        public User GetByID(int id)
        {
            return StaticDB.Users.FirstOrDefault(u => u.ID == id);
        }

        public int Insert(User entity)
        {
            StaticDB.UserID++;
            entity.ID = StaticDB.UserID;
            StaticDB.Users.Add(entity);
            return entity.ID;
        }

        public void Update(User entity)
        {
            User user = StaticDB.Users.FirstOrDefault(u => u.ID == entity.ID);
            if (user == null)
            {
                throw new Exception($"User with id {entity.ID} was not found.");
            }
            int index = StaticDB.Users.IndexOf(user);
            StaticDB.Users[index] = entity;
        }
    }
}
