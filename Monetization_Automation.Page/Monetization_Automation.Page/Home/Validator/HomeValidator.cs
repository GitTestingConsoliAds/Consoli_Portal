//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

using Monetization_Automation.Base;
using Monetization_Automation.Page.Home.Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Monetization_Automation.Utils;
using System.Globalization;
using System.Diagnostics;

namespace Monetization_Automation.Page.Home.Validator
{
    public class HomeValidator : BaseValidator<HomeMap>
    {
        /// <summary>
        /// Validate order products page.
        /// </summary>
        /// <param name="value"></param>

        public void AssertBrand(string text)
        {
            //   bool isTrue = text.Equals(AppManageTableValues.BrandTitle);
            //  if (!isTrue)
            // {
            //   Assert.Fail("Brand not found");

            //            }
            Extension.comparisonValidation(AppManageTableValues.SecondCompareValue, AppManageTableValues.FirstCompareValue, text);
        }
        public void AssertApp(string text)
        {
            /* bool isTrue = text.Equals(ExcelUtil.ReadData(1, "validateApp"));
             if (!isTrue)
             {
                 Assert.Fail("App not found");
             }*/
            Extension.comparisonValidation(AppManageTableValues.SecondCompareValue, AppManageTableValues.FirstCompareValue, text);
        }
        public void AssertCampaign(string text)
        {
            Extension.comparisonValidation(AppManageTableValues.SecondCompareValue, AppManageTableValues.FirstCompareValue, text);
          /*  bool isTrue = text.Equals(ExcelUtil.ReadData(1, "validateCampaign"));
            if (!isTrue)
            {
                Assert.Fail("Campaign not found");
            }*/
        }
    }
}

