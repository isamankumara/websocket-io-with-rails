using System;
using WebSocket4Net;

using UIKit;
using SuperSocket.ClientEngine;

namespace SocketApp
{
    public partial class ViewController : UIViewController
    {
        WebSocket websocket = new WebSocket("ws://192.168.8.104:3000/cable");

        protected ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            websocket.Opened += new EventHandler(websocket_Opened);
            websocket.Error += new EventHandler<ErrorEventArgs>(websocket_Error);
            websocket.Closed += new EventHandler(websocket_Closed);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(websocket_MessageReceived);
            websocket.Open();

            base.ViewDidLoad();
        }

        private void websocket_Error(object sender, ErrorEventArgs e)
        {
        }

        private void websocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        { 
        }

        private void websocket_Closed(object sender, EventArgs e)
        {
        }

        private void websocket_Opened(object sender, EventArgs e)
        {
        }
    }
}
