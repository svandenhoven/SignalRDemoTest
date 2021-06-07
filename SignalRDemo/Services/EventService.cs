using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalRDemo.Shared.Models;

namespace SignalRDemo.Services
{
    public class EventService


    {
        public static async Task ProcessEvent(Message msg)
        {
            var hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:44385/EventHub")
                .WithAutomaticReconnect()
                .Build();

            await hubConnection.StartAsync();
            await hubConnection.SendAsync("ProcessEvent", msg);
        }
    }
}
