using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Task1.Utilities;

namespace Task1.Pages
{
    public class LanguageTab
    {
       
        public void GoToLanguageTab(IWebDriver driver)
        {
            //identify language tab and click
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10);
            IWebElement langTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            langTab.Click();
        }

        public void AddLanguage(IWebDriver driver, string language, string level)
        {

            //Identify and click on the add new button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 10);
            IWebElement newLangButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            newLangButton.Click();

            //Identify languages add language textbox and click
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 10);
            IWebElement addLangButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLangButton.Click();
            addLangButton.SendKeys(language);

            //Identify and choose a level on the choose language level menu
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 4);
            IWebElement chooseLeveldropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLeveldropdown.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 4);
            IWebElement langLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            SelectElement oSelect = new SelectElement(langLevel);
            oSelect.SelectByText(level);

            //Click on the add button
            IWebElement newLangAddButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            newLangAddButton.Click();

        }   
         
        public string GetLanguage(IWebDriver driver)

        { 
            //check if the new language has been added
            Thread.Sleep(5000);
            IWebElement newLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newLanguage.Text;
                    

        }

        
        public void EditLanguage(IWebDriver driver, string language, string level)
        {
            //editing an exsisiting language
            //Click on the write icon to an already entered language

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 8);

            IWebElement editLangIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editLangIcon.Click();

            //click on the language text box to edit language
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input", 8);
            IWebElement editLanguageTextbox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editLanguageTextbox.Click();
            editLanguageTextbox.Clear();
            editLanguageTextbox.SendKeys(language);

            //click on the level dropdown menu to edit a level
            IWebElement editLeveldropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            editLeveldropdown.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select", 8);
            IWebElement editlangLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            SelectElement editLevel = new SelectElement(editlangLevel);
            editLevel.SelectByText(level);

            //click onthe update button to make changes
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]", 8);
            IWebElement updateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            updateButton.Click();
                   
                                 
        }
        public string GetEditedLanguage(IWebDriver driver,string language)
        {
            //Test for edit functionality
            Thread.Sleep(8000);
            IWebElement editedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedLanguage.Text; 

        }
        public void DeleteLanguage(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 3);
            //delete an exisisting language
            //identify delete icon and click
            IWebElement deleteLangButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteLangButton.Click();

        }

        public string GetDeletedLang(IWebDriver driver, string language)
        { 
            //check if the language has been deleted
            IWebElement deletedLang = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            return deletedLang.Text;

       

        }
    }
}
