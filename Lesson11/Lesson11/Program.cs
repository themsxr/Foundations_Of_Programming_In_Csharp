using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(); // We did new Object with indicator card to object in memory
            card.AddOpinion(2);
            card.AddOpinion(6);
            card.AddOpinion(4);

            Card card2 = card; // Now we did indicator card2 which indicates on the same object in memory
            card2.AddOpinion(9);
            // As we can see we can see number 9 in card and in card2 because it's the same object and those are just indicators to object
        }
    }
}
