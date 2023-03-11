﻿using Database.Models;

namespace Core.Models.Geral.Chat
{
    public class ChatModel : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<MessageModel> Messages { get; set; }
    }
}
