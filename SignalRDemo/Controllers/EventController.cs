using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalRDemo.Services;
using SignalRDemo.Shared.Models;

namespace SignalRDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Get(string message)
        {
            if (message != null)
            {
                var msg = new Message { Body = message };
                await EventService.ProcessEvent(msg);

                return "done";
            }
            else
            {
                return "no message";
            }
        }
    }


}
