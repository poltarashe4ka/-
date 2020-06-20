using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10; 
            int b = 11;
            int c = 12;
            int max = Math.Max(Math.Max(a, b),(c)); // переменная max будет равна наибольшему числу из переменных abc
            int actual = 13; // переменная необходимая для подтверждения теста
            Assert.AreEqual(max, actual); // Собственно сама функция подачи положительного или отрицательного прохождения теста если max != actual то тест не будет пройден.

        }
    }
}
