using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalRDemo.Shared.Models;

namespace SignalRHub.Hubs
{
    public class EventHub : Hub
    {

        public async Task ProcessEvent(Message msg)
        {
            await Clients.All.SendAsync("MessageProcessed", msg.Body);
        }
    }
}
