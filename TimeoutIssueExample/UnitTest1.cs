using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeoutIssueExample
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void TestInitialize()
        {
            Browser.Start();
            Browser.Navigate(new Uri("https://www.google.de/"));
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            var page = new GoogleHomePage();
            Assert.IsTrue(page.IsPageOpenend());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Browser.Close();
        }
    }
}