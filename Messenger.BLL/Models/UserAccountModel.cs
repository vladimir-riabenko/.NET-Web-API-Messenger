﻿using System;
using System.Collections.Generic;
using Messenger.BLL.Users;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.BLL.Models
{
    public class UserAccountModel
    {
        public ChatModel Chat { get; set; }
        public UserModel User { get; set; }
        public bool IsBanned { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsOwner { get; set; }
    }
}
