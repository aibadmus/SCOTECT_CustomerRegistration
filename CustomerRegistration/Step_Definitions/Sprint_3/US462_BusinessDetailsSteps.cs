﻿using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProject1.AzureLoginPage;
using UnitTestProject1.CommonElementPageFactory;
using UnitTestProject1.BrowserSettings;
using UnitTestProject1.HomeObjects;
using UnitTestProject1.BusinessDetailsPage;
using UnitTestProject1.CommonElementPageFactory;


namespace UnitTestProject1.Step_Definitions.Sprint_3
{
    [Binding]
    public class US462_BusinessDetailsSteps
    {
        IWebDriver driver;


        [Given(@"I am on the Business details page")]
        public void  GivenIAmOnTheBusinessDetailsPage()
        {

            driver = new ChromeDriver(@"C:\Users\Badmus\Test\chromedriver");
            driver.Navigate().GoToUrl("http://qa1grantweb.azurewebsites.net/grants/home");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));
          //  driver.FindElement(By.Id("start-application")).Click();
            //driver.Navigate().GoToUrl("https://login.microsoftonline.com/QA1ScotEnt.onmicrosoft.com/oauth2/v2.0/authorize?client_id=0bf4fad2-c576-47e1-a689-4796d560fdb1&response_type=code+id_token&redirect_uri=https://qa1grantweb.azurewebsites.net/auth/signin&response_mode=form_post&scope=openid%20offline_access&p=B2C_1_scotent-signin_signup&state=%2Cgrants%2Cbusinessdetails");
            
            //var browserConfig = new BrowserConfig(driver);
              // browserConfig.OpenGrantsChromeBrowser();

            var grantsHomePageFactory = new GrantsHomePageFactory(driver);
                grantsHomePageFactory.ClickStartNewApplicationBtn();
            driver.Navigate().GoToUrl("https://login.microsoftonline.com/QA1ScotEnt.onmicrosoft.com/oauth2/v2.0/authorize?client_id=0bf4fad2-c576-47e1-a689-4796d560fdb1&response_type=code+id_token&redirect_uri=https://qa1grantweb.azurewebsites.net/auth/signin&response_mode=form_post&scope=openid%20offline_access&p=B2C_1_scotent-signin_signup&state=%2Cgrants%2Cbusinessdetails");


            var scotentAzureLoginPage = new ScotentAzureLoginPage(driver);
            scotentAzureLoginPage.AzureLogIn();
            
        }

        [Given(@"I have answered '(.*)' to the de minimis question")]
        public void GivenIHaveAnsweredToTheDeMinimisQuestion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have clicked on the button Add more rows")]
        public void GivenIHaveClickedOnTheButtonAddMoreRows()
        {
            ScenarioContext.Current.Pending();
       
        }
        
        [When(@"I am on the Business details page")]
        public void WhenIAmOnTheBusinessDetailsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select '(.*)' on the de minimis question")]
        public void WhenISelectOnTheDeMinimisQuestion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the button Add more rows")]
        public void WhenIClickOnTheButtonAddMoreRows()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the button Delete row")]
        public void WhenIClickOnTheButtonDeleteRow()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the link '(.*)'")]
        public void WhenIClickOnTheLink(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the Save And continue button")]
        public void WhenIClickOnTheSaveAndContinueButton()
        {
            var commonElement = new CommonElement(driver);
            commonElement.ClickSaveAndContinue();
        }

        [Then(@"I can see the Save And continue button")]
        public void ThenICanSeeTheSaveAndContinueButton()
        {
            ScenarioContext.Current.Pending();

        }

        [Then(@"I can see the Companies House registration number field")]
        public void ThenICanSeeTheCompaniesHouseRegistrationNumberField()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can see the de minimis question")]
        public void ThenICanSeeTheDeMinimisQuestion()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the help text '(.*)' is displayed under the Company name question")]
        public void ThenTheHelpTextIsDisplayedUnderTheCompanyNameQuestion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the help text '(.*)' is displayed under the Company registration number question")]
        public void ThenTheHelpTextIsDisplayedUnderTheCompanyRegistrationNumberQuestion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the help text '(.*)'re an SME if you have fewer than (.*) employees with an annual turnover of less than EURO (.*)m And are independent\. You'(.*)' is displayed under the SME question")]
        public void ThenTheHelpTextReAnSMEIfYouHaveFewerThanEmployeesWithAnAnnualTurnoverOfLessThanEUROMAndAreIndependent_YouIsDisplayedUnderTheSMEQuestion(string p0, int p1, int p2, string p3)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the help text '(.*)'re notified in writing if awarded this type of aid\. You need to tell us about de minimis aid as there'(.*)' is displayed under the de minimis question")]
        public void ThenTheHelpTextReNotifiedInWritingIfAwardedThisTypeOfAid_YouNeedToTellUsAboutDeMinimisAidAsThereIsDisplayedUnderTheDeMinimisQuestion(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a check box appears with the following label: I confirm that I haven't received any de minimis aid in my last (.*) financial years\.")]
        public void ThenACheckBoxAppearsWithTheFollowingLabelIConfirmThatIHavenTReceivedAnyDeMinimisAidInMyLastFinancialYears_(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see Type of de minimis table drop down option")]
        public void ThenISeeTypeOfDeMinimisTableDropDownOption()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see Financial Year table drop down option")]
        public void ThenISeeFinancialYearTableDropDownOption()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see Amount text field")]
        public void ThenISeeAmountTextField()
        {
            ScenarioContext.Current.Pending();

        }

        [Then(@"an additional data entry row is added to the bottom of the table")]
        public void ThenAnAdditionalDataEntryRowIsAddedToTheBottomOfTheTable()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the row I am on is removed from the table")]
        public void ThenTheRowIAmOnIsRemovedFromTheTable()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a new window opens")]
        public void ThenANewWindowOpens()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following page is displayed in the new window: https://beta\.companieshouse\.gov\.uk/")]
        public void ThenTheFollowingPageIsDisplayedInTheNewWindowHttpsBeta_Companieshouse_Gov_Uk()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following page is displayed in the new window: http://ec\.europa\.eu/budget/contracts_grants/info_contracts/inforeuro/index_en\.cfm")]
        public void ThenTheFollowingPageIsDisplayedInTheNewWindowHttpEc_Europa_EuBudgetContracts_GrantsInfo_ContractsInforeuroIndex_En_Cfm()
        {
            ScenarioContext.Current.Pending();
        }

        
        [Then(@"the Project details page is displayed")]
        public void ThenTheProjectDetailsPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"I can see the Business name field")]
        public void ThenICanSeeTheBusinessNameField()
        {
            ScenarioContext.Current.Pending();
        }
        [Given(@"I can see the Save And continue button")]
        public void GivenICanSeeTheSaveAndContinueButton()
        {
            var commonElement = new CommonElement(driver);
            commonElement.VerifySaveAndContinueBtn();
        }

        [Given(@"I can see the Business name field")]
        public void GivenICanSeeTheBusinessNameField()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.VerifyCompanyNameField();
        }
        [Given(@"I can see the Companies House registration number field")]
        public void GivenICanSeeTheCompaniesHouseRegistrationNumberField()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.VerifycompanyRegNoField();

        }
            [Given(@"I can see the SME radio button option")]
        public void GivenICanSeeTheSMERadioButtonOption()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifySMERadioBtn();

        }
        [Given(@"I can see the Large enterprise radio button option")]
        public void GivenICanSeeTheLargeEnterpriseRadioButtonOption()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyEnterpriseRadioBtn();
            /*
            if (IsElementPresent(By.Id("companyTypeEnterprise")))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            */
        }
        [Given(@"I can see the Yes radio button to the De minimis question")]
        public void GivenICanSeeTheYesRadioButtonToTheDeMinimisQuestion()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyDeMinimisYesRadioBtn();
            /*
            if (IsElementPresent(By.Id("minimisSupportYes")))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            */
        }

        [Given(@"I can see the No radio button to the De minimis question")]
        public void GivenICanSeeTheNoRadioButtonToTheDeMinimisQuestion()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyDeMinimisNoRadioBtn();
            /*

            if (IsElementPresent(By.Id("minimisSupportNo")))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            */
        }




        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            
            {
                return false;
            }
        }

    }
}