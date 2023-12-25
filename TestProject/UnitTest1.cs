using TarkovKar;
using System.Data.SqlClient;
using System.Windows;
using System;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            MainWindow passwordBox = new MainWindow();
            passwordBox.Password = "Test123";

            Assert.AreEqual("Test123", passwordBox.Password);

        }
    }
}