using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    internal class LanguageTest
    {

        LanguagePage LP = new LanguagePage();



        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Driver.TurnOnWait();


            // Click on Language tab
            LP.ClickLanguageTab();
        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            LP.AddNewLanguage();
        }



        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                Driver.TurnOnWait();
                CommonMethods.ExtentReports();

                CommonMethods.test = CommonMethods.Extent.StartTest("Add language", "launguage");
                //Start the Reports



                string ExpectedValue = "English";

                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='English']")).Text;


                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                }
                Assert.That(ActualValue, Is.EqualTo(ExpectedValue));

            }

            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
            }



        }

        [When(@"I add new Languages (.*) and (.*)")]
        public void WhenIAddNewLanguagesAnd(string language, string level)
        {

            LP.AddNewLanguage(language, level);

        }

        [Then(@"All (.*) should be displayed as (.*) on my listings")]
        public void ThenAllShouldBeDisplayedAsOnMyListings(string Language, string Expected)
        {
            try
            {
                Driver.TurnOnWait();

                //Start the Reports
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Add language", "launguage");




                string ExpectedValue = Expected;

                string ActualValue = LP.GetText(Language);

                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                Assert.That(ActualValue, Is.EqualTo(ExpectedValue));

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
            }


        }

        [Then(@"there should be a pop up Please enter language and level (.*)")]
        public void ThenThereShouldBeAPopUpPleaseEnterLanguageAndLevel(String Expected)
        {
            try
            {
                Driver.TurnOnWait();
                //Start the Reports
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Pop up-Please enter language and level");

                //string ExpectedValue = "Please enter language and level";
                String ExpectedValue = Expected;


                //string ActualValue = Driver.driver.FindElement(By.XPath("//body/div/div[contains(text(),'Please enter language and level')]")).Text;
                //Console.WriteLine("Actual value is" + ActualValue);
                String ActualValue = LP.GetText(Expected);


                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "PopUp came Successfully");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "PopUp came Successfully");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                Assert.That(ActualValue, Is.EqualTo(ExpectedValue));

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
            }
        }



    }
}