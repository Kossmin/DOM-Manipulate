using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoChatApp2.Hubs
{
    public class DemoChat : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Message(string message)
        {
            Clients.All.message(message);
        }
    }
}