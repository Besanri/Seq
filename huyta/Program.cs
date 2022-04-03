using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using System.Net;


namespace Pudgebot
{
    class Program
    {
        private static string token = "5191831410:AAH-wDp-S1Iq_eJWhkY945nQtXmcJ-9d-kk";
        private static TelegramBotClient? client;
        static void Main(string[] args)
        {
            client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();
        }

        private static void OnMessageHandler(object? sender, MessageEventArgs e)
        {
            if (e.Message != null && e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && !string.IsNullOrEmpty(e.Message.Text))
            {
                try
                {
                    if (e.Message.Text.ToLower().Contains("пудж"))
                    {
                        client.SendTextMessageAsync(e.Message.Chat.Id, "They call me the Butcher.");
                    }
                    else if (e.Message.Text.ToLower().Contains("падж"))
                    {
                        client.SendTextMessageAsync(e.Message.Chat.Id, "They call me the Butcher.");
                    }
                    else if (e.Message.Text.ToLower().Contains("пиджак"))
                    {
                        client.SendTextMessageAsync(e.Message.Chat.Id, "They call me the Butcher.");
                    }
                    else if (e.Message.Text.ToLower().Contains("pudge"))
                    {
                        client.SendTextMessageAsync(e.Message.Chat.Id, "They call me the Butcher.");
                    }
                    else if (e.Message.Text.ToLower().Contains("pajero"))
                    {
                        client.SendTextMessageAsync(e.Message.Chat.Id, "They call me the Butcher.");
                    }
                    else if (e.Message.Text.ToLower().Contains("пудге"))
                    {
                        client.SendTextMessageAsync(e.Message.Chat.Id, "They call me the Butcher.");
                    }
                    else if (e.Message.Text.ToLower().Contains("паш"))
                    {
                        client.SendTextMessageAsync(e.Message.Chat.Id, "хуесос, ой");
                    }
                }
                catch (Exception eee)
                {

                }
            }

        }
    }
}

