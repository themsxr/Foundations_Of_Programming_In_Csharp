using System;

namespace Delegates
{
    public class Message
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message.ToLower());
        }
    }
}
