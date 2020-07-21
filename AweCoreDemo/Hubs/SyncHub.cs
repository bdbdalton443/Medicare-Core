using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace AweCoreDemo.Hubs
{
    public class SyncHub : Hub
    {
        public Task SendMessage(string message)
        {
           return Clients.All.SendAsync("ReceiveMessage", message);
        }
        public Task SendSelfMessage(string user, string message)
        {
            return Clients.All.SendAsync("ReceiveSelfMessage", user, message);
        }
    }
}