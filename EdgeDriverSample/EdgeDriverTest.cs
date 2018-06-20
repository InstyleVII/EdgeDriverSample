using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Edge;

namespace EdgeDriverSample
{
    [TestClass]
    public class EdgeDriverTest
    {
        EdgeDriver driver;
        [TestInitialize]
        public void EdgeDriverInitialize()
        {
            driver = new EdgeDriver();
        }

        [TestMethod]
        public void VerifyPageTitle()
        {
            driver.Url = "https://www.bing.com";
            Assert.AreEqual("Bing", driver.Title);
        }

        [TestCleanup]
        public void EdgeDriverCleanup()
        {
            driver.Quit();
        }
    }
}
