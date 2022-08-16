using System;
using System.Collections.Generic;
using System.Linq;

namespace FieldsAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            FieldsProperties obj = new FieldsProperties();

            //obj.Testing = null;
            obj.Testing = "Works";

            Console.WriteLine(obj.Testing);
        }
    }
}
