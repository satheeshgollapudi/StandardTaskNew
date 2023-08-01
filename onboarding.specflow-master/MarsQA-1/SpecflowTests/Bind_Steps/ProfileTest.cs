using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using RazorEngine;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    internal class ProfileTest
    {

        ProfilePage PP = new ProfilePage();


        [Given(@"I click on edit for Availability")]
        public void GivenIClickOnEditForAvailability()
        {
            //Click on Edit button
            PP.AvailabilityTimeEdit.Click();
        }

        [When(@"select (.*)")]
        public void WhenSelectAvailabilitytype(string availabilitytype)
        {
            PP.SelectAvailability(availabilitytype);
        }


        [Then(@"that (.*) should be displayed")]
        public void ThenThatFullTimeShouldBeDisplayed(string availabilitytype)
        {
            try
            {
                Driver.TurnOnWait();

                //Start the Reports
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Edit Availability", "Availability");


               // profile.EditProfile();

                string ExpectedValue = availabilitytype;

                //profile.AvailabilityTimeEdit.Click();
                string ActualValue = PP.GetText(availabilitytype);




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

        [Given(@"I click on edit for AvailabilityHours")]
        public void GivenIClickOnEditForAvailabilityHours()
        {
            //Availability Hours Edit
            PP.AvailabilityHoursEdit.Click();
        }

        [When(@"selectAvailabilityHours (.*)")]
        public void WhenSelectAvailabilityHours(string AvailabilityHours)
        {
            PP.SelectAvailabilityHours(AvailabilityHours);
        }

        [Then(@"(.*)should display with updated hours")]
        public void ThenShouldDisplayWithUpdatedHours(string AvailabilityHours)
        { 
        
             try
             {
                 Driver.TurnOnWait();

                 //Start the Reports
                 CommonMethods.ExtentReports();
                 CommonMethods.test = CommonMethods.Extent.StartTest("Edit AvailabilityHours", "AvailabilityHours");


                 // profile.EditProfile();

                 string ExpectedValue = AvailabilityHours;

                 //profile.AvailabilityTimeEdit.Click();
                 string ActualValue = PP.GetTextHour(AvailabilityHours);




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

        [Given(@"I click on edit for EarnTarget")]
        public void GivenIClickOnEditForEarnTarget()
        {
            // EarnTarget Edit
            PP.EditEarnTarget();
        }

        [When(@"selectEarnTarget (.*)")]
        public void WhenSelectEarnTarget(string EarnTarget)
        {
            PP.SelectEarnTarget(EarnTarget);
        }

        [Then(@"(.*)should display with updated EarnTarget")]
        public void ShouldDisplayWithUpdatedEarnTarget(string EarnTarget)
        {

            try
            {
                Driver.TurnOnWait();

                //Start the Reports
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Edit EarnTarget", "EarnTarget");


                // profile.EditProfile();

                string ExpectedValue = EarnTarget;

                //profile.AvailabilityTimeEdit.Click();
                string ActualValue = PP.GetTextHour(EarnTarget);




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

    }


    }




