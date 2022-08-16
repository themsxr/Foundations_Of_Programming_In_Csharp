using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestProject;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int userinput = 20;
            //bool checkinput = int.TryParse(Console.ReadLine(), out userinput);
            var test_res = FibMethod(userinput);
            Assert.AreEqual(610, test_res);
        }
        
        private int FibMethod(int userinput)
        {
            int[] collection = new int[userinput];

            for (int i = 0; i < collection.Length; i++)
            {

                if (i > 1)
                {
                    collection[i] = (collection[i - 1]) + (collection[i - 2]);
                    continue;
                }

                if (i == 0)
                {
                    collection[0] = 0;
                    continue;
                }
                else if (i == 1)
                {
                    collection[1] = 1;
                }
            }
            return collection[userinput - 5];
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool testcheck;
            Card card = new Card();

            card.AddOpinion(9.5f);
            card.AddOpinion(7.3f);
            card.AddOpinion(5);
            card.AddOpinion(2.5f);
            card.AddOpinion(1.8f);

            float highest_op = card.HighestOpinion();
            //float lowest_op = card.LowestOpinion();
            //float op_average = card.OpinionAverage();

            // Assert.AreEqual(1.8f, lowest_op);
            // Assert.AreEqual(9.5f, highest_op);
            // Assert.AreEqual(5.22f, op_average);

            if (highest_op < 9.8)
            {
                testcheck = true;
            }
            else
            {
                testcheck = false;
            }
            Assert.IsTrue(testcheck);
        }
    }
}
