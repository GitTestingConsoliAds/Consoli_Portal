//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

using Monetization_Automation.Base;
using Monetization_Automation.Page.Login.Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Monetization_Automation.Utils;

namespace Monetization_Automation.Page.Login.Validator
{
    public class LoginValidator : BaseValidator<LoginMap>
    {
        /// <summary>
        /// Validate user is logged in.
        /// </summary>
        /// <param name="text"></param>
        public void AssertLogin(string text)
        {
            bool isTrue = text.Equals(ExcelUtil.ReadData(1, "validateLogin"));
            if (!isTrue)
            {
                Assert.Fail("User was not able to login");
            }
        }

    }
}
