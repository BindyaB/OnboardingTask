using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Task1.Utilities;

namespace Task1.Pages
{
    public class LanguageFeature
    {
        public void AddLanguage(IWebDriver driver)
        {
            //identify language tab and click

            IWebElement langTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            langTab.Click();


            //Identify and click on the add new button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 6);
            IWebElement newLangButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            newLangButton.Click();

            //Identify languages add language textbox and click
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 6);
            IWebElement addLangButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLangButton.Click();
            addLangButton.SendKeys("Korean");

            //Identify and choose a level on the choose language level menu
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 4);
            IWebElement chooseLeveldropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLeveldropdown.Click();
            IWebElement langLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            SelectElement oSelect = new SelectElement(langLevel);
            oSelect.SelectByText("Fluent");

            //Click on the add button
            IWebElement newLangAddButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            newLangAddButton.Click();

            //check if the new language has been added
            Thread.Sleep(5000);
            //WaitHelpers.WaitToExist(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 8);
            IWebElement newLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Console.WriteLine(newLanguage.Text);           
            if (newLanguage.Text == "Korean")
            {
                Console.WriteLine("Language Succesfully saved");
            }
            else
            {
                Console.WriteLine("Language not saved");
            }

        }

        public void CancelAddLanguage(IWebDriver driver)
        {
            //using cancel button in the addnew functionality
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 8);
            
            IWebElement newLanguageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            newLanguageButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]", 4);
            IWebElement newLangCancelButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
            newLangCancelButton.Click();

            //check if the entry was cancelled

            IWebElement cancelNewLang = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (cancelNewLang.Text == "Korean")
            {
                Console.WriteLine("Cancel functionality is working");
            }
            else
            {
                Console.WriteLine("Cancel functionality is not working ");
            }

        }

        public void EditLanguage(IWebDriver driver)
        {
            //editing an exsisiting language
            //Click on the write icon to an already entered language

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 8);

            IWebElement editLangIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editLangIcon.Click();

            //click on the language text box to edit language
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input", 5);
            IWebElement editLanguageTextbox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input"));
            editLanguageTextbox.Click();
            editLanguageTextbox.Clear();
            editLanguageTextbox.SendKeys("Malaysian");

            //click on the level dropdown menu to edit a level
            IWebElement editLeveldropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[2]/select"));
            editLeveldropdown.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[2]/select", 8);
            IWebElement editlangLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[2]/select"));
            SelectElement editLevel = new SelectElement(editlangLevel);
            editLevel.SelectByText("Native/Bilingual");


            //click onthe update button to make changes
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]", 8);
            IWebElement updateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]"));
            updateButton.Click();

            //Test for edit functionality
            Thread.Sleep(8000);
            IWebElement editedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
            //IWebElement editedLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            Console.WriteLine(editedLanguage.Text);
            if(editedLanguage.Text == "Malaysian")
            {
                Console.WriteLine("Language has been edited");
            }
            else
            {
                Console.WriteLine("Edited language has not been saved");
            }

        }

        public void DeleteLanguage(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 3);
            //delete an exisisting language
            //identify delete icon and click
            IWebElement deleteLangButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteLangButton.Click();

            //check if the language has been deleted
            IWebElement deletedLang = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            if (deletedLang.Text == "Malaysian")
            {
                Console.WriteLine("Language has not been deleted");
            }
            else
            {
                Console.WriteLine("Language has been deleted");
            }



        }
    }
}
