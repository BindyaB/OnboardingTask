using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Pages
{
    public class SkillFeature
    {
        public void AddSkill(IWebDriver driver)
        {
            //identify skill tab and click

            IWebElement skillsTab = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();

            //identify add new button and click

            IWebElement skillsAddNewButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            skillsAddNewButton.Click();

            //identify add skill textbox and enter a new skill

            IWebElement addNewSkillsTextBox = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addNewSkillsTextBox.Click();
            addNewSkillsTextBox.SendKeys("Painting");

            //identify choose level dropdown menu and enter a level

            IWebElement newSkillLevelDropdownMenu = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            newSkillLevelDropdownMenu.Click();
            Thread.Sleep(3000);
            IWebElement chooseNewLevelDropdownMenu = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SelectElement newSkillLevel = new SelectElement(chooseNewLevelDropdownMenu);
            newSkillLevel.SelectByText("Intermediate");

            //identify add button and click

            IWebElement addNewSkillButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addNewSkillButton.Click();

            //check if the skill has been added

        }

        public void CancelSkill(IWebDriver driver)
        {
            //identify cancel button and click for a new skill

            IWebElement cancelAddNewButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            cancelAddNewButton.Click();
            Thread.Sleep(5000);
            IWebElement cancelSkillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
            cancelSkillButton.Click();


        }

        public void EditSkill(IWebDriver driver)
        {
            // identify and write icon and click to edit a skill
            Thread.Sleep(2000);
            IWebElement editSkillWriteIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            editSkillWriteIcon.Click();

            //identify add skill text box and edit the exsisitng skill
            Thread.Sleep(2000);
            IWebElement editAddSkillTextbox = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            editAddSkillTextbox.Click();
            editAddSkillTextbox.Clear();
            editAddSkillTextbox.SendKeys("Tango");

            //identify skill level to edit skill
            IWebElement editSkillLeveldropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
            editSkillLeveldropdown.Click();
            IWebElement editSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
            SelectElement editSkill = new SelectElement(editSkillLevel);
            editSkill.SelectByText("Expert");

            //identify update button and click to save the updated skill
            IWebElement skillUpdateButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            skillUpdateButton.Click();

            //check if the edit was successful

        }

        public void DeleteSkill(IWebDriver driver)
        {
            //identify the delete button and click to delete an already entered skill

            Thread.Sleep(8000);

            IWebElement deleteSkillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]/i"));
            deleteSkillButton.Click();


            //check if the skill has been deleted


        }
    }
}
