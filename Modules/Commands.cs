using System;
using System.Threading.Tasks;
using Discord.Commands;

namespace Bot.Commands
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        Random rnd = new Random();

        /// <summary>
        /// Command Example
        /// </summary>
        /// <returns></returns>
        [Command("CommandOne")]
        public async Task Ping()
        {
            var user = Context.User;//if you want ping user
            await ReplyAsync($"TEXT");
        }
    }
}
