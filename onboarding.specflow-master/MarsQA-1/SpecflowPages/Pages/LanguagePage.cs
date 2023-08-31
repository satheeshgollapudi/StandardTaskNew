using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class LanguagePage
    {



        public LanguagePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Profile tab
        [FindsBy(How = How.XPath, Using = "//div[@class='ui eight item menu']/a[contains(text(),'Profile')]")]
        private IWebElement Profiletab { get; set; }

        //Click Language tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Languages')]")]
        private IWebElement ClickLanguagetab { get; set; }


        //Finding the AddNewButton 
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Add New')]")]
        private IWebElement AddNewButton { get; set; }


        //Finding the AddLanguage 
        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        private IWebElement AddLanguage { get; set; }


        //Finding the LanguageLevel 
        [FindsBy(How = How.XPath, Using = "//select/option[contains(text(),'Basic')]")]
        private IWebElement LanguageLevel { get; set; }

        //Finding the AddButton 
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddButton { get; set; }






        #endregion

        public void ClickLanguageTab()

        {

            

            //Click on Profile tab
            Profiletab.Click();

            //Click on Language tab
            ClickLanguagetab.Click();

        }

        public void AddNewLanguage()
        {
            //Click on Add New button
            AddNewButton.Click();

            //Add Language
            AddLanguage.SendKeys("English");

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElement(By.XPath("//select/option[contains(text(),'Basic')]"));
            Lang.Click();


            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }

        public void AddNewLanguage(String Language, String Level)
        {
            //Click on Add New button
            AddNewButton.Click();

            //Add Language
            AddLanguage.SendKeys(Language);

            //Choose the language level
            IWebElement LanguageLevel = Driver.driver.FindElement(By.XPath("//select/option[contains(text(),'" + Level + "')]"));
            LanguageLevel.Click();


            //Click on Add button
            AddButton.Click();
        }

        public String GetText(String elementText)
        {
            String ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='" + elementText + "']")).Text;

            return ActualValue;

        }

    }
}
