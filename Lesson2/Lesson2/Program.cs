using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // comments

            // one line comment

            /*
             * 
             * 
             * multiple line comment
             * 
             */

            // hover on Method
            int number = 1;
            Method(number);
        }

        // below thi comment using three slash we can make comment for our function and later when you want to use this function you can check title, parametrs and what returns

        /// <summary>
        /// Our method counts numbers
        /// </summary>
        /// <param name="num1">only numbers from 1 to 2</param>
        /// <returns>returns false or true</returns>
        public static bool Method(int num1)
        {
            return true;
        }
        // public variable or function mean that we can use this outside of our code

        private bool Method2(int num2)
        {
            return false;
        }
        // private variable or function mean that we can ue this only inside our class

        // another "comment" method is use #region and #endregion on the end for example:

        #region Some numbers

        int number1 = 2;

        #region Another numbers inside numbers
        int number2 = 3;
        #endregion

        #endregion
    }
}
