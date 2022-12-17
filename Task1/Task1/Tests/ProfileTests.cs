
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Task1.Pages;

//open thw chrome browser

IWebDriver driver = new ChromeDriver();

//login page object intialisation and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginSteps(driver);

//description feature object intialisation and definition
DescriptionFeature descriptionFeatureobj = new DescriptionFeature();
descriptionFeatureobj.AddDescription(driver);

//Language feature object intialisation and definition

LanguageTab languageFeatureObj = new LanguageTab();
//languageFeatureObj.AddLanguage(driver, language, level);
//languageFeatureObj.EditLanguage(driver);
languageFeatureObj.DeleteLanguage(driver);

//Skill feature object intialisation and definition

SkillTab skillFeatureObj = new SkillTab();
//skillFeatureObj.AddSkill(driver);
//skillFeatureObj.EditSkill(driver);
skillFeatureObj.DeleteSkill(driver);


















