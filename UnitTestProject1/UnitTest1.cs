using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using TarkovKar;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Window window = new Window();

            // Act
            window.Show(); // открываем окно
            window.Close(); // закрываем окно

            // Assert
            Assert.IsFalse(window.IsVisible); // проверяем, что окно больше не отображается
        }
    }
}
