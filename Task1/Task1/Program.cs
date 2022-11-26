
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

//open thw chrome browser

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//launch localhost 5000

driver.Navigate().GoToUrl("http://localhost:5000");
Thread.Sleep(3000);


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
Thread.Sleep(5000);

//adding description
//click on the write icon
IWebElement writeIcon = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
writeIcon.Click();
Thread.Sleep(3000);

//identify the description textbox and add text
IWebElement descriptionTextbox = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
descriptionTextbox.Clear();
descriptionTextbox.Click();
descriptionTextbox.SendKeys("Hi, I am a ballet dancer wanting to share my skills on this medium. I am a great ballet dancer and I can teach kids or grown ups of any age.");

//identify the save button and click
IWebElement descSaveButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
descSaveButton.Click();
Thread.Sleep(8000);


//check if the description has been entered

//String descText = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;
//Console.WriteLine(descText);

//if (descText == "Hi, I am a ballet dancer wanting to share my skills on this medium. I am a great ballet dancer and I can teach kids or grown ups of any age.")
//{
//    Console.WriteLine("Description Saved");
//}
//else
//{
//    Console.WriteLine("Description Not saved");
//}

//Assert.That(descText == "Description has been saved successfully", "Description has not been saved");


//Editing languages page

IWebElement langTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
langTab.Click();



//Identify and click on the add new button
Thread.Sleep(6000);
IWebElement newLangButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
newLangButton.Click();

//Identify languages add language textbox and click
IWebElement addLangButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
addLangButton.Click();
addLangButton.SendKeys("Korean");

Thread.Sleep(4000);

//Identify and choose a level on the choose language level menu
IWebElement chooseLeveldropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
chooseLeveldropdown.Click();
IWebElement langLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
SelectElement oSelect = new SelectElement(langLevel);
oSelect.SelectByText("Fluent");


//Click on the add button
IWebElement newLangAddButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
newLangAddButton.Click();

//check if the new language has been added

//using cancel button in the addnew functionality

Thread.Sleep(8000);

IWebElement newLanguageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
newLanguageButton.Click();
Thread.Sleep(8000);
IWebElement newLangCancelButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
newLangCancelButton.Click();

//check if the entry was cancelled



//editing an exsisiting language
//Click on the write icon to an already entered language
IWebElement editLangIcon = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
editLangIcon.Click();

//click on the language text box to edit language
IWebElement editLanguageTextbox = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
editLanguageTextbox.Click();
editLanguageTextbox.Clear();
editLanguageTextbox.SendKeys("Malaysian");

//click on the level dropdown menu to edit a level
IWebElement editLeveldropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
editLeveldropdown.Click();

Thread.Sleep(6000);
IWebElement editlangLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
SelectElement editLevel = new SelectElement(editlangLevel);
editLevel.SelectByText("Native/Bilingual");


//click onthe update button to make changes
IWebElement updateButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
updateButton.Click();
Thread.Sleep(3000);

//delete an exisisting language
//identify delete icon and click
IWebElement deleteLangButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
deleteLangButton.Click();



//check if the language has been deleted



Thread.Sleep(8000);
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

//identify cancel button and click for a new skill

IWebElement cancelAddNewButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
cancelAddNewButton.Click();
Thread.Sleep(5000);
IWebElement cancelSkillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
cancelSkillButton.Click();


//identify and write icon and click to edit a skill
Thread.Sleep(2000);
IWebElement editSkillWriteIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
editSkillWriteIcon.Click();

//identify add skill text box and edit the exsisitng skill
Thread.Sleep(2000);
IWebElement editAddSkillTextbox = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
editAddSkillTextbox.Click();
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

//identify the delete button and click to delete an already entered skill

Thread.Sleep(8000);

IWebElement deleteSkillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]/i"));
deleteSkillButton.Click();


//check if the skill has been deleted




