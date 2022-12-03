using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Task1.Utilities;

namespace Task1.Pages
{
    public class SkillFeature
    {
        public void AddSkill(IWebDriver driver)
        {
            //identify skill tab and click
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 8);
            IWebElement skillsTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();

            //identify add new button and click
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 5);
            IWebElement skillsAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            skillsAddNewButton.Click();

            //identify add skill textbox and enter a new skill
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input", 5);
            IWebElement addNewSkillsTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addNewSkillsTextBox.Click();
            addNewSkillsTextBox.SendKeys("Painting");

            //identify choose level dropdown menu and enter a level
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select", 5);
            IWebElement newSkillLevelDropdownMenu = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            newSkillLevelDropdownMenu.Click();
            IWebElement chooseNewLevelDropdownMenu = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SelectElement newSkillLevel = new SelectElement(chooseNewLevelDropdownMenu);
            newSkillLevel.SelectByText("Intermediate");

            //identify add button and click
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]", 5);
            IWebElement addNewSkillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addNewSkillButton.Click();

            //check if the skill has been added
            Thread.Sleep(5000);
            IWebElement addedNewSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Console.WriteLine(addedNewSkill.Text);
            if(addedNewSkill.Text== "Painting")
            {
                Console.WriteLine("Skill added successfully");
            }
            else
            {
                Console.WriteLine("Skill not added");
            }


        }

        public void CancelSkill(IWebDriver driver)
        {
            //identify cancel button and click for a new skill
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 9);
            IWebElement cancelAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            cancelAddNewButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]", 5);
            IWebElement cancelSkillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
            cancelSkillButton.Click();

        }

        public void EditSkill(IWebDriver driver)
        {
            // identify and write icon and click to edit a skill
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 5);
            IWebElement editSkillWriteIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editSkillWriteIcon.Click();

            //identify add skill text box and edit the exsisitng skill
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input", 5);
            IWebElement editAddSkillTextbox = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editAddSkillTextbox.Click();
            editAddSkillTextbox.Clear();
            editAddSkillTextbox.SendKeys("Tango");

            //identify skill level to edit skill

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select", 5);
            IWebElement editSkillLeveldropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            editSkillLeveldropdown.Click();
            IWebElement editSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            SelectElement editSkill = new SelectElement(editSkillLevel);
            editSkill.SelectByText("Expert");

            //identify update button and click to save the updated skill
            IWebElement skillUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            skillUpdateButton.Click();

            //check if the edit was successful
            Thread.Sleep(8000);
            IWebElement editedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Console.WriteLine(editedSkill.Text);
            if(editedSkill.Text == "Tango")
            {
                Console.WriteLine("Skill edited");
            }
            else
            {
                Console.WriteLine("SkillFeature not edited");
            }
        }

        public void DeleteSkill(IWebDriver driver)
        {
            //identify the delete button and click to delete an already entered skill
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 5);
            IWebElement deleteSkillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteSkillButton.Click();

            //check if the skill has been deleted
            Thread.Sleep(8000);
            IWebElement deletedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (deletedSkill.Text == "Tango")
            {
                Console.WriteLine("Skill not deleted");
            }
            else
            {
                Console.WriteLine("Skill deleted");
            }
        }
    }
}
