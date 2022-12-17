
using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Task1.Utilities;

namespace Task1.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //launch localhost 5000

            driver.Navigate().GoToUrl("http://localhost:5000");
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 5);
            

            //identify and click on the signin button

            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signInButton.Click();

            //identify and click on the email address textbox
            IWebElement emailAddressTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailAddressTextBox.SendKeys("bbindya@gmail.com");

            //identify and click on the password button
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("binda581214");

            //identify and click on the login button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            
        }
    }
}
