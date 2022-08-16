using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message();
            Send send = new Send(msg.SendMessage);

            send("Hello, I'm Michael.");

            send += new Send(TestMethod);
            send("yes it works too! double!");
        }

        private static void TestMethod(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
    }
}
