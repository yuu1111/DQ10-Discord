using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Discord;

namespace DQ10_Discord
{
    class Program
    {
        public static String mes;
        public static DiscordSocketClient client;
        public static CommandService commands;
        public static IServiceProvider services;

        public static Dictionary<int, string> Monster = new Dictionary<int, string>()
        {
            {0, "スライム"},
            {1, "ドラキー"},
        };

        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        /// <summary>
        /// 起動時処理
        /// </summary>
        /// <returns></returns>
        public async Task MainAsync()
        {
            client = new DiscordSocketClient();
            commands = new CommandService();
            services = new ServiceCollection().BuildServiceProvider();
            client.MessageReceived += CommandRecieved;

            client.Log += Log;
            string token = "NDc1MDQxNjE1MjQxODA1ODM0.DkbQBg.1u5xElKnMxK98sJR0ze538kUsrg";
            await commands.AddModulesAsync(Assembly.GetEntryAssembly());
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            await Task.Delay(-1);
        }

        /// <summary>
        /// メッセージの受信処理
        /// </summary>
        /// <param name="msgParam"></param>
        /// <returns></returns>
        public async Task CommandRecieved(SocketMessage messageParam)
        {
            var message = messageParam as SocketUserMessage;
            Console.WriteLine("{0} {1}:{2}", message.Channel.Name, message.Author.Username, message);

            if (message == null) { return; }
            // コメントがユーザーかBotかの判定
            if (message.Author.IsBot) { return; }

            var context = new CommandContext(client, message);

            int argPos = 0;

            foreach (string Value in Monster.Values)
            {
                if (Value == message.Content)
                {


                        mes = message.Content;
                        status.MonsterStatus();
                        await message.Channel.SendMessageAsync(status.mes2);
                    }
                }
            }



        /// <summary>
        /// コンソール表示処理
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}