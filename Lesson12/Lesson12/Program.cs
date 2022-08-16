using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            Card card2;

            int variable = 5;
            int variable2;

            CardMethodRef(ref card); // with ref <---- we need to initialize in a variable before calling the method
            CardMethodOut(out card2); // with out <---- we don't need to initalize in a variable before calling the method but we need to do this later in method
            VariableMethodRef(ref variable); // with ref <---- we need to initialize in a variable before calling the method
            VariableMethodOut(out variable2); // with out <---- we don't need to initalize in a variable before calling the method but we need to do this later in method

            Console.WriteLine(card.Test + "\n--------\n" + card2.Test + "\n--------\n" + variable + "\n--------\n" + variable2);
        }

        static void CardMethodRef(ref Card card)
        {
            card.Test = "Hi";
        }

        static void CardMethodOut(out Card card)
        {
            card = new Card();
            card.Test = "Hello";
        }

        static void VariableMethodRef(ref int variable)
        {
            variable = 10;
        }

        static void VariableMethodOut(out int variable)
        {
            variable = 2;
        }

        // It's better to use method with return than use out or ref!
    }
}
