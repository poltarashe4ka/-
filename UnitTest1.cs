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
            int max = Math.Max(Math.Max(a, b),(c)); // ���������� max ����� ����� ����������� ����� �� ���������� abc
            int actual = 13; // ���������� ����������� ��� ������������� �����
            Assert.AreEqual(max, actual); // ���������� ���� ������� ������ �������������� ��� �������������� ����������� ����� ���� max != actual �� ���� �� ����� �������.

        }
    }
}
