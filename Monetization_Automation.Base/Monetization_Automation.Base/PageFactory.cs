//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

namespace Monetization_Automation.Base
{
    using System;
    using System.Diagnostics;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Windows;

    public class PageFactory
    {
        public static TPage Create<TPage, TMap, TValidator>(string applicationPath, bool disposeOnPlayback = false, bool isDesktopWindow = false, bool isSelenium = false, bool isBrowserIE = false)
            where TPage : BasePage<TMap, TValidator>
            where TMap : BaseMap
            where TValidator : BaseValidator<TMap>
        {
            return CreatePage<TPage, TMap, TValidator>(applicationPath, disposeOnPlayback, isDesktopWindow, isSelenium, isBrowserIE);
        }

        public static TPage Create<TPage, TMap, TValidator>(Process browserProcess, bool isDesktopWindow = false, bool isSelenium = false, bool isBrowserIE = false)
            where TPage : BasePage<TMap, TValidator>
            where TMap : BaseMap
            where TValidator : BaseValidator<TMap>
        {
            return CreatePage<TPage, TMap, TValidator>(browserProcess, isDesktopWindow, isSelenium, isBrowserIE);
        }

        private static TPage CreatePage<TPage, TMap, TValidator>(string url, bool disposeOnPlayback = false, bool isDesktopWindow = false, bool isSelenium = false, bool isBrowserIE = false)
            where TPage : BasePage<TMap, TValidator>
            where TMap : BaseMap
            where TValidator : BaseValidator<TMap>
        {
            dynamic window;
            if (isDesktopWindow == true)
            {
                AppiumOptions appCapabilities = new AppiumOptions();
                appCapabilities.AddAdditionalCapability("platformName", "Windows");
                appCapabilities.AddAdditionalCapability("app", @"C:\Windows\System32\notepad.exe");
                appCapabilities.AddAdditionalCapability("deviceName", "WindowsPC");
                appCapabilities.AddAdditionalCapability("keep-alive", "false");
                appCapabilities.AddAdditionalCapability("newCommandTimeout", 300);
                window = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:8080/wd/hub"), appCapabilities);
                DriverPropertyWindows.driverwindows = window;
            }
            else if (isSelenium == true && isBrowserIE == true)
            {
                var service = ChromeDriverService.CreateDefaultService(@"");
                var options = new ChromeOptions();
                window = new ChromeDriver(service, options, TimeSpan.FromMinutes(3));
                DriverProperty.driver = window;
            }

            else if (isSelenium == true && isBrowserIE == false)
            {
                var service = ChromeDriverService.CreateDefaultService(@"E:\Automation\Automation_Data/");
                var options = new ChromeOptions();
                window = new ChromeDriver(service, options, TimeSpan.FromMinutes(3));
                DriverProperty.driver = window;
            }

            
            else
            {
                //window = BrowserWindow.Launch(new Uri(url));
                // window.Maximized = true;
                window = null;
            }

            var map = Activator.CreateInstance(typeof(TMap), window) as TMap;
            var validator = Activator.CreateInstance<TValidator>();
            var page = Activator.CreateInstance<TPage>();
            validator.Map = map;
            page.Map = map;
            page.Validator = validator;
            return page;
        }
        public static object Create<T1, T2, T3>(object p)
        {
            throw new NotImplementedException();
        }


        private static TPage CreatePage<TPage, TMap, TValidator>(Process browserProcess, bool isDesktopWindow = false, bool isSelenium = false, bool isBrowserIE = false)
            where TPage : BasePage<TMap, TValidator>
            where TMap : BaseMap
            where TValidator : BaseValidator<TMap>
        {
            dynamic window;
            if (isDesktopWindow == true)
            {
                //window = ApplicationUnderTest.FromProcess(browserProcess);
                window = null;
            }
            else if (isSelenium == true)
            {
                window = DriverProperty.driver;
            }
            else
            {
                //window = BrowserWindow.FromProcess(browserProcess);
                //window.Maximized = true;
                window = null;
            }
            var map = Activator.CreateInstance(typeof(TMap), window) as TMap;
            var validator = Activator.CreateInstance<TValidator>();
            var page = Activator.CreateInstance<TPage>();
            validator.Map = map;
            page.Map = map;
            page.Validator = validator;
            return page;
        }
    }
}
