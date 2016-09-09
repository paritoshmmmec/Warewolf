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
namespace Dev2.Activities.Specs.TestFramework
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class StudioTestFrameworkFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StudioTestFramework.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "StudioTestFramework", "\tIn order to test workflows in warewolf \r\n\tAs a user\r\n\tI want to create, edit, de" +
                    "lete and update tests in a test window", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "StudioTestFramework")))
            {
                Dev2.Activities.Specs.TestFramework.StudioTestFrameworkFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        public virtual void FeatureBackground()
        {
#line 7
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Var Name"});
            table1.AddRow(new string[] {
                        "[[a]]"});
#line 8
   testRunner.Given("I have \"Workflow 1\" with inputs as", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ouput Var Name"});
            table2.AddRow(new string[] {
                        "[[outputValue]]"});
#line 11
   testRunner.And("\"Workflow 1\" has outputs as", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Var Name"});
            table3.AddRow(new string[] {
                        "[[rec().a]]"});
            table3.AddRow(new string[] {
                        "[[rec().b]]"});
#line 14
   testRunner.Given("I have \"Workflow 2\" with inputs as", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ouput Var Name"});
            table4.AddRow(new string[] {
                        "[[returnVal]]"});
#line 18
   testRunner.And("\"Workflow 2\" has outputs as", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Var Name"});
            table5.AddRow(new string[] {
                        "[[A]]"});
            table5.AddRow(new string[] {
                        "[[B]]"});
            table5.AddRow(new string[] {
                        "[[C]]"});
#line 21
    testRunner.Given("I have \"Workflow 3\" with inputs as", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ouput Var Name"});
            table6.AddRow(new string[] {
                        "[[message]]"});
#line 26
   testRunner.And("\"Workflow 3\" has outputs as", ((string)(null)), table6, "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create New Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFramework")]
        public virtual void CreateNewTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create New Test", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 31
 testRunner.Given("the test builder is open with \"Workflow 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.And("Tab Header is \"Workflow 1 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.When("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("a new test is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.And("test name starts with \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("username is blank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("password is blank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table7.AddRow(new string[] {
                        "a",
                        ""});
#line 40
 testRunner.And("inputs are", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table8.AddRow(new string[] {
                        "outputValue",
                        ""});
#line 43
 testRunner.And("outputs as", ((string)(null)), table8, "And ");
#line 46
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("test status is pending", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("test is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create New Test with Service that as recordset inputs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFramework")]
        public virtual void CreateNewTestWithServiceThatAsRecordsetInputs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create New Test with Service that as recordset inputs", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 51
 testRunner.Given("the test builder is open with \"Workflow 2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.And("Tab Header is \"Workflow 2 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.When("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("a new test is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.And("test name starts with \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("username is blank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("password is blank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table9.AddRow(new string[] {
                        "rec(1).a",
                        ""});
            table9.AddRow(new string[] {
                        "rec(1).b",
                        ""});
#line 60
 testRunner.And("inputs are", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table10.AddRow(new string[] {
                        "rec(1).a",
                        "val1"});
            table10.AddRow(new string[] {
                        "rec(1).b",
                        ""});
#line 64
 testRunner.When("I updated the inputs as", ((string)(null)), table10, "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table11.AddRow(new string[] {
                        "rec(1).a",
                        "val1"});
            table11.AddRow(new string[] {
                        "rec(1).b",
                        ""});
            table11.AddRow(new string[] {
                        "rec(2).a",
                        ""});
            table11.AddRow(new string[] {
                        "rec(2).b",
                        ""});
#line 68
 testRunner.Then("inputs are", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Save a New Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFramework")]
        public virtual void SaveANewTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save a New Test", ((string[])(null)));
#line 75
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 76
 testRunner.Given("the test builder is open with \"Workflow 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
 testRunner.And("Tab Header is \"Workflow 1 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("a new test is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.And("test name starts with \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table12.AddRow(new string[] {
                        "a",
                        ""});
#line 83
 testRunner.And("inputs are", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table13.AddRow(new string[] {
                        "outputValue",
                        ""});
#line 86
 testRunner.And("outputs as", ((string)(null)), table13, "And ");
#line 89
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.Then("Tab Header is \"Workflow 1 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.And("I close the test builder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.When("the test builder is open with \"Workflow 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 testRunner.Then("there are 1 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.And("\"Dummy Test\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("I select \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("\"Test 1\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("test name starts with \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table14.AddRow(new string[] {
                        "a",
                        ""});
#line 99
 testRunner.And("inputs are", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table15.AddRow(new string[] {
                        "outputValue",
                        ""});
#line 102
 testRunner.And("outputs as", ((string)(null)), table15, "And ");
#line 105
 testRunner.And("save is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit existing test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFramework")]
        public virtual void EditExistingTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit existing test", ((string[])(null)));
#line 109
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 110
 testRunner.Given("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 111
 testRunner.And("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error"});
            table16.AddRow(new string[] {
                        "Test1",
                        "Windows",
                        "true"});
#line 114
 testRunner.And("I set Test Values as", ((string)(null)), table16, "And ");
#line 117
 testRunner.Then("NoErrorExpected is \"false\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
 testRunner.When("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error"});
            table17.AddRow(new string[] {
                        "Test2",
                        "Windows",
                        "true"});
#line 122
 testRunner.And("I set Test Values as", ((string)(null)), table17, "And ");
#line 125
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
 testRunner.And("I close the test builder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.When("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 130
 testRunner.Then("there are 2 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.And("I select \"Test2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error"});
            table18.AddRow(new string[] {
                        "Test2",
                        "Public",
                        "true"});
#line 132
 testRunner.And("I set Test Values as", ((string)(null)), table18, "And ");
#line 135
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.And("I close the test builder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.When("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
 testRunner.Then("there are 2 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.And("I select \"Test2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.And("Test name is \"Test2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
 testRunner.And("Authentication is Public", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Rename existing test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFramework")]
        public virtual void RenameExistingTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Rename existing test", ((string[])(null)));
#line 144
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 145
 testRunner.Given("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 146
 testRunner.And("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error"});
            table19.AddRow(new string[] {
                        "Test1",
                        "Windows",
                        "true"});
#line 149
 testRunner.And("I set Test Values as", ((string)(null)), table19, "And ");
#line 152
 testRunner.Then("NoErrorExpected is \"false\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 153
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 155
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 156
 testRunner.When("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error"});
            table20.AddRow(new string[] {
                        "Test2",
                        "Windows",
                        "true"});
#line 157
 testRunner.And("I set Test Values as", ((string)(null)), table20, "And ");
#line 160
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 162
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 163
 testRunner.And("I close the test builder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.When("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 165
 testRunner.Then("there are 2 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 166
 testRunner.And("I select \"Test2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 167
 testRunner.When("I change the test name to \"testing2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 168
 testRunner.Then("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 169
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 170
 testRunner.Then("test URL is \"http://localhost:3142/secure/Examples/Workflow 1.tests/testing2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 171
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 172
 testRunner.And("I close the test builder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
 testRunner.When("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 174
 testRunner.Then("there are 2 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.And("I select \"testing2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.And("Test name is \"testing2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Loading exisiting Tests has correct Name for display")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFramework")]
        public virtual void LoadingExisitingTestsHasCorrectNameForDisplay()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Loading exisiting Tests has correct Name for display", ((string[])(null)));
#line 178
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 179
 testRunner.Given("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 180
 testRunner.And("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error"});
            table21.AddRow(new string[] {
                        "Test1",
                        "Windows",
                        "true"});
#line 183
 testRunner.And("I set Test Values as", ((string)(null)), table21, "And ");
#line 186
 testRunner.Then("NoErrorExpected is \"false\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 187
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 188
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 189
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 190
 testRunner.And("I close the test builder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 191
 testRunner.When("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 192
 testRunner.Then("there are 1 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 193
 testRunner.And("I select \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 194
 testRunner.And("Name for display is \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Loading exisiting Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFramework")]
        public virtual void LoadingExisitingTests()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Loading exisiting Tests", ((string[])(null)));
#line 196
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 197
 testRunner.Given("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 198
 testRunner.And("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error"});
            table22.AddRow(new string[] {
                        "Test1",
                        "Windows",
                        "true"});
#line 201
 testRunner.And("I set Test Values as", ((string)(null)), table22, "And ");
#line 204
 testRunner.Then("NoErrorExpected is \"false\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 205
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 206
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 207
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 208
 testRunner.When("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error"});
            table23.AddRow(new string[] {
                        "Test2",
                        "Windows",
                        "true"});
#line 209
 testRunner.And("I set Test Values as", ((string)(null)), table23, "And ");
#line 212
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 213
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 214
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 215
 testRunner.And("I close the test builder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 216
 testRunner.When("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 217
 testRunner.Then("there are 2 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete an Enabled Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFramework")]
        public virtual void DeleteAnEnabledTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete an Enabled Test", ((string[])(null)));
#line 220
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 221
 testRunner.Given("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 222
 testRunner.And("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 223
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 224
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error"});
            table24.AddRow(new string[] {
                        "Test1",
                        "Windows",
                        "true"});
#line 225
 testRunner.And("I set Test Values as", ((string)(null)), table24, "And ");
#line 228
 testRunner.Then("NoErrorExpected is \"false\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 229
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 230
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 231
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 232
 testRunner.And("there are 1 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 233
 testRunner.When("I disable \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 234
 testRunner.Then("Delete is disabled for \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 235
 testRunner.When("I enable \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 236
 testRunner.Then("Delete is enabled for \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 237
 testRunner.When("I delete \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 238
 testRunner.When("The Confirmation popup is shown I click Ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 239
 testRunner.Then("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 240
 testRunner.And("I close the test builder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 241
 testRunner.When("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 242
 testRunner.Then("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Duplicate a test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFramework")]
        public virtual void DuplicateATest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Duplicate a test", ((string[])(null)));
#line 244
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 245
 testRunner.Given("the test builder is open with \"Workflow 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 246
 testRunner.And("Tab Header is \"Workflow 1 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 247
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 248
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 249
 testRunner.Then("a new test is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 250
 testRunner.And("Tab Header is \"Workflow 1 - Tests *\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 251
 testRunner.And("test name starts with \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table25.AddRow(new string[] {
                        "a",
                        ""});
#line 252
 testRunner.And("inputs are", ((string)(null)), table25, "And ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table26.AddRow(new string[] {
                        "outputValue",
                        ""});
#line 255
 testRunner.And("outputs as", ((string)(null)), table26, "And ");
#line 258
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 259
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 260
 testRunner.Then("Tab Header is \"Workflow 1 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 261
 testRunner.And("there are 1 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 262
 testRunner.When("I right click \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 263
 testRunner.Then("Duplicate Test is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 264
 testRunner.When("I click duplicate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 265
 testRunner.Then("there are 2 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 266
 testRunner.And("the duplicated tests is \"Test 1_dup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 267
 testRunner.When("I right click \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 268
 testRunner.Then("Duplicate Test in not Visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
