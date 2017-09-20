﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace ManagerTelegramBot.Models
{
    public class HelloCommand : Command
    {
        public override string Name => "Hello";

        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            // TODO: Bot logic -_-

            client.SendTextMessageAsync(chatId, "Hello!", replyToMessageId: messageId);
        }
    }
}