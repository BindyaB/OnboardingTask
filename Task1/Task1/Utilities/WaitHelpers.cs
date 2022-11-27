using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Task1.Utilities
{
    public class WaitHelpers
    {
        //reusable function for wait
        public static void WaitToBeClickable(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
        }
    }
}
