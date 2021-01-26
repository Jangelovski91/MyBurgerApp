using BurgerApp.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.Services.Interfaces
{
    public interface IUserService
    {
        List<UserDDViewModel> GetUsersForDropDown();
    }
}
