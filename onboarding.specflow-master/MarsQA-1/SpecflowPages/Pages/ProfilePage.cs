using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using RelevantCodes.ExtentReports;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class ProfilePage
    {

        public ProfilePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Availability Time Edit button
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),' Time')]//i[@class='right floated outline small write icon']")]
        public IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyType']")]
        private IWebElement AvailabilityType { get; set; }

        //AvailabilityHoursEdit
        //Click on Availability Edit button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i[1]")]
        public IWebElement AvailabilityHoursEdit { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Clickon  Availability Remove icon
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyType']/following-sibling::i")]
        private IWebElement AvailabilityRemoveIcon { get; set; }

        //Clickon  Availability Hours Remove icon
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']/following-sibling::i ")]
        private IWebElement AvailabilityHoursRemoveIcon { get; set; }

        //Clickon  Availability Target Remove icon
        [FindsBy(How = How.XPath, Using = "/select[@name='availabiltyTarget']/following-sibling::i ")]
        private IWebElement TargetRemoveIcon { get; set; }


        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[3]/div")]
        private IWebElement AvailabilityHours { get; set; }

        //Click on EarnTarget
        [FindsBy(How = How.XPath, Using = "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[4]/div[1]/span[1]/i[1]")]
        private IWebElement SalaryEdit { get; set; }

        //Select EarnTarget
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']/option[3]")]
        public IWebElement EarnTarget { get; set; }


        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

        #endregion 


        internal void EditAvailability()
        {


            //Global.GlobalDefinitions.wait(60000);
            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");


            //Click on Edit button
            AvailabilityTimeEdit.Click();
        }
        internal void SelectAvailability(String availabilitytype)
        {


            // Actions action = new Actions(GlobalDefinitions.driver);
            // action.MoveToElement(AvailabilityTime).Build().Perform();
            Thread.Sleep(1000);
            //IList<IWebElement> AvailableTime = AvailabilityTimeOpt.FindElements(By.TagName("div"));
            //IList<IWebElement> AvailableTime = Driver.driver.FindElements(By.XPath("//select[@name='availabiltyType']/option"));
            IList<IWebElement> AvailableTime = AvailabilityType.FindElements(By.TagName("option"));
            int count = AvailableTime.Count;
            for (int i = 0; i < count; i++)
            {
                //if (AvailableTime[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"))
                if (AvailableTime[i].Text == availabilitytype)
                {
                    AvailableTime[i].Click();
                    //Base.test.Log(LogStatus.Info, "Select the available time");
                    //Console.WriteLine(AvailableTime[i].Text);
                    //Console.WriteLine(count);
                    //AvailabilityRemoveIcon.Click();
                    break;



                }
            }
        }

        internal void EditAvailabilityHours()
        {


            //Click on Edit button
            AvailabilityHoursEdit.Click();
        }


        internal void SelectAvailabilityHours(String AvailabilityHours)
        {


            // Actions action = new Actions(GlobalDefinitions.driver);
            // action.MoveToElement(AvailabilityTime).Build().Perform();
            Thread.Sleep(1000);
            //IList<IWebElement> AvailableTime = AvailabilityTimeOpt.FindElements(By.TagName("div"));
            IList<IWebElement> AvailableHours = Driver.driver.FindElements(By.XPath("//select[@name='availabiltyHour']/option"));
            int count = AvailableHours.Count;
            for (int i = 0; i < count; i++)
            {
                //if (AvailableTime[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"))
                if (AvailableHours[i].Text == AvailabilityHours)
                {
                    AvailableHours[i].Click();
                    //Base.test.Log(LogStatus.Info, "Select the available time");
                    //Console.WriteLine(AvailableTime[i].Text);
                    //Console.WriteLine(count);
                   // AvailabilityHoursRemoveIcon.Click();
                    break;

                }
            }
        }

        internal void EditEarnTarget()
        {

            //Click on Edit button
            SalaryEdit.Click();
        }

        internal void SelectEarnTarget(String EarnTarget)
        {


            // Actions action = new Actions(GlobalDefinitions.driver);
            // action.MoveToElement(AvailabilityTime).Build().Perform();
            Thread.Sleep(1000);
            //IList<IWebElement> AvailableTime = AvailabilityTimeOpt.FindElements(By.TagName("div"));
            IList<IWebElement> AvailableTarget = Driver.driver.FindElements(By.XPath("//select[@name='availabiltyHour']/option"));
            int count = AvailableTarget.Count;
            for (int i = 0; i < count; i++)
            {
                //if (AvailableTime[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"))
                if (AvailableTarget[i].Text == EarnTarget)
                {
                    AvailableTarget[i].Click();
                    //Base.test.Log(LogStatus.Info, "Select the available time");
                    //Console.WriteLine(AvailableTime[i].Text);
                    //Console.WriteLine(count);
                    //AvailabilityHoursRemoveIcon.Click();
                    break;



                }
            }
        }

        public string GetText(String elementText)
        {
            String ActualValue = Driver.driver.FindElement(By.XPath("//select[@name='availabiltyType']/option[text()='" + elementText + "']")).Text;

            return ActualValue;

        }

        public string GetTextHour(String elementText)
        {
            String ActualValue = Driver.driver.FindElement(By.XPath("//select[@name='availabiltyHour']/option[text()='" + elementText + "']")).Text;

            return ActualValue;

        }
    }
}