﻿using Messenger.DAL.Context;
using Messenger.DAL.Entities;
using Messenger.DAL.Repositories.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.DAL.Repositories
{
    public class ChatsRepository : BaseMongoRepository<Chat>, IChatsRepository
    {
        public ChatsRepository(MongoDbContext context) : base(context)
        {
        }
    }
}
