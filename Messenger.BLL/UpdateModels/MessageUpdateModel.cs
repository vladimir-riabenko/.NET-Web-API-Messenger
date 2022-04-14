﻿using Messenger.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.BLL.UpdateModels
{
    public class MessageUpdateModel
    {
        public ICollection<MessageImageModel> Images { get; set; }
        public string Text { get; set; }
    }
}
