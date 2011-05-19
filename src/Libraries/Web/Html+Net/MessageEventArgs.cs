namespace System.Html
{
    public delegate void MessageEventHandler(WebSocket socket, MessageEventArgs e);

    public class MessageEventArgs
    {
        protected MessageEventArgs() { }

        public string Data
        {
            get { return (string)Script.Literal("this.data"); }
        }
    }
}