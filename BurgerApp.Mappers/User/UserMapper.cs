using BurgerApp.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.Mappers.User
{
    public static class UserMapper
    {
        public static UserDDViewModel ToUserDDViewModel(this DomainModels.Models.User user)
        {
            return new UserDDViewModel
            {
                ID = user.ID,
                FullName = $"{ user.FirstName} {user.LastName}"

            };
        }
    }
}
