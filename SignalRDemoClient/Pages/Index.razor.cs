using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRDemoClient.Pages
{
    public class IndexBase : ComponentBase
    {
        protected string message = "Init";

        protected override async Task OnInitializedAsync()
        {
            var hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:44385/EventHub")
                .WithAutomaticReconnect()
                .Build();

            try
            {
                await hubConnection.StartAsync();
            }
            catch(Exception ex)
            {
                message = ex.Message;
            }

            hubConnection.On<string>("MessageProcessed", (msg) =>
            {
                message = msg;
                StateHasChanged();
            });

        }
    }
}
