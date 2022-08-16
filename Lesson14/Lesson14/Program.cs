using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assemblies
            string usertext;
            SpeechSynthesizer robot = new SpeechSynthesizer();
            for (; ; )
            {
                Console.WriteLine("Insert what you want to say (STOP to stop program): ");
                usertext = Console.ReadLine();
                if (usertext == "STOP")
                {
                    break;
                }
                robot.Speak(usertext);
            }
        }
    }
}
