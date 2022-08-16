using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestProject;

namespace UnitTest1
{
    [TestClass]
    public class ParametersTest
    {
        [TestMethod]
        public void ParametersTestValueClass()
        {
            Card card1 = new Card();
            card1.Test = "Testing...";

            ChangeName(card1);

            Assert.AreEqual("Test1", card1.Test);
        }

        [TestMethod]
        public void ParametersTestValueInt()
        {
            int x = 5;
            Add(x);
            Assert.AreEqual(6, x);
        }

        [TestMethod]
        public void ParametersTestValueIntRef()
        {
            int x = 10;
            AddRef(ref x);
            Assert.AreEqual(11, x);
        }


        private void AddRef(ref int x)
        {
            x++;
        }

        private void Add(int x)
        {
            x++;
        }

        private void ChangeName(Card card1)
        {
            card1.Test = "Test1";
        }
    }
}
