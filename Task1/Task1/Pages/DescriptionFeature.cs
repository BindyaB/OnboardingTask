using NUnit.Framework;
using OpenQA.Selenium;
using Task1.Utilities;

namespace Task1.Pages
{
    public class DescriptionFeature
    {
        public void AddDescription(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 10);

            //adding description
            //click on the write icon
            IWebElement writeIcon = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            writeIcon.Click();

            //identify the description textbox and add text
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionTextbox.Click();
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("Hi, I am a ballet dancer wanting to share my skills on this medium. I am a great ballet dancer and I can teach kids or grown ups of any age.");

            //identify the save button and click
            IWebElement descSaveButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            descSaveButton.Click();


        }   
        public string GetDescription(IWebDriver driver)
        { 
            //check if the description has been entered
            WaitHelpers.WaitToExist(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/span", 5);
            IWebElement descText = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return descText.Text;
            

        }
    }
}
