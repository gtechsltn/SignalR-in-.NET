using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SinglRDataProcess.Hubs
{
    public class RealTimeHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }

        public async Task BroadcastData(object data)
        {
            await Clients.All.SendAsync("ReceiveData", data);
        }
    }
}
