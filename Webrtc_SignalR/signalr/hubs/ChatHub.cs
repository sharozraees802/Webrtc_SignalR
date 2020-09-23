﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;


namespace Webrtc_SignalR.signalr.hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
          Clients.All.addNewMessageToPage(name, message);
        }


    }
}