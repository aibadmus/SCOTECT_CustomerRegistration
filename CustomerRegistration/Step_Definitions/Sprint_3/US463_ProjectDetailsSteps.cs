﻿using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProject1.HomeObjects;
using UnitTestProject1.BusinessDetailsPage;
using UnitTestProject1.CommonElementPageFactory;
using UnitTestProject1.AzureLoginPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow.Assist;
using UnitTestProject1.ProjectDetailsPage;
using static UnitTestProject1.Step_Definitions.Sprint_3.US462_BusinessDetailsSteps;

namespace UnitTestProject1.Step_Definitions.Sprint_3
{

    public class US463_ProjectDetailsSteps 
    {
        IWebDriver driver;

        [Given(@"I am on the Project details page")]
        public void GivenIAmOnTheProjectDetailsPage()
        {
            driver = new ChromeDriver(@"C:\Users\aibad\Test\chromedriver");
            driver.Navigate().GoToUrl("http://qa1grantweb.azurewebsites.net/grants/home");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(100));


            var grantsHomePageFactory = new GrantsHomePageFactory(driver);
            grantsHomePageFactory.ClickStartNewApplicationBtn();
            driver.Navigate().GoToUrl("https://login.microsoftonline.com/QA1ScotEnt.onmicrosoft.com/oauth2/v2.0/authorize?client_id=0bf4fad2-c576-47e1-a689-4796d560fdb1&response_type=code+id_token&redirect_uri=https://qa1grantweb.azurewebsites.net/auth/signin&response_mode=form_post&scope=openid%20offline_access&p=B2C_1_scotent-signin_signup&state=%2Cgrants%2Cbusinessdetails");


            var scotentAzureLoginPage = new ScotentAzureLoginPage(driver);
            scotentAzureLoginPage.AzureLogIn();

            System.Threading.Thread.Sleep(5000);
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            System.Threading.Thread.Sleep(5000);
            businessDetailsPageFactory.EnterBusinessName();
            System.Threading.Thread.Sleep(5000);
            businessDetailsPageFactory.EnterCompanyHouseRegNumber();
            businessDetailsPageFactory.SelectSMERadioBtn();
            businessDetailsPageFactory.SelectDeMinimisNoRadioBtn();
            businessDetailsPageFactory.SelectConfirmNotReceivedDeMinimis();
            //driver.FindElement(By.Id("saveApplicationCont")).Click();
            var commonElement = new CommonElement(driver);
            commonElement.ClickSaveAndContinue();
            System.Threading.Thread.Sleep(5000);

        }

        [Given(@"I have uploaded a file")]
        public void GivenIHaveUploadedAFile()
        {
            ScenarioContext.Current.Pending();
        }

        /*
           [When(@"I am on the Project details page")]
           public void WhenIAmOnTheProjectDetailsPage()
           {
               driver = new ChromeDriver(@"C:\Users\aibad\Test\chromedriver");
               driver.Navigate().GoToUrl("http://qa1grantweb.azurewebsites.net/grants/home");
               driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(100));


               var grantsHomePageFactory = new GrantsHomePageFactory(driver);
               grantsHomePageFactory.ClickStartNewApplicationBtn();
               driver.Navigate().GoToUrl("https://login.microsoftonline.com/QA1ScotEnt.onmicrosoft.com/oauth2/v2.0/authorize?client_id=0bf4fad2-c576-47e1-a689-4796d560fdb1&response_type=code+id_token&redirect_uri=https://qa1grantweb.azurewebsites.net/auth/signin&response_mode=form_post&scope=openid%20offline_access&p=B2C_1_scotent-signin_signup&state=%2Cgrants%2Cbusinessdetails");


               var scotentAzureLoginPage = new ScotentAzureLoginPage(driver);
               scotentAzureLoginPage.AzureLogIn();

               System.Threading.Thread.Sleep(5000);
               var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
               System.Threading.Thread.Sleep(5000);
               businessDetailsPageFactory.EnterBusinessName();
               System.Threading.Thread.Sleep(5000);
               businessDetailsPageFactory.EnterCompanyHouseRegNumber();
               businessDetailsPageFactory.SelectSMERadioBtn();
               businessDetailsPageFactory.SelectDeMinimisNoRadioBtn();
               businessDetailsPageFactory.SelectConfirmNotReceivedDeMinimis();
               var commonElement = new CommonElement(driver);
               commonElement.ClickSaveAndContinue();
               System.Threading.Thread.Sleep(5000);
               */


        [When(@"I upload a file")]
        public void WhenIUploadAFile()
        {
            /*
                      var commonElement = new CommonElement(driver);
                      commonElement.ClickLoadFile
                      */
            /*
            System.Threading.Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.Id("quotesFile"));
            System.Threading.Thread.Sleep(5000);
            element.SendKeys("C:\\Users\aibad\\Desktop\\Capture.png");
            */
            //driver.FindElement(By.Id("quotesFile")).Click();
            string filePath = @"drive:C:\Users\aibad\Desktop\Capture.png";
            driver.FindElement(By.Id("quotesFile")).SendKeys(filePath);
        }



        [When(@"I click on Remove file")]
        public void WhenIClickOnRemoveFile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the Save And go back button")]
        public void WhenIClickOnTheSaveAndGoBackButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can see the Save And go back button")]
        public void ThenICanSeeTheSaveAndGoBackButton()
        {
            var commonElement = new CommonElement(driver);
            commonElement.VerifySaveAndGoBackBtn();
        }
        
        [Then(@"I can see the Project title text box")]
        public void ThenICanSeeTheProjectTitleTextBox()
        {
            var projectDetailsPageFactory = new ProjectDetailsPageFactory(driver);
            projectDetailsPageFactory.verifyProjectTitleTxtField();
        }
        
        [Then(@"I can see the Project description text box")]
        public void ThenICanSeeTheProjectDescriptionTextBox()
        {
            var projectDetailsPageFactory = new ProjectDetailsPageFactory(driver);
            projectDetailsPageFactory.verifyProjectDescriptionTxtField();
        }
        
        [Then(@"I can see an option to upload supporting documents")]
        public void ThenICanSeeAnOptionToUploadSupportingDocuments()
        {
            var commonElement = new CommonElement(driver);
            commonElement.VerifyChooseFileBtn();
        }
        
        [Then(@"I can see the Project start date field")]
        public void ThenICanSeeTheProjectStartDateField()
        {
            var projectDetailsPageFactory = new ProjectDetailsPageFactory(driver);
            projectDetailsPageFactory.verifyStartDateField();
        }
        
        [Then(@"the help text '(.*)' is displayed under the Project title question")]
        public void ThenTheHelpTextIsDisplayedUnderTheProjectTitleQuestion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the help text '(.*)' is displayed under the Project description question")]
        public void ThenTheHelpTextIsDisplayedUnderTheProjectDescriptionQuestion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the help text '(.*)' is displayed under the document upload question")]
        public void ThenTheHelpTextIsDisplayedUnderTheDocumentUploadQuestion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the help text '(.*)'d like to start the project\. Please note that the project can'(.*)'ve approved your application\.' is displayed under the Project start date question")]
        public void ThenTheHelpTextDLikeToStartTheProject_PleaseNoteThatTheProjectCanVeApprovedYourApplication_IsDisplayedUnderTheProjectStartDateQuestion(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the help text '(.*)' is displayed under the Project duration question")]
        public void ThenTheHelpTextIsDisplayedUnderTheProjectDurationQuestion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a dialogue appears asking me to confirm the file removal")]
        public void ThenADialogueAppearsAskingMeToConfirmTheFileRemoval()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can click OK to remove the file")]
        public void ThenICanClickOKToRemoveTheFile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the file name of the file I have removes no longer appears on the page")]
        public void ThenTheFileNameOfTheFileIHaveRemovesNoLongerAppearsOnThePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Project outputs page is displayed")]
        public void ThenTheProjectOutputsPageIsDisplayed()
        {
            System.Threading.Thread.Sleep(5000);
            Assert.IsTrue(driver.Title.Equals("Project outputs - Grants"));
        }
        
        [Then(@"the Business details page is displayed")]
        public void ThenTheBusinessDetailsPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"the Project Details page is displayed as the current step on the progess indicator")]
        public void ThenTheProjectDetailsPageIsDisplayedAsTheCurrentStepOnTheProgessIndicator()
        {
            System.Threading.Thread.Sleep(5000);
            Assert.IsTrue(driver.Title.Equals("Project details - Grants"));


        }
        [Then(@"I can see the Project duration section")]
        public void ThenICanSeeTheProjectDurationSection()
        {
            ScenarioContext.Current.Pending();
        }
 
        }

    }

