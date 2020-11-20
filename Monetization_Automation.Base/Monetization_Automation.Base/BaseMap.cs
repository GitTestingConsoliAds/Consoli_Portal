//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

namespace Monetization_Automation.Base
{
    using System.Diagnostics;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.Windows;

    /// <summary>
    /// Developed a BaseMap class which holds the reference of ApplicationUnderTest.
    /// The controls are found in the context of container that can be used in the 
    /// concerete classes that implement BaseMap
    /// </summary>
    public abstract class BaseMap
    {
        /// <summary>
        /// ReadOnly object of ApplicationUnderTest. 
        /// </summary>

        protected readonly IWebDriver window;
        protected readonly WindowsDriver<WindowsElement> winDriverWindow;

        /// <summary>
        /// ReadOnly object of ApplicationUnderTest. 
        /// </summary>
       // protected readonly ApplicationUnderTest desktopWindow;

        /// <summary>
        /// Application Process which will hold instance of Process of initialized application.
        /// </summary>
        internal Process ApplicationProcess { get; private set; }
        internal IWebDriver ApplicationDriver { get; private set; }
        internal WindowsDriver<WindowsElement> desktopWindow { get; private set; }

        /// <summary>
        /// Constructor of baseMap Class which Set ApplicationUnderTest object and 
        /// Process of Application which is under test.
        /// </summary>
        /// <param name="window"></param>
        protected BaseMap(IWebDriver window)
        {
            this.window = window;
            ApplicationDriver = DriverProperty.driver;
        }

        protected BaseMap(WindowsDriver<WindowsElement> window)
        {
            this.winDriverWindow = window;
            winDriverWindow = DriverPropertyWindows.driverwindows;
        }

        /// <summary>
        /// Constructor of baseMap Class which set ApplicationUnderTest object and 
        /// Process of Application which is under test.
        /// </summary>
        /// <param name="window"></param>
        //protected BaseMap(ApplicationUnderTest window)
        //{
        //    this.desktopWindow = window;
        //    ApplicationProcess = this.desktopWindow.Process;
        //}
    }
}
