using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Methods
    {
        private void WriteAsByte(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            foreach (var b in bytes)
            {
                Console.WriteLine("0x{0:x2}", b);
            }
        }
    }
}
