using BurgerApp.DataAccess;
using BurgerApp.DomainModels.Models;
using BurgerApp.Mappers.User;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.Services.Implemenations
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public List<UserDDViewModel> GetUsersForDropDown()
        {
            List<User> users = _userRepository.GetAll();
            List<UserDDViewModel> userDDViewModels = new List<UserDDViewModel>();
            foreach(User user in users)
            {
                userDDViewModels.Add(user.ToUserDDViewModel());
            }
            return userDDViewModels;
        }
    }
}
