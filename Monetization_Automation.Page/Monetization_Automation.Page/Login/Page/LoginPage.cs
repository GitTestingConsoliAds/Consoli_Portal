//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

using Monetization_Automation.Base;
using Monetization_Automation.Page.Login.Map;
using Monetization_Automation.Page.Login.Validator;
using Monetization_Automation.Utils;
using Microsoft.VisualStudio.TestTools.UITesting;
using OpenQA.Selenium;
using System.Threading;
using Selenium.Utils.Extensions;

namespace Monetization_Automation.Page.Login.Page
{
    public class LoginPage : BasePage<LoginMap,LoginValidator>
    {
        public static LoginPage sdriver = null;
        public LoginPage()
        {
        }
        /// <summary>
        /// Enter user id in text box
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        ///  
       public LoginPage ClickRegisterButton()
        {
            Thread.Sleep(1000);
            Map.FindAndClickRegistrationButton();
            return this;
        }
       public LoginPage ClickFullNameForRegisteration()
        {
            Thread.Sleep(1000);
            Map.FindAndClickFullName();
            return this;
        }
        public LoginPage ClickCompanyName()
        {
            Thread.Sleep(1000);
            Map.FindAndClickCompanyName();
            return this;
        }
        public LoginPage ClickPhoneNumberField()
        {
            Thread.Sleep(1000);
            Map.FindAndClickPhoneNumber();
            return this;
        }
        public LoginPage SelectPrimaryRole()
        {
            Thread.Sleep(1000);
            Map.FindAndSelectPrimaryRole();
            return this;
        }
        public LoginPage SelectCountry()
        {
            Thread.Sleep(1000);
            Map.FindAndSelectCountry();
            return this;
        }
        public LoginPage SelectHearAboutUs()
        {
            Thread.Sleep(1000);
            Map.FindAndSelectHearAboutUs();
            return this;
        }
        public LoginPage SelectTermsAndConditionRadioBtn()
        {
            Thread.Sleep(1000);
            Map.FindAndClickTermsAndCondition().Click();
            return this;
        }
        public LoginPage SelectRegisterSubmitbtn()
        {
            Thread.Sleep(1000);
            Map.FindAndClickRegisterSubmitBtn().Click();
            return this;
        }
        public LoginPage ClickConfirmPassword()
        {
            Thread.Sleep(1000);
            Map.FindAndClickConfirmPassword().SendKeys(ExcelUtil.ReadData(1, "Password"));
            return this;
        }
        /*   public LoginPage ClickCaptcha()
           {
               Thread.Sleep(1000);
               Map.FindAndClickCaptcha();
               return this;
           }*/
        public LoginPage EnterUserId()
        {
            Thread.Sleep(2000);
            
            Map.FindUserID().SendKeys(Keys.Space);
            Map.FindUserID().SendKeys(ExcelUtil.ReadData(1, "UserName"));
            return this;
        }
        /// <summary>
        /// Enter password
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public LoginPage EnterPassword()
        {
            Thread.Sleep(2000);
            Map.FindPasswordBox().SendKeys(ExcelUtil.ReadData(1, "Password"));
            return this;
        }
        /// <summary>
        /// Click submit button Control
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public LoginPage ClickSubmitButton()
        {
            Thread.Sleep(2000);
            Map.FindSubmitButton().Click();
            Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);Thread.Sleep(1000);
            Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            return this;
        }

       public LoginPage ValidateLoggedInUserName()
        {
            Thread.Sleep(2000);
            var textvalue = Map.FindLoggedInUserName().Text;
            Validator.AssertLogin(textvalue);
            return this;
        }


        public LoginPage NavigateUrl(string url)
        {
            Map.GetNavigation(url);
            return this;
        }
        public LoginPage Driver(LoginPage driver)
        {
            sdriver = driver;
            return this;
        }
    }
}
