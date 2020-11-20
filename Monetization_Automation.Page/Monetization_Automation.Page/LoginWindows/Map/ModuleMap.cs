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
using OpenQA.Selenium.Appium.Windows;
using System.Collections.Generic;

namespace Monetization_Automation.Page.LoginWindows.Map
{ 
    public class ModuleMap : BaseMap
    {
        /// <summary>
        /// Contructor of class with ApplicationUnderTest as parameter.
        /// </summary>
        /// <param name="window"></param>
        public ModuleMap(WindowsDriver<WindowsElement> window)
            : base(window)
        {
        }


        internal WindowsElement FindClickFileButton()
        {
            try
            {
                Thread.Sleep(3000);
                var element = winDriverWindow.FindElementByName("File");
                return winDriverWindow.FindElementByName("File");
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

    }
}
