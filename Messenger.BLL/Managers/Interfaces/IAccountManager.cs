﻿using Messenger.BLL.Models;
using Messenger.BLL.Users;
using Messenger.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.BLL.Managers
{
    public interface IAccountManager
    {
        public Task<IdentityResult> RegisterUser(UserRegisterModel model);
        public Task<SignInResult> LoginUser(UserLoginModel model);
        public Task LogoutUser();
        public Task<bool> DeleteUser(string id);
        public Task<bool> ChangeUserPassword(UserChangePasswordModel model);
    }
}
