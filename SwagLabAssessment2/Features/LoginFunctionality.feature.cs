﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SwagLabAssessment2.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Login Functionality")]
    public partial class LoginFunctionalityFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "LoginFunctionality.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Login Functionality", "A short summary of the feature", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
 #line hidden
#line 5
  testRunner.Given("go to the \"https://www.saucedemo.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login functionality for the correct data")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("locked_out_user", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("problem_user", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("performance_glitch_user", "secret_sauce", "swaglabs", null)]
        public void LoginFunctionalityForTheCorrectData(string username, string password, string system, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("system", system);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login functionality for the correct data", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
 this.FeatureBackground();
#line hidden
#line 9
   testRunner.And(string.Format("enter your username \"{0}\"", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
   testRunner.And(string.Format("enter the password \"{0}\"", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
   testRunner.Then("click the \"loginBtn\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
   testRunner.Then("verify the step \"loggedIn\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login functionality with the wrong data")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "123", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("faruk", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("standard_user", "", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("locked_out_user", "123", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("standard", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("locked_out_user", "", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("problem_user", "123", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("standard", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("problem_user", "", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("performance_glitch_user", "123", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("standard", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("", "secret_sauce", "swaglabs", null)]
        [NUnit.Framework.TestCaseAttribute("performance_glitch_user", "", "swaglabs", null)]
        public void LoginFunctionalityWithTheWrongData(string username, string password, string system, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("system", system);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login functionality with the wrong data", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
 this.FeatureBackground();
#line hidden
#line 25
   testRunner.And(string.Format("enter your username \"{0}\"", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
   testRunner.And(string.Format("enter the password \"{0}\"", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
   testRunner.Then("click the \"loginBtn\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
   testRunner.Then(string.Format("verify that the user is not able to log in the \"{0}\"", system), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion