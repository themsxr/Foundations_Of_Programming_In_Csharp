using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Constructor constructor1 = new Constructor();
            Constructor constructor2 = new Constructor("Lucifer", "Morningstar");
            Constructor constructor3 = new Constructor("Ben", "Ten", 10);
            Constructor constructor4 = new Constructor("Johnny", "Bubblegumm", "New York City", "Wallstreet", 35);
        }
    }
}
