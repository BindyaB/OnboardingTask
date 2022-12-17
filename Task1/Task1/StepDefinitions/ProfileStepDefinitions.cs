using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Task1.Pages;
using Task1.Utilities;
using TechTalk.SpecFlow;

namespace Task1.StepDefinitions
{
    [Binding]
    public class ProfileStepDefinitions:CommonDriver
    {
        
        //DescriptionFeature object intialisation
        DescriptionFeature descriptionFeatureobj = new DescriptionFeature();
        LanguageTab languageFeatureObj = new LanguageTab();
        SkillTab skillFeatureObj = new SkillTab();



        [Given(@"I logged into localhost successfully")]
        public void GivenILoggedIntoLocalhostSuccessfully()
        {
            //open the chrome browser
            driver = new ChromeDriver();
            //login page object intialisation and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I edit the description feature")]
        public void WhenIEditTheDescriptionFeature()
        {
            descriptionFeatureobj.AddDescription(driver);
        }

        
        [Then(@"I am able to see the description")]
        public void ThenIAmAbleToSeeTheDescription()
        {
            string descText = descriptionFeatureobj.GetDescription(driver);
            Assert.That(descText == "Hi, I am a ballet dancer wanting to share my skills on this medium. I am a great ballet dancer and I can teach kids or grown ups of any age.", "Description has not been saved");
        }

        [When(@"I navigate to languages tab")]
        public void WhenINavigateToLanguagesTab()
        {
            languageFeatureObj.GoToLanguageTab(driver);

        }

        [When(@"I add new '([^']*)','([^']*)' to my profile")]
        public void WhenIAddNewToMyProfile(string language, string level)
        {
            languageFeatureObj.AddLanguage(driver, language, level);
        }
                     

        [Then(@"I am able to see '([^']*)' added to my profile")]
        public void ThenIAmAbleToSeeAddedToMyProfile(string language)
        {
            string newLanguage = languageFeatureObj.GetLanguage(driver);
            Assert.That(newLanguage == language, "Language not added");
        }

        [When(@"I edit the exsisting language '([^']*)','([^']*)'")]
        public void WhenIEditTheExsistingLanguage(string language, string level)
        {
            languageFeatureObj.EditLanguage(driver, language, level);
        }

        [Then(@"I am able to see the edited language '([^']*)'")]
        public void ThenIAmAbleToSeeTheEditedLanguage(string language)
        {
            string editedLanguage = languageFeatureObj.GetEditedLanguage(driver, language);
            Assert.That(editedLanguage == language, "Language not edited");
        }

        [When(@"I delete a language '([^']*)'")]
        public void WhenIDeleteALanguage(string language)
        {
            languageFeatureObj.DeleteLanguage(driver);
        }

        [Then(@"I am not able to see the languge in profile '([^']*)'")]
        public void ThenIAmNotAbleToSeeTheLangugeInProfile(string language)
        {

            string deletedLang = languageFeatureObj.GetDeletedLang(driver, language);
            Assert.That(deletedLang != language, "Language not deleted");
        }

        [When(@"I navigate to the skills tab")]
        public void WhenINavigateToTheSkillsTab()
        {
            skillFeatureObj.GoToSkillTab(driver);
        }

        [When(@"I add new '([^']*)' and '([^']*)'to my profile")]
        public void WhenIAddNewAndToMyProfile(string skill, string level)
        {
            skillFeatureObj.AddSkill(driver, skill, level);
        }

        [Then(@"I am able to see my '([^']*)' added to my profile")]
        public void ThenIAmAbleToSeeMyAddedToMyProfile(string skill)
        {
           string addedNewSkill = skillFeatureObj.GetaddedSkill(driver, skill);
           Assert.That(addedNewSkill == skill, "Skill not added");
        }

        [When(@"I edit the exsisting skills '([^']*)','([^']*)'")]
        public void WhenIEditTheExsistingSkills(string skill, string level)
        {
            skillFeatureObj.EditSkill(driver, skill, level);
        }

        [Then(@"I am able to see the edited skills '([^']*)'")]
        public void ThenIAmAbleToSeeTheEditedSkills(string skill)
        {
            string editedSkill = skillFeatureObj.GetEditedSkill(driver, skill);
            Assert.That(editedSkill == skill, "Skill not edited");
        }

        [When(@"I delete a skill '([^']*)'")]
        public void WhenIDeleteASkill(string skill)
        {
            skillFeatureObj.DeleteSkill(driver);  
        }

        [Then(@"I am not able to see the skill in my profile '([^']*)'")]
        public void ThenIAmNotAbleToSeeTheSkillInMyProfile(string skill)
        {
            string deletedSkill = skillFeatureObj.GetDeletedSkill(driver, skill);
            Assert.That(deletedSkill!= skill, "Skill not deleted");
        }


    }
}
