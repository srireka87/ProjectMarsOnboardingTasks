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
namespace UserStory2OnBoardingTasks.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SkillsFeature")]
    public partial class SkillsFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "SkillsFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "SkillsFeature", "As a ProjectMars User \r\nI want to Add,Update and Delete profile Skills details\r\nS" +
                    "o that I can show people seeking what skills I hold ", ProgrammingLanguage.CSharp, featureTags);
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AddNew Skill with Valid Credentials")]
        [NUnit.Framework.CategoryAttribute("AddingNewSkills")]
        [NUnit.Framework.TestCaseAttribute("Cooking", "Expert", null)]
        [NUnit.Framework.TestCaseAttribute("Documentation & Writing", "Beginner", null)]
        [NUnit.Framework.TestCaseAttribute("Graphics3287@$@", "Intermediate", null)]
        [NUnit.Framework.TestCaseAttribute("Painting is my ##passion$$ and trying 2 improve it@@", "Beginner", null)]
        public void AddNewSkillWithValidCredentials(string addSkill, string skillLevel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AddingNewSkills"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Add Skill", addSkill);
            argumentsOfScenario.Add("Skill Level", skillLevel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AddNew Skill with Valid Credentials", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
 testRunner.Given("I logged in to ProjectMars successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
 testRunner.And("I navigate to Profile Skills Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.When(string.Format("I \'{0}\'and \'{1}\'", addSkill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then(string.Format("The\'{0}\'and \'{1}\' details should be created successfully", addSkill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Updating Skill with Valid credentials in Profile")]
        [NUnit.Framework.CategoryAttribute("UpdateSkills")]
        [NUnit.Framework.TestCaseAttribute("Crafting", "Expert", "Music& Audio", "Beginner", null)]
        [NUnit.Framework.TestCaseAttribute("@#423SFssfUpdating", "Beginner", "Fun Life Style and Organiser", "Expert", null)]
        [NUnit.Framework.TestCaseAttribute("Pottery & mosaic", "Intermediate", "Sewing@@##FashionDesingning", "Intermediate", null)]
        public void UpdatingSkillWithValidCredentialsInProfile(string updateSkill, string updateLevel, string newSkill, string newSkillLevel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UpdateSkills"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Update Skill", updateSkill);
            argumentsOfScenario.Add("Update Level", updateLevel);
            argumentsOfScenario.Add("NewSkill", newSkill);
            argumentsOfScenario.Add("NewSkill Level", newSkillLevel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Updating Skill with Valid credentials in Profile", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 25
 testRunner.Given("I logged in to ProjectMars successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.And("I navigate to Profile Skills Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And(string.Format("I Add \'{0}\' and \'{1}\'", newSkill, newSkillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.When(string.Format("Updating \'{0}\' and \'{1}\'", updateSkill, updateLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then(string.Format("skills should be updated in \'{0}\'and \'{1}\' successfully", updateSkill, updateLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Adding & Updating  the ExistingSkill")]
        [NUnit.Framework.CategoryAttribute("Adding/UpdatingexistingSkills")]
        [NUnit.Framework.TestCaseAttribute("Reading", "Expert", null)]
        [NUnit.Framework.TestCaseAttribute("Cooking", "Intermediate", null)]
        [NUnit.Framework.TestCaseAttribute("@#@#@$^&^*#$#Gardening@#@#@", "Beginner", null)]
        public void AddingUpdatingTheExistingSkill(string skill, string skillLevel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Adding/UpdatingexistingSkills"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Skill", skill);
            argumentsOfScenario.Add("Skill Level", skillLevel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding & Updating  the ExistingSkill", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 40
 testRunner.Given("I logged in to ProjectMars successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 41
 testRunner.And("I navigate to Profile Skills Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And(string.Format("I Add \'{0}\' and \'{1}\'", skill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.When(string.Format("I Adding /Updating existing \'{0}\' and \'{1}\' on existing records", skill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("Popup message display as \'This skill is already added to your skill list.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deleting the Skill and Skill Level")]
        [NUnit.Framework.CategoryAttribute("DeletingSkills")]
        [NUnit.Framework.TestCaseAttribute("Poetry", "Expert", null)]
        [NUnit.Framework.TestCaseAttribute("Writing documentary", "Beginner", null)]
        public void DeletingTheSkillAndSkillLevel(string skill, string skillLevel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "DeletingSkills"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Skill", skill);
            argumentsOfScenario.Add("Skill Level", skillLevel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deleting the Skill and Skill Level", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 53
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 54
testRunner.Given("I logged in to ProjectMars successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 55
testRunner.And("I navigate to Profile Skills Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
testRunner.And(string.Format("I Add \'{0}\' and \'{1}\'", skill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
testRunner.When(string.Format("I Delete for the \'{0}\'", skill), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
testRunner.Then(string.Format("the record should be deleted and message display as \'{0} has been deleted\'", skill), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cancel the Skill when AddNew and Update")]
        [NUnit.Framework.CategoryAttribute("CancelSkill")]
        [NUnit.Framework.TestCaseAttribute("Gardening", "Beginner", null)]
        [NUnit.Framework.TestCaseAttribute("Art & Design", "Basic", null)]
        public void CancelTheSkillWhenAddNewAndUpdate(string skill, string skillLevel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "CancelSkill"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Skill", skill);
            argumentsOfScenario.Add("Skill Level", skillLevel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancel the Skill when AddNew and Update", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 66
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 67
 testRunner.Given("I logged in to ProjectMars successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 68
 testRunner.And("I navigate to Profile Skills Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And(string.Format("I adding \'{0}\' and \'{1}\'", skill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.Then("Click Cancel Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.Then(string.Format("the\'{0}\'and \'{1}\' details should be cancelled.", skill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AddNew Skill with INVALID Credentials")]
        [NUnit.Framework.CategoryAttribute("EnteringOnlySkillORSkillLevel")]
        [NUnit.Framework.TestCaseAttribute("Hadwriting", "Expert", null)]
        [NUnit.Framework.TestCaseAttribute("", "Intermediate", null)]
        [NUnit.Framework.TestCaseAttribute("Animation", "", null)]
        public void AddNewSkillWithINVALIDCredentials(string skill, string level, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "EnteringOnlySkillORSkillLevel"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Skill", skill);
            argumentsOfScenario.Add("Level", level);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AddNew Skill with INVALID Credentials", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 78
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 79
 testRunner.Given("I logged in to ProjectMars successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 80
 testRunner.And("I navigate to Profile Skills Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.When(string.Format("I enter only \'{0}\' OR \'<Skill Level>\'", skill), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.Then("notification show as \'Please enter skill and experience level\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
