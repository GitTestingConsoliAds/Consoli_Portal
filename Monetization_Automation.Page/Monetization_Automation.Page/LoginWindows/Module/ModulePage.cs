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
using Monetization_Automation.Page.LoginWindows.Module;
using Monetization_Automation.Page.LoginWindows.Map;
using Monetization_Automation.Page.LoginWindows.Validator;

namespace Monetization_Automation.Page.LoginWindows.Module
{
    public class ModulePage : BasePage<ModuleMap,ModuleValidator>
    {
        public ModulePage()
        {         
        }

        public ModulePage(ModuleMap Map, ModuleValidator Validator)
        {
            this.Map = Map;
            this.Validator = Validator;
        }

        public void ClickFileButton()
        {
            Map.FindClickFileButton().Click();
        }
        /// <summary>
        /// Enter user id in text box
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
    }
}
