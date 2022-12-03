
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

LanguageFeature languageFeatureObj = new LanguageFeature();
languageFeatureObj.AddLanguage(driver);
languageFeatureObj.CancelAddLanguage(driver);
languageFeatureObj.EditLanguage(driver);
languageFeatureObj.DeleteLanguage(driver);

//Skill feature object intialisation and definition

SkillFeature skillFeatureObj = new SkillFeature();
skillFeatureObj.AddSkill(driver);
skillFeatureObj.CancelSkill(driver);
skillFeatureObj.EditSkill(driver);
skillFeatureObj.DeleteSkill(driver);


















