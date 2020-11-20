//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

using System;
using Monetization_Automation.Base;
using Monetization_Automation.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Monetization_Automation.Page.Login.Map
{
    public class LoginMap : BaseMap
    {
        /// <summary>
        /// Contructor of class with ApplicationUnderTest as parameter.
        /// </summary>
        /// <param name="window"></param>
        public LoginMap(IWebDriver window)
            : base(window)
        {
        }
        internal void FindAndClickRegistrationButton()
        {
            try
            {
                var script = "var register = document.getElementsByClassName('row');var child = register[2].getElementsByClassName('col-sm-5');var fin = child[0].getElementsByClassName('btn btn-primary');fin[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Assert.Fail("register button Not Found" + e);
            }
            return;
        }
        internal void FindAndClickFullName()
        {
            try
            {
                IWebElement formElement = window.FindElement(By.Id("registerForm"));
                IWebElement fullname = formElement.FindElement(By.Name("fullName"));
                fullname.Click();
                fullname.SendKeys("amber");
            }
            catch (Exception e)
            {
                Assert.Fail("Full Name Not Found" + e);
            }
            return;
        }
       internal void FindAndClickCompanyName()
        {
            try
            {
                IWebElement formElement = window.FindElement(By.Id("registerForm"));
                IWebElement Companyname = formElement.FindElement(By.Name("company"));
                Companyname.Click();
                Companyname.SendKeys("amber");
            }
            catch (Exception e)
            {
                Assert.Fail("Company name Not Found" + e);
            }
            return;
        }
        /// <summary>
        /// Finds the user id text box
        /// </summary>
        /// <returns></returns>
        /// 
        internal void FindAndClickPhoneNumber()
        {
            try
            {
                IWebElement formElement = window.FindElement(By.Id("registerForm"));
                IWebElement Companyname = formElement.FindElement(By.Name("phoneNumber"));
                Companyname.SendKeys("03245890852");
            }
            catch (Exception e)
            {
                Assert.Fail("Company name Not Found" + e);
            }
            return;
        }
        internal SelectElement FindAndSelectPrimaryRole()
        {
            try
            {
                Thread.Sleep(3000);
                IWebElement selectElement = window.FindElement(By.Id("primaryRole"));
                SelectElement dropDown = new SelectElement(selectElement);
                Extension.HighLighterMethod(window, window.FindElement(By.Id("primaryRole")));
                dropDown.SelectByValue("Advertiser");
            }
            catch (Exception e)
            {
                Assert.Fail("PrimaryRole dropdown not found" + "" + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectCountry()
        {
            try
            {
                Thread.Sleep(3000);
                IWebElement selectElement = window.FindElement(By.Id("countries"));
                SelectElement dropDown = new SelectElement(selectElement);
                Extension.HighLighterMethod(window, window.FindElement(By.Id("countries")));
                dropDown.SelectByValue("168");
            }
            catch (Exception e)
            {
                Assert.Fail("Country dropdown not found" + "" + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectHearAboutUs()
        {
            try
            {
                Thread.Sleep(3000);
                IWebElement selectElement = window.FindElement(By.Name("hear_about_us"));
                SelectElement dropDown = new SelectElement(selectElement);
                Extension.HighLighterMethod(window, window.FindElement(By.Name("hear_about_us")));
                dropDown.SelectByValue("Email");
            }
            catch (Exception e)
            {
                Assert.Fail("Hear About Us dropdown not found" + "" + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickTermsAndCondition()
        {
            try
            {
              return window.FindElement(By.XPath("//input[@id='terms']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Terms And Condition not found" + "" + e.Message);
            }
            return null;

        }
        internal IWebElement FindAndClickRegisterSubmitBtn()
        {
            try
            {
                return window.FindElement(By.XPath("//input[@id='terms']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Terms And Condition not found" + "" + e.Message);
            }
            return null;

        }
        internal IWebElement FindAndClickConfirmPassword()
        {
            try
            {
                return window.FindElement(By.XPath("//input[@id='password2']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Confirm password not found" + "" + e.Message);
            }
            return null;

        }
        /*  internal void FindAndClickCaptcha()
          {
              try
              {
                  Thread.Sleep(3000);
                  var script = "var d = document.getElementById('rc-anchor-container');var c = document.getElementsByClassName('rc-anchor-content');var f = c[0].getElementsByClassName('rc-anchor-center-container');var g = f[0].getElementsByClassName('rc-anchor-center-item rc-anchor-checkbox-holder');g[0].click();";
                  IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                  js.ExecuteScript(script);
                  Thread.Sleep(2000);
              }
              catch (Exception e)
              {
                  Assert.Fail("Company name Not Found" + e);
              }
              return;
          }*/
        internal IWebElement FindUserID()
        {
            try
            {
                Thread.Sleep(3000);
                Extension.HighLighterMethod(window, window.FindElement(By.Name("email")));
                return window.FindElement(By.Id ("email"));
            }
            catch (Exception e)
            {
                Assert.Fail("user name control was not found" + " " + e.Message);
            }
            return null;
        }
        /// <summary>
        /// Finds the user id text box
        /// </summary>
        /// <returns></returns>
        internal IWebElement FindPasswordBox()
        {
            try
            {
                return window.FindElement(By.Id("password1"));
            }
            catch (Exception e)
            {
                Assert.Fail("Password control was not found" + " " + e.Message);
            }
            return null;
        }
        /// <summary>
        /// Finds the submitt button
        /// </summary>
        /// <returns></returns>
        /// 
        internal IWebElement FindSubmitButton()
        {
            try
            {
                
                return window.FindElement(By.Id("btnSubmit"));
                
            }
            catch (Exception e)
            {
                Assert.Fail("Submit button control was not found" + " " + e.Message);
            }
            return null;
        }
        /// <summary>
        /// Find menu hyperlink
        /// </summary>
        /// <returns></returns>
     /// <summary>
     /// Go to URL
     /// </summary>
     /// <param name="url"></param>
        internal IWebElement FindLoggedInUserName()
        {
            try 
            {
                Thread.Sleep(10000); 
              //  Extension.HighLighterMethod(window, window.FindElement(By.XPath("//span[@class='username username-hide-on-mobile']")));
                return window.FindElement(By.XPath("//span[@class='username username-hide-on-mobile']"));
            }
            catch (Exception e)
            {
                Assert.Fail("User Name not found" + e.Message);
            }
            return null;
            
        }
        internal void GetNavigation(string url)
        {
            window.Navigate().GoToUrl(url);
            window.Manage().Window.Maximize();
            Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
        }
    }
}
