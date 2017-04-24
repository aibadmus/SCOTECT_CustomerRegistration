﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitTestProject1.Features.Sprint_3
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UserStory462")]
    public partial class UserStory462Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "US462_BusinessDetails.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UserStory462", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Page is displayed")]
        public virtual void PageIsDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Page is displayed", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
testRunner.When("I am on the Business details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
testRunner.Then("I can see the progress indicator control", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 7
testRunner.And("I can see the Save And continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
testRunner.And("I can see the Business name field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
testRunner.And("I can see the Companies House registration number field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.And("I can see the SME radio button option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
testRunner.And("I can see the Large enterprise radio button option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.And("I can see the Yes radio button to the De minimis question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.And("I can see the No radio button to the De minimis question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Help is displayed")]
        public virtual void HelpIsDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Help is displayed", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 17
testRunner.When("I am on the Business details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
testRunner.Then("the help text is displayed under the Company name question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
testRunner.Then("the help text is displayed under the Company registration number question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
testRunner.Then("I see the Companies House Website Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
testRunner.Then("the help text is displayed under the SME question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
testRunner.Then("the help text is displayed under the De minimis question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Answering no to the de minimis question")]
        public virtual void AnsweringNoToTheDeMinimisQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Answering no to the de minimis question", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 26
testRunner.When("I am on the Business details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
testRunner.When("I select NO on the de minimis question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
testRunner.Then("a check box appears with the following label: I confirm that I haven\'t received a" +
                    "ny de minimis aid in my last 3 financial years.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Answering yes to the de minimis question")]
        public virtual void AnsweringYesToTheDeMinimisQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Answering yes to the de minimis question", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 32
testRunner.When("I am on the Business details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
testRunner.And("I have answered YES to the de minimis question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
testRunner.Then("I see Type of de minimis table drop down option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
testRunner.Then("I see Financial Year table drop down option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
testRunner.Then("I see Amount text field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Adding additional rows to the de minimis table")]
        public virtual void AddingAdditionalRowsToTheDeMinimisTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding additional rows to the de minimis table", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 40
testRunner.When("I am on the Business details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
testRunner.And("I have answered YES to the de minimis question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
testRunner.When("I click on the button Add more rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
testRunner.Then("an additional data entry row is added to the bottom of the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
