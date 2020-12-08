//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

using System;
using Monetization_Automation.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Interactions;
using Monetization_Automation.Utils;
using Selenium.Utils.Html;
using System.Runtime.InteropServices;
using System.Linq;
using Selenium.Utils.Extensions;
using System.Windows;
using System.Web.UI.WebControls.WebParts;

namespace Monetization_Automation.Page.Home.Map
{
    public class HomeMap : BaseMap
    {
        Actions actions = new Actions(DriverProperty.driver);
        /// <summary>
        /// Contructor of class with ApplicationUnderTest as parameter.
        /// </summary>
        /// <param name="window"></param>
        public HomeMap(IWebDriver window)
            : base(window)
        {
        }
        /// <summary>
        /// Finds our products hyperlink.
        /// </summary>
        /// <returns></returns>
        /// 
        
        public static string[] DatabaseTable = new string[6];
        //BRAND CREATION:
        internal void FindAndClickBrand()
        {
            try
            {
                var script = "jQuery(\"span:contains('Brands')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Brand button not found" + " " + e.Message);
            }
            return;
        }
        internal IWebElement FindAndClickBrandBtn()
        {
            try
            {
                return window.FindElement(By.XPath("//a[@class='btn green-meadow btn-md pull-right']"));
            }
            catch (Exception e)
            {
                Assert.Fail("New Brand button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAmazonASINORAppleID()
        {
            try
            {
                return window.FindElement(By.XPath("//input[@id='appleID']"));
            }
            catch (Exception e)
            {
                Assert.Fail("AmazonASINORAppleID field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAppCreateButton()
        {
            try
            {
                var script = "var div = document.getElementsByClassName('btn btn-primary btn-sm'); div[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
            }
            catch (Exception e)
            {
                Assert.Fail("AmazonASINORAppleID field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindBrandNameField()
        {
            try
            {
                return window.FindElement(By.Id("brandName"));
            }
            catch (Exception e)
            {
                Assert.Fail("Brand Name feild not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindBrandDetailsField()
        {

            try
            {
                return window.FindElement(By.Id("brandDetails"));
            }
            catch (Exception e)
            {
                Assert.Fail("Brand Details feild not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindSupportemailField()
        {

            try
            {
                return window.FindElement(By.Id("supportURL"));
            }
            catch (Exception e)
            {
                Assert.Fail("Support email feild not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindGoogleMoreAppURLField()
        {

            try
            {
                return window.FindElement(By.Name("gpMoreAppsURL"));
            }
            catch (Exception e)
            {
                Assert.Fail("URL feild not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAmazonMoreAppsURLField()
        {

            try
            {
                return window.FindElement(By.Name("amMoreAppsURL"));
            }
            catch (Exception e)
            {
                Assert.Fail("URL feild not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAppStoreMoreAppsURL()
        {

            try
            {
                return window.FindElement(By.Name("asMoreAppsURL"));
            }
            catch (Exception e)
            {
                Assert.Fail("Brand Details feild not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickSaveBtn()
        {
            try
            {
                return window.FindElement(By.Id("btnSubmitBrand"));
            }
            catch (Exception e)
            {
                Assert.Fail("Save Button not found" + " " + e.Message);
            }
            return null;

        }

        /* internal IWebElement FindAndClickEditbrand()
            {
                try
                {
                    return window.FindElement(By.Name("Edit"));
                }
                catch (Exception e)
                {
                    Assert.Fail("Edit link not found" + " " + e.Message);
                }
                return null;
            }*/

        //APP CREATION:
        internal void FindAndClickNewApp()
        {
            try
            {

                var script = "jQuery(\"span:contains('New App')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("New App button not found" + " " + e.Message);
            }
            return;
        }
        /* internal IWebElement FindImportField()
         {
             try
             {
                 return window.FindElement(By.Id("marketURL"));
             }
             catch (Exception e)
             {
                 Assert.Fail("Import field not found");
             }
             return null;
         }*/
        internal void FindAndClickCreateManuallyButton()
        {
            try
            {
                var script = "var div = document.getElementById('closeAppNewModal'); div.click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Import button not found" + " " + e.Message);
            }
            return;
        }
        internal IWebElement FindAndClickAppTitle()
        {
            try
            {
                return window.FindElement(By.Id("appTitle"));
            }
            catch (Exception e)
            {
                Assert.Fail("App title field not found" + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickPackageName()
        {
            try
            {
                return window.FindElement(By.Name("package"));
            }
            catch (Exception e)
            {
                Assert.Fail("App package field not found" + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickReportMediationSearchField()
        {
            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); 
                return window.FindElement(By.XPath("//input[@class='form-control input-sm input-small input-inline'][@type='search']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Search field not found" + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAdnetwork()
        {
            try
            {
                var script = "var div = document.getElementById('networks-table'); var child=div.getElementsByTagName('a'); child[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Adnetwork not found" + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectPlatform(string platform)
        {
            try
            {
                Thread.Sleep(3000);
                if (platform.Equals("Google Play"))
                {
                    IWebElement selectElement = window.FindElement(By.Name("os"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("41");
                }
                if (platform.Equals("Apple"))
                {
                    IWebElement selectElement = window.FindElement(By.Name("os"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("42");
                }
                if (platform.Equals("Amazon"))
                {
                    IWebElement selectElement = window.FindElement(By.Name("os"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("43");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Platform dropdown not found" + "" + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectAppType(string Apptype)
        {
            try
            {
                Thread.Sleep(3000);
                if (Apptype.Equals ("Game"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_types"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("game");
                }
                if (Apptype.Equals("App"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_types"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("app");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("App type dropdown not found" + "" + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectAppCategory(string Categories)
        {
            try
            {
                Thread.Sleep(3000);
                if (Categories.Equals("Action"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Action");
                }
                if (Categories.Equals("Adventure"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Adventure");
                }
                if (Categories.Equals("Arcade"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Arcade");
                }
                if (Categories.Equals("Board"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Board");
                }
                if (Categories.Equals("Card"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Card");
                }
                if (Categories.Equals("Casino"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Casino");
                }
                if (Categories.Equals("Casual"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Casual");
                }
                if (Categories.Equals("Educational"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Educational");
                }
                if (Categories.Equals("Family"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Family");
                }
                if (Categories.Equals("Music"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Music");
                }
                if (Categories.Equals("Puzzle"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Puzzle");
                }
                if (Categories.Equals("Racing"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Racing");
                }
                if (Categories.Equals("Role Playing"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Role Playing");
                }
                if (Categories.Equals("Simulation"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Simulation");
                }
                if (Categories.Equals("Sports"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Sports");
                }
                if (Categories.Equals("Strategy"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Strategy");
                }

                if (Categories.Equals("Trivia"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Trivia");
                }

                if (Categories.Equals("Word"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Word");
                }

                if (Categories.Equals("AR Games"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("AR Games");
                }

                if (Categories.Equals("Cards"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Cards");
                }

                if (Categories.Equals("Music and Rhythm"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Music and Rhythm");
                }

                if (Categories.Equals("Brain and Puzzle"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Brain and Puzzle");
                }

                if (Categories.Equals("Sports Games"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Sports Games");
                }
                if (Categories.Equals("Art & Design"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Action");
                }
                if (Categories.Equals("Art & Design"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Action");
                }
                if (Categories.Equals("Auto & Vehicles"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Auto & Vehicles");
                }
                if (Categories.Equals("Beauty"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Beauty");
                }
                if (Categories.Equals("Books & Reference"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Books & Reference");
                }
                if (Categories.Equals("Business"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Business");
                }
                if (Categories.Equals("Comics"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Comics");
                }
                if (Categories.Equals("Communication"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Communication");
                }
                if (Categories.Equals("Dating"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Dating");
                }
                if (Categories.Equals("Education"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Education");
                }
                if (Categories.Equals("Entertainment"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Entertainment");
                }
                if (Categories.Equals("Events"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Events");
                }
                if (Categories.Equals("Finance"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Finance");
                }
                if (Categories.Equals("Food & Drink"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Food & Drink");
                }
                if (Categories.Equals("Health & Fitness"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Health & Fitness");
                }
                if (Categories.Equals("House & Home"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("House & Home");
                }
                if (Categories.Equals("Libraries & Demo"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Libraries & Demo");
                }
                if (Categories.Equals("Lifestyle"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Lifestyle");
                }
                if (Categories.Equals("Maps & Navigation"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Maps & Navigation");
                }
                if (Categories.Equals("Medical"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Medical");
                }
                if (Categories.Equals("Music & Audio"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Music & Audio");
                }
                if (Categories.Equals("News & Magazines"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("News & Magazines");
                }
                if (Categories.Equals("Medical"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Medical");
                }
                if (Categories.Equals("Parenting"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Parenting");
                }
                if (Categories.Equals("Personalization"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Personalization");
                }
                if (Categories.Equals("Photography"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Photography");
                }
                if (Categories.Equals("Productivity"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Productivity");
                }
                if (Categories.Equals("Shopping"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Shopping");
                }
                if (Categories.Equals("Social"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Social");
                }
                if (Categories.Equals("Tools"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Tools");
                }
                if (Categories.Equals("Travel & Local"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Travel & Local");
                }
                if (Categories.Equals("Video Players & Editors"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Video Players & Editors");
                }
                if (Categories.Equals("Weather"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Weather");
                }
                if (Categories.Equals("Medical"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Medical");
                }
                if (Categories.Equals("Books"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Books");
                }
                if (Categories.Equals("Food and Drink"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Food and Drink");
                }
                if (Categories.Equals("Health and Fitness"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Health and Fitness");
                }
                if (Categories.Equals("Kids"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Kids");
                }
                if (Categories.Equals("Magazines and Newspapers"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Magazines and Newspapers");
                }
                if (Categories.Equals("Navigation"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Navigation");
                }
                if (Categories.Equals("News"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("News");
                }
                if (Categories.Equals("Photo and Video"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Photo and Video");
                }
                if (Categories.Equals("Reference"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Reference");
                }
                if (Categories.Equals("Social Networkin"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Social Networkin");
                }
                if (Categories.Equals("Catalogs"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Catalogs");
                }
                if (Categories.Equals("Utilities"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Utilities");
                }
                if (Categories.Equals("Books & Comics"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Books & Comics");
                }
                if (Categories.Equals("Business & Finance"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Business & Finance");
                }
                if (Categories.Equals("City Info"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    Extension.HighLighterMethod(window, window.FindElement(By.Id("app_categoryID")));
                    dropDown.SelectByText("City Info");
                }
                if (Categories.Equals("Cooking"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Cooking");
                }
                if (Categories.Equals("Games"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Games");
                }
                if (Categories.Equals("Motives"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Motives");
                }
                if (Categories.Equals("Novelty"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Novelty");
                }
                if (Categories.Equals("Podcasts"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Podcasts");
                }
                if (Categories.Equals("Real Estate"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Real Estate");
                }
                if (Categories.Equals("Ringtones"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Ringtones");
                }
                if (Categories.Equals("Web Browsers"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Web Browsers");
                }
                if (Categories.Equals("Book"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Book");
                }
                if (Categories.Equals("Photo & Video"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Photo & Video");
                }
                if (Categories.Equals("Brain & Puzzle"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("app_categoryID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByText("Brain & Puzzle");
                }

            }
            catch (Exception e)
            {
                Assert.Fail("App category dropdown not found" + "" + e.Message);
            }
            return null;
        }

        internal void FindAndSelectEnvironment(string environment)
        {
            try
            {
                Thread.Sleep(3000);
                if (environment.Equals("Unity"))
                {
                    var script = "var maindiv=document.getElementsByClassName('col-sm-9'); var  children = maindiv[3]; var finalElements=maindiv[3].getElementsByClassName('mt-radio col-sm-6'); finalElements[0].click();";
                    IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                    js.ExecuteScript(script);
                    Thread.Sleep(1000);
                }
                if (environment.Equals("Native"))
                {
                    var script = "var maindiv=document.getElementsByClassName('col-sm-9'); var  children = maindiv[3]; var finalElements=maindiv[3].getElementsByClassName('mt-radio col-sm-6'); finalElements[1].click();";
                    IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                    js.ExecuteScript(script);
                    Thread.Sleep(1000);
                }

            }
            catch (Exception e)
            {
                Assert.Fail("Environment radio button not found" + "" + e.Message);
            }
            return;
        }
        internal SelectElement FindAndSelectBrand(string brand)
        {
            try
            {
                Thread.Sleep(3000);
                IWebElement selectElement = window.FindElement(By.Name("brand"));
                SelectElement dropDown = new SelectElement(selectElement);
                dropDown.SelectByText(brand);
            }
            catch (Exception e)
            {
                Assert.Fail("Brand dropdown not found" + "" + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectAgeRating(string AgeRating)
        {
            try
            {
                Thread.Sleep(3000); Thread.Sleep(3000); Thread.Sleep(3000); Thread.Sleep(3000);
                if (AgeRating.Equals("EVERYONE")) 
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("1");
                }
                if (AgeRating.Equals("EVERYONE 10+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("2");
                }
                if (AgeRating.Equals("TEEN"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("3");
                }
                if (AgeRating.Equals("MATURE"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("4");
                }
                if (AgeRating.Equals("ADULTS ONLY"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("5");
                }
                if (AgeRating.Equals("PEGI 3"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("6");
                }
                if (AgeRating.Equals("PEGI 7"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("7");
                }
                if (AgeRating.Equals("PEGI 12"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("8");
                }
                if (AgeRating.Equals("PEGI 16"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("9");
                }
                if (AgeRating.Equals("PEGI 18"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("10");
                }
                if (AgeRating.Equals("PARENTAL GUIDANCE RECOMMENDED"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("11");
                }
                if (AgeRating.Equals("USK: Ages 6 and above"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("12");
                }
                if (AgeRating.Equals("USK: Ages 12 and above"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("13");
                }
                if (AgeRating.Equals("USK: Ages 16 and above"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("14");
                }
                if (AgeRating.Equals("USK: Ages 18 and above"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("15");
                }
                if (AgeRating.Equals("General"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("16");
                }
                if (AgeRating.Equals("Parental Guidance"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    dropDown.SelectByValue("17");
                }
                if (AgeRating.Equals("Restricted"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                 //   Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("18");
                }
                if (AgeRating.Equals("All ages"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("19");
                }
                if (AgeRating.Equals("Rated 10+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("20");
                }
                if (AgeRating.Equals("Rated 12+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                 //   Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("21");
                }
                if (AgeRating.Equals("Rated 14+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("22");
                }
                if (AgeRating.Equals("Rated 16+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                 //   Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("23");
                }
                if (AgeRating.Equals("Rated 18+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                 //   Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("24");
                }
                if (AgeRating.Equals("Rated for 3+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("25");
                }
                if (AgeRating.Equals("Rated for 7+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("26");
                }
                if (AgeRating.Equals("Rated for 12+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("27");
                }
                if (AgeRating.Equals("Rated for 16+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("28");
                }
                if (AgeRating.Equals("Rated for 18+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("29");
                }
                if (AgeRating.Equals("Rated 3+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("30");
                }
                if (AgeRating.Equals("Rated 7+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("31");
                }
                if (AgeRating.Equals("Rated 12+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("32");
                }
                if (AgeRating.Equals("Rated 17+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                 //   Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("33");
                }
                if (AgeRating.Equals("Rated 18+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("34");
                }
                if (AgeRating.Equals("Unrated"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("35");
                }
                if (AgeRating.Equals("Rated for 1+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("36");
                }
                if (AgeRating.Equals("Rated for 2+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                 //   Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("37");
                }
                if (AgeRating.Equals ("Rated for 4+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("38");
                }
                if (AgeRating.Equals("Rated for 5+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("39");
                }
                if (AgeRating.Equals("Rated for 8+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("40");
                }
                if (AgeRating.Equals("Rated for 9+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("41");
                }
                if (AgeRating.Equals("Rated for 11+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("42");
                }
                if (AgeRating.Equals("Rated for 13+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                 //   Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("43");
                }
                if (AgeRating.Equals("Rated for 4+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("44");
                }
                if (AgeRating.Equals("Rated for 9+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("45");
                }
                if (AgeRating.Equals("Rated for 12+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("46");
                }
                if (AgeRating.Equals("Rated for 17+"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("47");
                }
                if (AgeRating.Equals("All Ages"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                 //   Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("48");
                }
                if (AgeRating.Equals("Guidance Suggested"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("49");
                }
                if (AgeRating.Equals("Mature"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                 //   Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("50");
                }
                if (AgeRating.Equals("Dynamic Content"))
                {
                    Thread.Sleep(3000);
                    IWebElement selectElement = window.FindElement(By.Name("sel_ageRatingID"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Name("sel_ageRatingID")));
                    dropDown.SelectByValue("51");
                }

            }
            catch (Exception e)
            {
                Assert.Fail("AgeRating field not found" + "" + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAppSaveBtn()
        {
            try
            {
                return window.FindElement(By.Id("submitButton"));
            }
            catch (Exception e)
            {
                Assert.Fail("Save Button not found" + " " + e.Message);
            }
            return null;
        }
        //CROSS PROMO CAMPAIGN CREATION
        internal void FindAndClickPromote()
        {
            try
            {

                var script = "var div = document.getElementsByClassName('nav-link form-control btn btn-success header-button active-moneize-promote');div[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("App Management icon not found" + " " + e.Message);
            }
            return;
        }
        internal void FindAndClickNewCampaigns()
        {
            try
            {

                var script = "jQuery(\"span:contains('New Campaign')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("New Campaign button not found" + " " + e.Message);
            }
            return;
        }
        internal IWebElement FindAndSelectCampaignType()
        {
            try
            {
                Thread.Sleep(3000);
                
                
                    var script = "var maindiv=document.getElementsByClassName('mt-radio-inline'); var child = maindiv[2]; var final = document.getElementById('cross'); final.click();";
                    IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                    js.ExecuteScript(script);
                    Thread.Sleep(1000);
                
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Type radio button not found" + e.Message);
            }
            return null;
        }
        internal void FindAndSelectNotIntegratedCampaign()
        {
            try
            {
                var script = "jQuery(\"label:contains('No')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign yes,no radio button not found" + e.Message);
            }
            return;
        }
        internal IWebElement FindAndClickCampaignTitleField()
        {
            try
            {
                return window.FindElement(By.Id("title"));
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Title field not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectAdType(string Campaign_Adtype)
        {
            try
            {
                Thread.Sleep(3000);
                if (Campaign_Adtype.Equals("Interstitial"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adType"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("adType")));
                    dropDown.SelectByValue("Interstitial");
                }
                if (Campaign_Adtype.Equals("Video"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adType"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("adType")));
                    dropDown.SelectByValue("Video");
                }
                if (Campaign_Adtype.Equals("Rewarded Video"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adType"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("adType")));
                    dropDown.SelectByValue("Rewarded Video");
                }
                if (Campaign_Adtype.Equals("Native"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adType"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("adType")));
                    dropDown.SelectByValue("Native");
                }
                if (Campaign_Adtype.Equals("Banner"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adType"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("adType")));
                    dropDown.SelectByValue("Banner");
                }
                if (Campaign_Adtype.Equals("Icon"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adType"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("adType")));
                    dropDown.SelectByValue("Icon");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("AdType dropdown not found" + "" + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndClickCampaignBrandField(String Campaign_brand)
        {
            try
            {
                if (Campaign_brand.Equals("Buntoo Games"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adv_brand"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("adv_brand")));
                    dropDown.SelectByValue("670");
                  }
                if (Campaign_brand.Equals("Cradley Creations"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adv_brand"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("adv_brand")));
                    dropDown.SelectByValue("318");
                }
                if (Campaign_brand.Equals("Crazy Neuron Studio"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adv_brand"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("adv_brand")));
                    dropDown.SelectByValue("195");
                }
                if (Campaign_brand.Equals("Glorious Guns"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adv_brand"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("adv_brand")));
                    dropDown.SelectByValue("1220");
                }
                if (Campaign_brand.Equals("Happy Family Studio"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adv_brand"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("adv_brand")));
                    dropDown.SelectByValue("511");

                }
                if (Campaign_brand.Equals("Jumbo Jutt"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adv_brand"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("adv_brand")));
                    dropDown.SelectByValue("800");
                }
                if (Campaign_brand.Equals("Mizo Studio"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adv_brand"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("adv_brand")));
                    dropDown.SelectByValue("12");
                }
                if (Campaign_brand.Equals("new Automated brand"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("adv_brand"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("adv_brand")));
                    dropDown.SelectByValue("11042");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Brand field not found" + " " + e.Message);
            }
            return null;
        }

        internal void FindAndSelectAdName()
        {
            try
            {
                var script = "jQuery(\"a:contains('buntoo Ad')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("AdName Field not found" + e.Message);
            }
            return;
        }
        internal void FindAndClickNewbtnofCreatives()
        {
            try
            {
                var script = "jQuery(\"button:contains('New')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("New Field not found" + e.Message);
            }
            return;
        }
        internal IWebElement FindAndClickCreativeName()
        {
            try
            {
               // Extension.HighLighterMethod(window, window.FindElement(By.XPath("//input[@id='input-creative-name']")));
                return window.FindElement(By.XPath("//input[@id='input-creative-name']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign creative name field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickChooseImage(String Campaign_Adtype)
        {
            try
            {
                if (Campaign_Adtype.Equals ("Interstitial"))
                {
                    /* Extension.HighLighterMethod(window, window.FindElement(By.XPath("//input[@id='input_creative_images']")));
                     return window.FindElement(By.XPath("//input[@id='input-creative-name']"));*/
                    IWebElement UploadImage = window.FindElement(By.Id("input_creative_images"));
                    UploadImage.SendKeys("E:\\Automation\\Monetization_Automation\\Montization_Automation\\CreativeSets\\16_9_image.png");
                }
                if (Campaign_Adtype.Equals("Video"))
                {
                    /* Extension.HighLighterMethod(window, window.FindElement(By.XPath("//input[@id='input_creative_images']")));
                     return window.FindElement(By.XPath("//input[@id='input-creative-name']"));*/
                    IWebElement UploadImage = window.FindElement(By.Id("input_creative_images"));
                    UploadImage.SendKeys("E:\\Automation\\Monetization_Automation\\Montization_Automation\\CreativeSets\\16_9_image.png");
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                    UploadImage.SendKeys("E:\\Automation\\Monetization_Automation\\Montization_Automation\\CreativeSets\\Potraitlessthen30.mp4");
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);

                }
                if (Campaign_Adtype.Equals ("Banner"))
                {
                    /* Extension.HighLighterMethod(window, window.FindElement(By.XPath("//input[@id='input_creative_images']")));
                     return window.FindElement(By.XPath("//input[@id='input-creative-name']"));*/
                    IWebElement UploadImage = window.FindElement(By.Id("input_creative_images"));
                    UploadImage.SendKeys("E:\\Automation\\Monetization_Automation\\Montization_Automation\\CreativeSets\\16_9_image.png");
                }
                if (Campaign_Adtype.Equals( "Native"))
                {
                    /* Extension.HighLighterMethod(window, window.FindElement(By.XPath("//input[@id='input_creative_images']")));
                     return window.FindElement(By.XPath("//input[@id='input-creative-name']"));*/
                    IWebElement UploadImage = window.FindElement(By.Id("input_creative_images"));
                    UploadImage.SendKeys("E:\\Automation\\Monetization_Automation\\Montization_Automation\\CreativeSets\\Native.png");
                    IWebElement Title = window.FindElement(By.XPath("//input[@id='input_native_title']"));
                    Title.SendKeys(ExcelUtil.ReadData(1, "Campaign_Native_title"));
                    IWebElement SubTitle = window.FindElement(By.XPath("//input[@id='input_native_subtitle']"));
                    SubTitle.SendKeys(ExcelUtil.ReadData(1, "Campaign_Native_Subtitle"));
                    IWebElement Description = window.FindElement(By.XPath("//textarea[@id='input_native_description']"));
                    Description.SendKeys(ExcelUtil.ReadData(1, "Campaign_Native_Description"));
                    IWebElement ButtonText = window.FindElement(By.XPath("//input[@id='input_native_button_text']"));
                    ButtonText.SendKeys(ExcelUtil.ReadData(1, "Campaign_Native_submit"));
                }
                if (Campaign_Adtype.Equals( "Rewarded Video"))
                {
                    /* Extension.HighLighterMethod(window, window.FindElement(By.XPath("//input[@id='input_creative_images']")));
                     return window.FindElement(By.XPath("//input[@id='input-creative-name']"));*/
                    IWebElement UploadImage = window.FindElement(By.Id("input_creative_images"));
                    UploadImage.SendKeys("E:\\Automation\\Monetization_Automation\\Montization_Automation\\CreativeSets\\16_9_image.png");
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                    UploadImage.SendKeys("E:\\Automation\\Monetization_Automation\\Montization_Automation\\CreativeSets\\Potraitlessthen30");
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                }
                if (Campaign_Adtype.Equals("Icon"))
                {
                    /* Extension.HighLighterMethod(window, window.FindElement(By.XPath("//input[@id='input_creative_images']")));
                     return window.FindElement(By.XPath("//input[@id='input-creative-name']"));*/
                    IWebElement UploadImage = window.FindElement(By.Id("input_creative_images"));
                    UploadImage.SendKeys("E:\\Automation\\Monetization_Automation\\Montization_Automation\\CreativeSets\\16_9_image.png");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Choose creative set button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickCreativeSaveBtn()
        {
            try
            {
               // Extension.HighLighterMethod(window, window.FindElement(By.XPath("//button[@id='submitButton']")));
                return window.FindElement(By.XPath("//button[@id='submitButton']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Creative Save button not found" + " " + e.Message);
            }
            return null;
        }
        internal void FindAndClickCreativeCloseBtn()
        {
            try
            {
                var script = "jQuery(\"button:contains('Close')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                Assert.Fail("Close button not found" + " " + e.Message);
            }
            return;
        }
        internal SelectElement FindAndSelectCampaignPlatform(String Campaign_Platfrom)
        {
            try
            {
                if (Campaign_Platfrom.Equals ("Google Play"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("camp_platform"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("camp_platform")));
                    dropDown.SelectByValue("41");
                }
                if (Campaign_Platfrom.Equals ("Apple"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("camp_platform"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("camp_platform")));
                    dropDown.SelectByValue("42");
                }
                if (Campaign_Platfrom.Equals ("Amazon"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("camp_platform"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("camp_platform")));
                    dropDown.SelectByValue("43");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign platform field not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectCampaignPublishIn(String PublishIn)
        {
            try
            {
                if (PublishIn.Equals ("Brands"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("publish_in_drop"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("publish_in_drop")));
                    dropDown.SelectByValue("brands");
                }
                if (PublishIn.Equals ("Groups"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("publish_in_drop"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("publish_in_drop")));
                    dropDown.SelectByValue("groups");
                }

            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Publish In field not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectCampaignCreatives(string creativeName)
        {
            try
            {
                IWebElement selectElement = window.FindElement(By.Id("creative"));
                SelectElement dropDown = new SelectElement(selectElement);
               // Extension.HighLighterMethod(window, window.FindElement(By.Id("creative")));
                dropDown.SelectByText(creativeName);
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign creatives not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndScrollToSaveBtn()
        {
            try
            {
                Thread.Sleep(1000);
                var script = "var ch = document.getElementById('btnSubmit').scrollIntoView();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
             
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign save button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickCampaignSaveBtn()
        {
            try
            {
               
                Thread.Sleep(1000);
                return window.FindElement(By.XPath("//button[@id='btnSubmit']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign save button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAdidSaveBtn()
        {
            try
            {

                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                return window.FindElement(By.XPath("//button[@id='submitButton_adIds']"));
                
            }
            catch (Exception e)
            {
                Assert.Fail("Adid save button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAdidCloseBtn()
        {
            try
            {

                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                return window.FindElement(By.XPath("//button[@class='btn dark btn-outline']"));

            }
            catch (Exception e)
            {
                Assert.Fail("Adid save button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickNonIntCampaignSaveBtn()
        {
            try
            {

                Thread.Sleep(1000);
                var script = "var div = document.getElementsByClassName('pull-right'); var ch = div[9].getElementsByTagName('button'); ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign save button not found" + " " + e.Message);
            }
            return null;
        }

        internal IWebElement FindAndSelectNetworkCampaignType()
        {
            try
            {
                Thread.Sleep(3000);
                var script = "var maindiv=document.getElementsByClassName('mt-radio-inline'); var child = maindiv[2]; var final = document.getElementById('network'); final.click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Network Campaign radio button not found" + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAppNewBrandBtn()
        {
            try
            {
                Thread.Sleep(3000);
                var script = "var div = document.getElementsByClassName('col-sm-3 control-label'); div[7].click();var child =div[7].getElementsByTagName('a'); child[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Network Campaign radio button not found" + e.Message);
            }
            return null;
        }
        internal void FindAndSelectNotIntegratedNetwortCampaign()
        {
            try
            {
                var script = "var pdiv = document.getElementsByName('advertising'); var child = pdiv[1]; child.click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign no radio button not found" + e.Message);
            }
            return;
        }
        internal SelectElement FindAndSelectCampaignCostingType(string Campaign_PricingType)
        {
            try
            {
                if (Campaign_PricingType.Equals ("CPM"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("camp_costing_type"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("camp_costing_type")));
                    dropDown.SelectByValue("CPM");
                }
                if (Campaign_PricingType.Equals("CPC"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("camp_costing_type"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("camp_costing_type")));
                    dropDown.SelectByValue("CPC");
                }
                if (Campaign_PricingType.Equals("CPC"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("camp_costing_type"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("camp_costing_type")));
                    dropDown.SelectByValue("CPM");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Costing Type field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickDailyBudget()
        {
            try
            {
                return window.FindElement(By.Id("dailyBudget"));
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Daily Budget field not found" + " " + e.Message);
            }
            return null;
        }

        internal IWebElement FindAndClickTotalBudget()
        {
            try
            {
                return window.FindElement(By.Id("totalBudget"));
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Total Budget field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickBid()
        {
            try
            {
                return window.FindElement(By.Id("cpcCost"));
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Bid field not found" + " " + e.Message);
            }
            return null;
        }

        //CROSS PROMO INTEGRATED CAMPAIGN CREATION:
        internal void FindAndSelectCrossNotIntegratedCampaign()
        {
        
                try
                {

                var script = "var div = document.getElementsByClassName('table table-striped table-bordered table-hover dataTable');var child = div[0].getElementsByTagName('td');var final = child[2].innerText; return final;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.FirstCompareValue = (string) js.ExecuteScript(script);
                 Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                 /*Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                 Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                 IWebElement search= window.FindElement(By.ClassName("table-scrollable"));
                 var table = window.FindElement(By.Id("camp-list-dataTable-cp"));
                 actions.MoveToElement(table).Perform();
                 var rows = table.FindElements(By.TagName("tr"));
                 var cols = table.FindElements(By.TagName("td"));
                 bool found = false;

                  foreach (var row in rows)
                  {
                  foreach (var col in cols)
                    {
                     if (col.Text.Equals (campaignName))
                        {
                         Extension.HighLighterMethod(window, col);
                         Thread.Sleep(5000);
                          found = true;
                          MonetizationRow.RowElement = col;
                         //  actions.SendKeys(Keys.ArrowDown).Perform();
                         break;
                       }
                     break;   
                     }
                  }
                 IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                 return;*/
            }
            catch (Exception e)
            {
                Assert.Fail("Not integrated Cross Campaign not found" + e.Message);
            }
            
        }
        internal void FindAndSelectNetworkIntegratedCampaigntitle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('table table-striped table-bordered table-hover dataTable');var child = div[0].getElementsByTagName('td');var final = child[2].innerText; return final;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.FirstCompareValue = (string)js.ExecuteScript(script);
               Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
               /* Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                IWebElement search = window.FindElement(By.ClassName("table-scrollable"));
                var table = window.FindElement(By.Id("camp-list-dataTable"));
                actions.MoveToElement(table).Perform();
                var rows = table.FindElements(By.TagName("tr"));
                var cols = table.FindElements(By.TagName("td"));
                bool found = false;

                foreach (var row in rows)
                {
                    foreach (var col in cols)
                    {
                        if (col.Text.Equals (campaignName))
                        {
                            Extension.HighLighterMethod(window, col);
                            Thread.Sleep(5000);
                            found = true;
                            MonetizationRow.RowElement = col;
                            //  actions.SendKeys(Keys.ArrowDown).Perform();
                            break;
                        }
                        break;
                    }
                }
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                return;*/
            }
            catch (Exception e)
            {
                Assert.Fail("Not integrated Cross Campaign not found" + e.Message);
            }

        }
        //Network Integrated Camapaign
        internal IWebElement FindAndSelectNetworkIntegratedCampaign()
        {
            try
            {
                Thread.Sleep(1000);
                var script = "var div=document.getElementsByName('advertising'); var child = div[0]; child.click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Yes radio button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndValidateApp()
        {
            try
            {
                // Thread.Sleep(1000);
                //return window.FindElement(By.XPath("//a[contains(text(), )]"));

                /*  var findApp = window.FindElement(By.ClassName("table-scrollable"));
                  var child = findApp.FindElement(By.TagName("a"));
                  child.FindElement(By.)*/
                /*  var findApp = "var div = document.getElementsByClassName('table-scrollable'); var child=div[0].getElementsByTagName('a'); child[1];";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(findApp);*/
                var script = "var div = document.getElementsByClassName('table table-striped table-bordered table-hover dataTable no-footer'); var ch = div[0].getElementsByTagName('tr'); var fin=ch[1].getElementsByTagName('td'); var final= fin[5].getElementsByTagName('a');var apptitle=final[0].innerText; return apptitle";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                string appTitle= (string) js.ExecuteScript(script);
                Thread.Sleep(1000);  
                string[] parts = appTitle.Split(new Char[] { '\n','\r' });
                AppManageTableValues.SecondCompareValue = parts[0];
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                Assert.Fail("app not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndValidateCrossCampaign()
        {
            try
            {
                window.FindElement(By.XPath("//a[contains(text(),'Automated Campaign')]"));
            }
            catch (Exception e)
            {
                Assert.Fail("Ad Filter link not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickPromotingField()
        {
            try
            {
                Thread.Sleep(1000);
                var script = "var div = document.getElementsByClassName('filter-option pull-left'); div[0].click(); var child = document.getElementsByClassName('fa fa-android'); child[1].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("App icon not found" + " " + e.Message);
            }
            return null;
        }
       

        internal IWebElement FindAndClickApps()
        {
            try
            {
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                //   Extension.HighLighterMethod(window, window.FindElement(By.XPath("//*[@class='fa fa-mobile']")));
                return window.FindElement(By.XPath("//*[@class='fa fa-mobile']"));
            }
            catch (Exception e)
            {
                Assert.Fail("App icon not found" + " " + e.Message);
            }
            return null;
        }

     
        internal void FindAndClickAppsManagement()
        {
            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                var script = "var div= document.getElementsByClassName('nav-item');var child = div[9].getElementsByTagName('a');child[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("App Management icon not found" + " " + e.Message);
            }
            return;
        }

        
        internal IWebElement FindAndClickPlaceholdersAndAds()
        {
            try
            {
                var allTabs = window.FindElement(By.CssSelector("ul[id='appTabs']"));
                var reqTab = allTabs.FindElement(By.CssSelector("li[id='appsLivePlaceholdersAndAds']"));
              //  Extension.HighLighterMethod(window, reqTab);
                return reqTab;
            }
            catch (Exception e)
            {
                Assert.Fail("Ad Filter link not found" + " " + e.Message);
            }
            return null;
        }

        
        internal IWebElement FindAndClickMediatoinTab()
        {
            try
            {
              //  Extension.HighLighterMethod(window, window.FindElement(By.XPath("//a[text()=' Mediation ']")));
                return window.FindElement(By.XPath("//a[text()='Mediation']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Mediation tab link not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickManageTab()
        {
            try
            {
              //  Extension.HighLighterMethod(window, window.FindElement(By.XPath("//span[contains(text(),'Manage')]")));
              //  return window.FindElement(By.XPath("//span[contains(text(),'Manage')]"));
                var script = "jQuery(\"span:contains('Manage')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                Assert.Fail("Mediation tab link not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAdFilter()
        {
            try
            {
                return window.FindElement(By.XPath("//a[text()=' Ad Filters ']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Ad Filter link not found" + " " + e.Message);
            }
            return null;
        }

        internal IWebElement FindAndClickAdNework()
        {
            try
            {
                return window.FindElement(By.XPath("//a[text()='Ad Networks']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Ad Networks link not found" + " " + e.Message);
            }
            return null;
        }


        internal void FindAndSelectApplication(string appName)
        {
            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                var table = window.FindElement(By.Id("employee-grid"));
                actions.MoveToElement(table).Perform();
                var rows = table.FindElements(By.TagName("tr"));
                foreach (var row in rows)
                {
                    if (row.Text.Contains(appName))
                    {
                        actions.MoveToElement(row).Build().Perform();
                     //   Extension.HighLighterMethod(window, row);
                        Thread.Sleep(5000);
                        MonetizationRow.RowElement = row;
                        actions.MoveToElement(MonetizationRow.RowElement).Build().Perform();
                        actions.SendKeys(Keys.ArrowDown).Perform();
                        
                        break;
                    }
                }
                var element = MonetizationRow.RowElement.FindElement(By.CssSelector("a[title='View']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
             //   Extension.HighLighterMethod(window, element);
                element.Click();
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("System did not find the application in the table" + " " + e.Message);
            }
            return;
        }

        
        internal IWebElement FindAndClickSaveButton()
        {
            try
            {
                var mainSaveDiv = window.FindElement(By.CssSelector("div[class='col-sm-12 ']")); 
               // Extension.HighLighterMethod(window, mainSaveDiv);
                var childSaveDiv = mainSaveDiv.FindElement(By.CssSelector("div[class='pull-right']"));
              //  Extension.HighLighterMethod(window, childSaveDiv);
                childSaveDiv.Click();
            }
            catch (Exception e)
            {
                Assert.Fail("Save button not found" + " " + e.Message);
            }
            return null;
        }

        internal IWebElement FindAndSelectAdContentCheckBox()
        {
            try
            {
                Thread.Sleep(3000);
                var element = window.FindElement(By.CssSelector("input[name='checkedCheckboxes']"));
              //  Extension.HighLighterMethod(window, element);
                return window.FindElement(By.CssSelector("input[name='checkedCheckboxes']"));
            }
            catch (Exception e)
            {
                Assert.Fail("check box not found" + " " + e.Message);
            }
            return null;
        }

        internal SelectElement FindSelectShowAdMechanism(int mechanism)
        {
            try
            {
                Thread.Sleep(3000);
                IWebElement selectElement = window.FindElement(By.CssSelector("select[Id='ads_queue_type']"));
                SelectElement dropDown = new SelectElement(selectElement);
              //  Extension.HighLighterMethod(window, window.FindElement(By.CssSelector("select[Id='ads_queue_type']")));
                dropDown.SelectByIndex(mechanism);
            }
            catch (Exception e)
            {
                Assert.Fail("Show add mechanism dropdown field not found" + " " + e.Message);
            }
            return null;
        }

        internal SelectElement FindAndSelectAdType(int AdType)
        {
            try
            {
                Thread.Sleep(3000);
                IWebElement selectElement = window.FindElement(By.CssSelector("select[Id='sel_ads_type']"));
                SelectElement dropDown = new SelectElement(selectElement);
             //   Extension.HighLighterMethod(window, window.FindElement(By.CssSelector("select[Id='sel_ads_type']")));
                dropDown.SelectByIndex(AdType);
            }
            catch (Exception e)
            {
                Assert.Fail("Ad Type dropdown field not found" + " " + e.Message);
            }
            return null;
        }

        internal SelectElement FindAndSelectAddNetwork(int adNetwork)
        {
            try
            {
                Thread.Sleep(3000);
                IWebElement selectElement = window.FindElement(By.CssSelector("select[Id='adNetworkFilter']"));
                
                SelectElement dropDown = new SelectElement(selectElement);
              //  Extension.HighLighterMethod(window, window.FindElement(By.CssSelector("select[Id='adNetworkFilter']")));
                dropDown.SelectByIndex(adNetwork);
               
            }
            catch (Exception e)
            {
                Assert.Fail("Add network dropdown field not found" + " " + e.Message);
            }
            return null;
        }

        internal IWebElement FindRequiredApplicationSearchField()
        {
            try
            {
              //  Extension.HighLighterMethod(window, window.FindElement(By.XPath("//*[@class='form-control input-sm input-small input-inline']")));
                return window.FindElement(By.XPath("//*[@class='form-control input-sm input-small input-inline']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Search field not found" + " " + e.Message);
            }
            return null;
        }

        internal IWebElement FindAndInsertDateFilterEndDateApp(string enddate)
        {

            try
            {
                Thread.Sleep(4000); Thread.Sleep(4000); Thread.Sleep(4000);
                //var EndDate = window.FindElement(By.XPath("//input[@class='input-mini form-control']"));
                var EndDate = window.FindElement(By.CssSelector("body.page-header-fixed.page-sidebar-fixed.page-sidebar-closed-hide-logo.page-content-white.page-sidebar-closed:nth-child(2) div.daterangepicker.dropdown-menu.ltr.show-calendar.opensright:nth-child(15) div.calendar.right:nth-child(3) div.daterangepicker_input > input.input-mini.form-control"));
                Thread.Sleep(4000);
                EndDate.Clear();
                EndDate.SendKeys(enddate);
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript("$(arguments[0]).change();", EndDate);

            }
            catch (Exception e)
            {
                Assert.Fail("Date filter end date field not found" + " " + e.Message);
            }
            return null;
        }

        internal void FindAndCompareStatsofAppsAdStats()
        {
            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                var script = "var div = document.getElementById('scene-summary'); var ch = div.getElementsByTagName('td'); var text = ch[0].textContent; return text;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableValues[0] = (string)js.ExecuteScript(script);
                script = "var div = document.getElementById('scene-summary'); var ch = div.getElementsByTagName('td'); var text = ch[1].textContent; return text;";
                AppManageTableValues.tableValues[1] = (string)js.ExecuteScript(script);
                string portalRequest = AppManageTableValues.tableValues[1].Replace(",", "");
                script = "var div = document.getElementById('scene-summary'); var ch = div.getElementsByTagName('td'); var text = ch[2].textContent; return text;";
                AppManageTableValues.tableValues[2] = (string)js.ExecuteScript(script);
                string portalImpression = AppManageTableValues.tableValues[2].Replace(",", "");
                script = "var div = document.getElementById('scene-summary'); var ch = div.getElementsByTagName('td'); var text = ch[3].textContent; return text;";
                AppManageTableValues.tableValues[3] = (string)js.ExecuteScript(script);
                string fillrateportal = AppManageTableValues.tableValues[3].Replace("%", "");
                script = "var div = document.getElementById('scene-summary'); var ch = div.getElementsByTagName('td'); var text = ch[4].textContent; return text;";
                AppManageTableValues.tableValues[4] = (string)js.ExecuteScript(script);
                String PortalClick = AppManageTableValues.tableValues[4].Replace("\r", "").Replace("\n", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                script = "var div = document.getElementById('scene-summary'); var ch = div.getElementsByTagName('td'); var text = ch[5].textContent; return text;";
                AppManageTableValues.tableValues[5] = (string)js.ExecuteScript(script);
                string ctrPortal = AppManageTableValues.tableValues[5].Replace("%", "");
                script = "var div = document.getElementById('scene-summary'); var ch = div.getElementsByTagName('td'); var text = ch[6].textContent; return text;";
                AppManageTableValues.tableValues[6] = (string)js.ExecuteScript(script);
                //Database compare strings
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "App_AdStats_Scene");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string SceneName = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][0].ToString());
                string Request = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][2].ToString());
                string Impression = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][3].ToString());
                string Click = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());
                string Installs = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][5].ToString());
                var fillrate = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][6]).ToString();
                var fillratedouble = Convert.ToDouble(fillrate);
                var fillrateroundoff = Math.Round(fillratedouble, 3);
                string fillratestring = fillrateroundoff.ToString();
                string ctr = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][7].ToString());
                var ctrdouble = Convert.ToDouble(ctr);
                var ctrroundoff = Math.Round(ctrdouble, 3);
                string ctrstring = ctrroundoff.ToString();

                if (fillrateroundoff > 100)
                {
                    fillratestring = "100";
                }
                if (AppManageTableValues.tableValues[0] != SceneName)
                {
                    Assert.Fail("SceneName not matched");
                }
                if (portalRequest != Request)
                {
                    Assert.Fail("Request of an app not matched");
                }
                if (portalImpression != Impression)
                {
                    Assert.Fail("impressions of an app not matched");
                }
                if (PortalClick != Click)
                {
                    Assert.Fail("Click of an app not matched");
                }
                if (AppManageTableValues.tableValues[6] != Installs)
                {
                    Assert.Fail("Install of an app not matched");
                }
                if (fillrateportal != fillratestring)
                {
                    Assert.Fail("fillrate of an app not matched");
                }
                if (ctrPortal != ctrstring)
                {
                    Assert.Fail("ctr of an app not matched");
                }
                /*  if (revenuePortal != revenue)
                  {
                      Assert.Fail("revenue of an app not matched");
                  }*/

            }
            catch (Exception e)
            {
                Assert.Fail("App stats are not matching" + e.Message);
            }
        }

        internal IWebElement FindAndClickAppsAdStatsTab()
        {

            try
            {
                Thread.Sleep(4000); Thread.Sleep(4000); Thread.Sleep(4000);
                return window.FindElement(By.XPath("//a[contains(text(),'Ad Stats')]"));
                /* var script = "var div = document.getElementsByClassName('table table-striped table-bordered table-hover dataTable no-footer'); var ch = div[0].getElementsByTagName('tr'); var fin=ch[1].getElementsByTagName('td'); var final= fin[5].getElementsByTagName('a'); final[0].click();";
                 IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                 js.ExecuteScript(script);*/
                Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("App not found" + " " + e.Message);
            }
            return null;
        }

        internal IWebElement FindRequiredAdnetworkField()
        {
            try
            {
                Thread.Sleep(4000); Thread.Sleep(4000);
                //  Extension.HighLighterMethod(window, window.FindElement(By.XPath("//*[@class='form-control input-sm input-small input-inline']")));
                return window.FindElement(By.CssSelector("body.page-header-fixed.page-sidebar-fixed.page-sidebar-closed-hide-logo.page-content-white.page-sidebar-closed:nth-child(2) div.page-container:nth-child(7) div.page-content-wrapper:nth-child(9) div.page-content div.row:nth-child(3) div.col-lg-12.col-md-12.col-sm-12.col-xs-12 div.tab-content div.tab-pane.fade.active.in:nth-child(6) div.row:nth-child(3) div.col-lg-12:nth-child(3) div.col-lg-12:nth-child(2) div.panel.panel-default:nth-child(3) div.panel-body div.dataTables_wrapper div.row:nth-child(1) div.col-md-6.col-sm-6:nth-child(2) div.dataTables_filter label:nth-child(1) > input.form-control.input-sm.input-small.input-inline"));
            }
            catch (Exception e)
            {
                Assert.Fail("Search field not found" + " " + e.Message);
            }
            return null;
        }

        internal void FindAndCompareStatsofAppsAdnetwork()
        {
            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                var script = "var div = document.getElementById('campaignList');  var ch = div.getElementsByTagName('td'); var text = ch[0].textContent; return text;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableValues[0] = (string)js.ExecuteScript(script);
                script = "var div = document.getElementById('campaignList');  var ch = div.getElementsByTagName('td'); var text = ch[1].textContent; return text;";
                AppManageTableValues.tableValues[1] = (string)js.ExecuteScript(script);
                script = "var div = document.getElementById('campaignList');  var ch = div.getElementsByTagName('td'); var text = ch[2].textContent; return text;";
                AppManageTableValues.tableValues[2] = (string)js.ExecuteScript(script);
                string portalRequest = AppManageTableValues.tableValues[2].Replace(",", "");
                script = "var div = document.getElementById('campaignList');  var ch = div.getElementsByTagName('td'); var text = ch[3].textContent; return text;";
                AppManageTableValues.tableValues[3] = (string)js.ExecuteScript(script);
                string portalImpression = AppManageTableValues.tableValues[3].Replace(",", "");
                script = "var div = document.getElementById('campaignList');  var ch = div.getElementsByTagName('td'); var text = ch[4].textContent; return text;";
                AppManageTableValues.tableValues[4] = (string)js.ExecuteScript(script);
                string FillratePortal = AppManageTableValues.tableValues[4].Replace("%", "");
                // String PortalClick = AppManageTableValues.tableValues[4].Replace("\r", "").Replace("\n", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                script = "var div = document.getElementById('campaignList');  var ch = div.getElementsByTagName('td'); var text = ch[5].textContent; return text;";
                AppManageTableValues.tableValues[5] = (string)js.ExecuteScript(script);
                string clickPortal = AppManageTableValues.tableValues[5].Replace(" ", "");
                script = "var div = document.getElementById('campaignList');  var ch = div.getElementsByTagName('td'); var text = ch[6].textContent; return text;";
                AppManageTableValues.tableValues[6] = (string)js.ExecuteScript(script);
                string CTRPortal = AppManageTableValues.tableValues[6].Replace("%", "");
                //Database compare strings
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "App_AdStats_adnetwork");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string Adnetwork = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][1].ToString());
                string Request = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][3].ToString());
                var RequestsDb = Convert.ToDouble(Request);
                string Impression = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());
                var ImpressionDb = Convert.ToDouble(Impression);
                string Click = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][5].ToString());
                var clickDb = Convert.ToDouble(Click);
                string Adtype = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][7].ToString());
                var fillrate = ImpressionDb / RequestsDb * 100;
                var fillrateroundoff = Math.Round(fillrate, 3);
                string fillrateDb = fillrateroundoff.ToString();
                var CTR = clickDb / ImpressionDb * 100;
                var CTRroundoff = Math.Round(CTR, 3);
                string CTRDb = CTRroundoff.ToString();

                if (fillrateroundoff > 100)
                {
                    fillrateDb = "100";
                }
                if (AppManageTableValues.tableValues[0] != Adnetwork)
                {
                    Assert.Fail("Adnetwork name not matched");
                }
                if (AppManageTableValues.tableValues[1] != Adtype)
                {
                    Assert.Fail("Adtype of an app not matched");
                }
                if (portalRequest != Request)
                {
                    Assert.Fail("Request of an app not matched");
                }
                if (portalImpression != Impression)
                {
                    Assert.Fail("Impression of an app not matched");
                }
                if (clickPortal != Click)
                {
                    Assert.Fail("Click of an app not matched");
                }
                if (FillratePortal != fillrateDb)
                {
                    Assert.Fail("Fillrate of an app not matched");
                }
                if (CTRPortal != CTRDb)
                {
                    Assert.Fail("ctr of an app not matched");
                }
                /*  if (revenuePortal != revenue)
                  {
                      Assert.Fail("revenue of an app not matched");
                  }*/

            }
            catch (Exception e)
            {
                Assert.Fail("App stats are not matching" + e.Message);
            }

        }

        internal IWebElement FindAndClickApplybtnApp()
        {

            try
            {
                Thread.Sleep(4000); Thread.Sleep(4000);
                // return window.FindElement(By.XPath("//button[@class='applyBtn btn btn-sm btn-success']"));
                return window.FindElement(By.CssSelector("body.page-header-fixed.page-sidebar-fixed.page-sidebar-closed-hide-logo.page-content-white.page-sidebar-closed:nth-child(2) div.daterangepicker.dropdown-menu.ltr.show-calendar.opensright:nth-child(15) div.ranges:nth-child(1) div.range_inputs:nth-child(2) > button.applyBtn.btn.btn-sm.btn-success"));
            }
            catch (Exception e)
            {
                Assert.Fail("Apply Button not found" + " " + e.Message);
            }
            return null;
        }

        internal IWebElement FindCrossPromotionCampaignSearchField(string searchValue)
        {
            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                return window.FindElement(By.XPath("//*[@class='form-control input-sm input-small input-inline']"));

               /* var script = string.Format("var searchElement = document.getElementsByClassName('form-control input-sm input-small input-inline'); searchElement[0].value = '{0}'", searchValue);
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);*/
            }
            catch (Exception e)
            {
                Assert.Fail("Search field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndSearchBrand()
        {
            try
            {
              //  Extension.HighLighterMethod(window, window.FindElement(By.XPath("//*[@class='form-control input-sm input-small input-inline']")));
                return window.FindElement(By.XPath("//*[@class='form-control input-sm input-small input-inline']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Search field not found" + " " + e.Message);
            }
            return null;
        }
        internal void SearchBrandTitle(string brandName)
        {
            try
            {
                IWebElement divclass = window.FindElement(By.ClassName("table-scrollable"));
                var table = window.FindElement(By.Id("brands-list-dataTable"));
                actions.MoveToElement(table).Perform();
                var rows = table.FindElements(By.TagName("tr"));
                var cols = table.FindElements(By.TagName("td"));
                foreach (var row in rows)
                {
                 foreach(var col in cols)
                    if (col.Text.Equals(brandName))
                    {     
                      //  Extension.HighLighterMethod(window, col);
                        Thread.Sleep(5000);
                        MonetizationRow.RowElement = col;
                      //  actions.SendKeys(Keys.ArrowDown).Perform();
                        break;
                    }
                    
                }
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
             //  
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Brand not found" + " " + e.Message);
            }
            return;
        }
        internal IWebElement SearchBrandName()
        {
            try
            {
                var script = "var table = document.getElementsByTagName('Table'); var allTDTags = table[0].getElementsByTagName('td'); var brandTitle = allTDTags[2].innerText; return brandTitle";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.FirstCompareValue = (string) js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);      
            }
            catch (Exception e)
            {
                Assert.Fail("Brand not found" + " " + e.Message);
            }
            return null;
        }
        internal void FindAndSelectNetworkNotIntegratedCampaign(string campaignName)
        {

            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                var table = window.FindElement(By.Id("camp-list-dataTable"));
                actions.MoveToElement(table).Perform();
                var rows = table.FindElements(By.TagName("tr"));
                var cols = table.FindElements(By.TagName("td"));
                bool found = false;

                foreach (var row in rows)
                {
                    foreach (var col in cols)
                    {
                        if (col.Text.Equals (campaignName))
                        {
                         //   Extension.HighLighterMethod(window, col);
                            Thread.Sleep(5000);
                            found = true;
                            MonetizationRow.RowElement = col;
                            //  actions.SendKeys(Keys.ArrowDown).Perform();
                            break;
                        }
                        break;
                    }
                }
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Not Integrated Network advertising Campaign not found" + e.Message);
            }
         
        }

        internal IWebElement FindAndClickUsersLink()
        {
            try
            {
                Thread.Sleep(2000);

                var script = "var ch = document.getElementsByClassName('fa fa-users');ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Users field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickNewUserBtn()
        {
            try
            {
                Thread.Sleep(2000);
                return window.FindElement(By.XPath("//a[@class='btn green-meadow btn-md pull-right']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Users field not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectUserRole(string userrole )
        {
            try
            {
                if (userrole.Equals ("Owner"))
                {
                    Thread.Sleep(2000); Thread.Sleep(2000);
                    IWebElement selectElement = window.FindElement(By.Id("userRole"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("userRole")));
                    dropDown.SelectByValue("1");
                }
                if (userrole.Equals ("Admin"))
                {
                    Thread.Sleep(2000); Thread.Sleep(2000);
                    IWebElement selectElement = window.FindElement(By.Id("userRole"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("userRole")));
                    dropDown.SelectByValue("2");
                }
                if (userrole.Equals("Manager"))
                {
                    Thread.Sleep(2000); Thread.Sleep(2000);
                    IWebElement selectElement = window.FindElement(By.Id("userRole"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("userRole")));
                    dropDown.SelectByValue("3");
                }
                if (userrole.Equals("Developer"))
                {
                    Thread.Sleep(2000); Thread.Sleep(2000);
                    IWebElement selectElement = window.FindElement(By.Id("userRole"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("userRole")));
                    dropDown.SelectByValue("4");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("User Role field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickUserFullNameField()
        {
            try
            {
                return window.FindElement(By.XPath("//input[@id='fullName']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Full Name field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickUsersEmail()
        {
            try
            {
                return window.FindElement(By.XPath("//input[@id='email']"));

            }
            catch (Exception e)
            {
                Assert.Fail("Users email field not found" + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectUsersBrands(string brand)
        {
            try
            {
                Thread.Sleep(3000);
                /*  var elements = window.FindElements(By.XPath("//li[@class='select2-search select2-search--inline']")).ToArray();
                  var visible = elements.Where(r => r.Displayed).ToArray();
                  visible[0].Click();*/
                if (brand.Equals ("Buntoo Games"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("selectedBrands"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("selectedBrands")));
                    dropDown.SelectByText("Buntoo Games");
                }
                if (brand.Equals ("Glorious Guns"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("selectedBrands"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("selectedBrands")));
                    dropDown.SelectByText("Buntoo Games");
                }
                if (brand.Equals ("Buntoo Games"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("selectedBrands"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("selectedBrands")));
                    dropDown.SelectByText("Happy Family Studio");
                }
                //      visible[0].SendKeys("Pentabit");

            }
            catch (Exception e)
            {
                Assert.Fail("Users email field not found" + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickUsersSaveBtn()
        {
            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                var script = "jQuery(\"button:contains('Save')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(2000);
                //return window.FindElement(By.XPath("//button[@id='btnSubmit']"));
                // return window.FindElement(By.Name("btnSubmit"));
                //visible[0].SendKeys("Pentabit");
            }
            catch (Exception e)
            {
                Assert.Fail("Users email field not found" + e.Message);
            }
            return null;
        }

        internal void FindAndCompareStatsofApps()
        {
            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                var script = "var table = document.getElementById('employee-grid');var children = table.rows;var text = children[1].cells[5].innerText; return text;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableValues[0] = (string)js.ExecuteScript(script);
                String AppTitleAndPackage = AppManageTableValues.tableValues[0].Replace("\r", "").Replace("\n", "").Replace("(", "").Replace(")", "");
                script = "var table = document.getElementById('employee-grid');var children = table.rows;var text = children[1].cells[7].innerText; return text;";
                AppManageTableValues.tableValues[1] = (string)js.ExecuteScript(script);
                string portalImpression = AppManageTableValues.tableValues[1].Replace(",", "");
                script = "var table = document.getElementById('employee-grid');var children = table.rows;var text = children[1].cells[8].innerText; return text;";
                AppManageTableValues.tableValues[2] = (string)js.ExecuteScript(script);
                string fillrateportal = AppManageTableValues.tableValues[2].Replace("%", "");
                script = "var table = document.getElementById('employee-grid');var children = table.rows;var text = children[1].cells[9].innerText; return text;";
                AppManageTableValues.tableValues[3] = (string)js.ExecuteScript(script);
                string ctrPortal = AppManageTableValues.tableValues[3].Replace("%", "");
                script = "var table = document.getElementById('employee-grid');var children = table.rows;var text = children[1].cells[10].innerText; return text;";
                AppManageTableValues.tableValues[4] = (string)js.ExecuteScript(script);
                string revenuePortal = AppManageTableValues.tableValues[4].Replace("$", "");
                script = "var table = document.getElementById('employee-grid');var children = table.rows;var text = children[1].cells[11].innerText; return text;";
                AppManageTableValues.tableValues[5] = (string)js.ExecuteScript(script);
                string version = AppManageTableValues.tableValues[5];
                //Database compare strings
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "Query");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string AppID = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][0].ToString());
                string Title = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][1].ToString());
                string package = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][2].ToString());
                string osID = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][3].ToString());
                string brandID = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());
                string is_achive = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][5].ToString());
                string sdkID = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][6].ToString());
                string isAM = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][7].ToString());
                string request = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][8].ToString());
                string impression = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][9].ToString());
                string click = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][10].ToString());
                string install = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][11].ToString());
                string revenue = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][12].ToString());
                var fillrate = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][13]).ToString();
                var fillratedouble = Convert.ToDouble(fillrate);
                var fillrateroundoff = Math.Round(fillratedouble, 3);
                string fillratestring = fillrateroundoff.ToString();
                string ctr = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][14].ToString());
                var ctrdouble = Convert.ToDouble(ctr);
                var ctrroundoff = Math.Round(ctrdouble, 3);
                string ctrstring = ctrroundoff.ToString();
                string ver = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][15].ToString());
                if (fillrateroundoff > 100)
                {
                    fillratestring = "100";
                }
                if (AppTitleAndPackage != (Title + package))
                {
                    Assert.Fail("App name not matched");
                }
                if (portalImpression != impression)
                {
                    Assert.Fail("impressions of an app not matched");
                }
                if (fillrateportal != fillratestring)
                {
                    Assert.Fail("fillrate of an app not matched");
                }
                if (ctrPortal != ctrstring)
                {
                    Assert.Fail("ctr of an app not matched");
                }
                /*  if (revenuePortal != revenue)
                  {
                      Assert.Fail("revenue of an app not matched");
                  }*/
                if (version != ver)
                {
                    Assert.Fail("ver of an app not matched");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("App stats are not matching" + e.Message);
            }
        }


         internal void Comparestats()
          {
              try
              {
                  int dataSetIndex = 1;
                  Thread.Sleep(4000);
                  Extension.OpenDBConnection();
                  Thread.Sleep(4000);
                  AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "RevenueTopBarQuery");
                  Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                  string Date = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][0].ToString());
                  string request = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][1].ToString());
                  string completed = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][2].ToString());
                  string available = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][3].ToString());
                  string impressions = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());
                  string revenue = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());

            }
              catch (Exception e)
              {
                  Assert.Fail("Compare stats failed" + e.Message);
              }

          }
        internal void FindAndClickRevenueLink()
        {
            try
            {
                var script = "jQuery(\"span:contains('Revenue')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Revenue link not found" + " " + e.Message);
            }
            return;
        }
        internal void FindAndClickMediationLink()
        {
            try
            {
                var script = "jQuery(\"span:contains('Mediation')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Revenue link not found" + " " + e.Message);
            }
            return;
        }
        internal void FindAndCompareValuesofRevenueTopGrid()
        {
            try
            {
                var script = "var div=document.getElementsByClassName('inner-total'); var text=div[0].innerText; return text";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableArray[0] = (string)js.ExecuteScript(script);
                var script1 = "var div=document.getElementsByClassName('inner-total'); var text=div[0].innerText; return text";
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[1] = (string)js1.ExecuteScript(script1);
                var script2 = "var div=document.getElementsByClassName('inner-total'); var text=div[0].innerText; return text";
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[2] = (string)js2.ExecuteScript(script2);
                var script3 = "var div=document.getElementsByClassName('inner-total'); var text=div[0].innerText; return text";
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[3] = (string)js3.ExecuteScript(script3);
                var script4 = "var div=document.getElementsByClassName('inner-total'); var text=div[0].innerText; return text";
                IJavaScriptExecutor js4 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[4] = (string)js4.ExecuteScript(script4);
                var script5 = "var div=document.getElementsByClassName('inner-total'); var text=div[0].innerText; return text";
                IJavaScriptExecutor js5 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[5] = (string)js4.ExecuteScript(script5);
               //Database Query
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "RevenueTopBarQuery");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string Date = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][0].ToString());
                string request = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][1].ToString());
                string completed = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][2].ToString());
                string available = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][3].ToString());
                string impressions = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());
                string revenue = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());
               
                if (AppManageTableValues.tableArray[0] != impressions)
                {
                    Assert.Fail("Impression not matched");
                }
                if (AppManageTableValues.tableArray[1] != available)
                {
                    Assert.Fail("Avaliable not matched");
                }
                if (AppManageTableValues.tableArray[2] != completed)
                {
                    Assert.Fail("Completed not matched");
                }
                if (AppManageTableValues.tableArray[3] != revenue)
                {
                    Assert.Fail("Revenue not matched");
                }
                /*  if (revenuePortal != revenue)
                  {
                      Assert.Fail("revenue of an app not matched");
                  }*/
              
            }
            catch (Exception e)
            {
                Assert.Fail("Revenue stats not matched" + " " + e.Message);
            }
            return;
        }
        internal void FindAndCompareValuesofRevenueBottomGridAppWise()
        {
            try
            {
                var script = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[0].textContent; return text; ";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableArray[0] = (string)js.ExecuteScript(script);
               string appNamePortal= AppManageTableValues.tableArray[0].Replace("-", "");
                var script1 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[1].textContent;return text;";
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[1] = (string)js1.ExecuteScript(script1);
                var script2 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[2].textContent;return text;";
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[2] = (string)js2.ExecuteScript(script2);
                var script3 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[3].textContent;return text;";
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[3] = (string)js3.ExecuteScript(script3);
                var script4 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[4].textContent;return text;";
                IJavaScriptExecutor js4 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[4] = (string)js4.ExecuteScript(script4);
                string revenuePortal = AppManageTableValues.tableArray[4].Replace("$", "");
                var script5 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[5].textContent;return text;";
                IJavaScriptExecutor js5 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[5] = (string)js5.ExecuteScript(script5);
                string ecpmPortal = AppManageTableValues.tableArray[5].Replace("$", "");
                //Database Query
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "Revenue_Appwise_bottom_table_query");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string appName = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][1].ToString());
               string appNameDb= appName.Replace("-", "");
                string impression = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][5].ToString());
                var ImpressionDb = Convert.ToDouble(impression);
                string available = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][7].ToString());
                string completed = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());
                string revenue = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][8].ToString());
                var Revenuedouble = Convert.ToDouble(revenue);
               var rev= Math.Round(Revenuedouble, 3);
                string revenueDb = rev.ToString();
                var ecpm = rev / ImpressionDb * 1000;
                var ecpmRoundoff = Math.Round(ecpm, 3);
                string ecpmDb = ecpmRoundoff.ToString();

                Math.Round(ecpm, 3);
                //  string ecpm = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][6].ToString());
                if (appNamePortal != appNameDb)
                {
                    Assert.Fail("App not matched");
                }
                if (AppManageTableValues.tableArray[1] != impression)
                {
                    Assert.Fail("impression not matched");
                }
                if (AppManageTableValues.tableArray[2] != available)
                {
                    Assert.Fail("available not matched");
                }
                if (AppManageTableValues.tableArray[3] != completed)
                {
                    Assert.Fail("completed not matched");
                }
                if (revenuePortal != revenueDb)
                {
                    Assert.Fail("Revenue not matched");
                }
               if (ecpmPortal != ecpmDb)
                {
                    Assert.Fail("ecpm not matched");
                }
                /*  if (revenuePortal != revenue)
                  {
                      Assert.Fail("revenue of an app not matched");
                  }*/

            }
            catch (Exception e)
            {
                Assert.Fail("Revenue stats not matched" + " " + e.Message);
            }
            return;
        }
        internal void FindAndCompareValuesofRevenueBottomGridDateWise()
        {
            try
            {
                var script = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text= child[0].textContent;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableArray[0] = (string)js.ExecuteScript(script);
                var script1 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td');var text= child[1].textContent;return text;";
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[1] = (string)js1.ExecuteScript(script1);
                var script2 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[2].textContent;return text;";
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[2] = (string)js2.ExecuteScript(script2);
                var script3 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[3].textContent;return text;";
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[3] = (string)js3.ExecuteScript(script3);
                var script4 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[4].textContent;return text;";
                IJavaScriptExecutor js4 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[4] = (string)js4.ExecuteScript(script4);
                var script5 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[5].textContent;return text;";
                IJavaScriptExecutor js5 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[5] = (string)js4.ExecuteScript(script5);
                //Database Query
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "Revenue_Appwise_bottom_table_query");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string date = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][0].ToString());
                string impression = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][1].ToString());
                var ImpressionDb = Convert.ToDouble(impression);
                string available = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][2].ToString());
                string completed = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][3].ToString());
                string revenue = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][8].ToString());
                var Revenuedouble = Convert.ToDouble(revenue);
                var rev = Math.Round(Revenuedouble, 3);
                string revenueDb = rev.ToString();
                var ecpm = rev / ImpressionDb * 1000;
                var ecpmRoundoff = Math.Round(ecpm, 3);
                string ecpmDb = ecpmRoundoff.ToString();
                if (AppManageTableValues.tableArray[0] != date)
                {
                    Assert.Fail("App not matched");
                }
                if (AppManageTableValues.tableArray[1] != impression)
                {
                    Assert.Fail("impression not matched");
                }
                if (AppManageTableValues.tableArray[2] != available)
                {
                    Assert.Fail("available not matched");
                }
                if (AppManageTableValues.tableArray[3] != completed)
                {
                    Assert.Fail("completed not matched");
                }
                if (AppManageTableValues.tableArray[4] != revenueDb)
                {
                    Assert.Fail("Revenue not matched");
                }
                if (AppManageTableValues.tableArray[5] != ecpmDb)
                {
                    Assert.Fail("ecpm not matched");
                }
                /*  if (revenuePortal != revenue)
                  {
                      Assert.Fail("revenue of an app not matched");
                  }*/

            }
            catch (Exception e)
            {
                Assert.Fail("Revenue stats not matched" + " " + e.Message);
            }
            return;
        }
        internal void FindAndCompareValuesofRevenueBottomGridNetworkWise()
        {
            try
            {
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(2000); Thread.Sleep(2000);
                var script = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[0].textContent; return text;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableArray[0] = (string)js.ExecuteScript(script);
                string AdnetworkNamePortal = AppManageTableValues.tableArray[0].TrimEnd();
                var script1 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[1].textContent;return text;";
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[1] = (string)js1.ExecuteScript(script1);
                var script2 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[2].textContent;return text;";
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[2] = (string)js2.ExecuteScript(script2);
                var script3 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[3].textContent;return text;";
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[3] = (string)js3.ExecuteScript(script3);
                var script4 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[4].textContent;return text;";
                IJavaScriptExecutor js4 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[4] = (string)js4.ExecuteScript(script4);
                string revenuePortal = AppManageTableValues.tableArray[4].Replace("$", "");
                var script5 = "var div = document.getElementsByClassName('table-scrollable'); var child= div[0].getElementsByTagName('td'); var text=child[5].textContent;return text;";
                IJavaScriptExecutor js5 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[5] = (string)js5.ExecuteScript(script5);
                string ecpmPortal = AppManageTableValues.tableArray[5].Replace("$", "");
                //Database Query
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "Revenue_Adnetwork_query_bottom_grid");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string adnetworkName = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][1].ToString());
                string impression = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][7].ToString());
                var ImpressionDb = Convert.ToDouble(impression);
                string available = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][9].ToString());
                string completed = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][6].ToString());
                string revenue = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][10].ToString());
                var Revenuedouble = Convert.ToDouble(revenue);
                var rev = Math.Round(Revenuedouble, 3);
                string revenueDb = rev.ToString();
                var ecpm = rev / ImpressionDb * 1000;
                var ecpmRoundoff = Math.Round(ecpm, 3);
                string ecpmDb = ecpmRoundoff.ToString();
                //  string ecpm = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][6].ToString());
                if (AdnetworkNamePortal != adnetworkName)
                {
                    Assert.Fail("Adnewtork not matched");
                }
                if (AppManageTableValues.tableArray[1] != impression)
                {
                    Assert.Fail("impression not matched");
                }
                if (AppManageTableValues.tableArray[2] != "N/A" || available!="")
                {
                    if (AppManageTableValues.tableArray[2] != available)
                    {
                        Assert.Fail("available not matched");
                    }
                }
                if (AppManageTableValues.tableArray[3] != "N/A" || completed!="")
                {
                    if (AppManageTableValues.tableArray[2] != completed)
                    {
                        Assert.Fail("completed not matched");
                    }
                }
                if (revenuePortal != revenueDb)
                {
                    Assert.Fail("Revenue not matched");
                }
                if (ecpmPortal != ecpmDb)
                {
                    Assert.Fail("ecpm not matched");
                }
                /*  if (revenuePortal != revenue)
                  {
                      Assert.Fail("revenue of an app not matched");
                  }*/

            }
            catch (Exception e)
            {
                Assert.Fail("Revenue stats not matched" + " " + e.Message);
            }
            return;
        }
        internal void FindAndCompareValuesofMediationOfTopGrid()
        {
            try
            {
                var script = "var div = document.getElementsByClassName('inner-total'); var text=div[0].innerText; return text;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableArray[0] = (string)js.ExecuteScript(script);
                string requestPortal = AppManageTableValues.tableArray[0].Replace(",", "");
                var script1 = "var div = document.getElementsByClassName('inner-total'); var text=div[1].innerText;return text;";
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[1] = (string)js1.ExecuteScript(script1);
                var script2 = "var div = document.getElementsByClassName('inner-total'); var text=div[2].innerText;return text;";
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)DriverProperty.driver;
                string impressionPortal = AppManageTableValues.tableArray[1].Replace(",", "");
                AppManageTableValues.tableArray[2] = (string)js2.ExecuteScript(script2);
                var script3 = "var div = document.getElementsByClassName('inner-total'); var text=div[3].innerText;return text;";
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[3] = (string)js3.ExecuteScript(script3);
                var script4 = "var div = document.getElementsByClassName('inner-total'); var text=div[4].innerText;return text;";
                IJavaScriptExecutor js4 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[4] = (string)js4.ExecuteScript(script4);
                
                //Database Query
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "Reports_Mediation_Top_grid_stats");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string Requests = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][3].ToString());
                var RequestsDb = Convert.ToDouble(Requests);
                string Impressions = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());
                var ImpressionDb = Convert.ToDouble(Impressions);
                string click = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][5].ToString());
                var clickDb = Convert.ToDouble(click);
                var fillrate = ImpressionDb / RequestsDb * 100 ;
                var fillrateroundoff = Math.Round(fillrate, 3);
                string fillrateDb = fillrateroundoff.ToString() + 0.000 + "%";
                var CTR = clickDb / ImpressionDb * 100;
                var CTRroundoff = Math.Round(CTR, 3);
                string CTRDb = CTRroundoff.ToString()+"%";
                // string revenue = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());

                if (requestPortal!= Requests)
                {
                    Assert.Fail("Requests not matched");
                }
                if (impressionPortal != Impressions)
                {
                    Assert.Fail("Impressions not matched");
                }
          /*/      if (AppManageTableValues.tableArray[2] != fillrateDb)
                {
                    Assert.Fail("fillrate not matched");
                }*/
                if (AppManageTableValues.tableArray[3] != click)
                {
                    Assert.Fail("click not matched");
                }
                if (AppManageTableValues.tableArray[4] != CTRDb)
                {
                      Assert.Fail("CTR not matched");
                }

            }
            catch (Exception e)
            {
                Assert.Fail("Mediation stats not matched" + " " + e.Message);
            }
            return;
        }
        internal void FindAndCompareValuesofMediationOfBottomGrid()
        {
            try
            {
                var script = "var div = document.getElementById('networks-table');var child= div.getElementsByTagName('td'); var text = child[0].textContent; return text;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableArray[0] = (string)js.ExecuteScript(script);
                string requestPortal = AppManageTableValues.tableArray[0].Replace(",", "");
                var script1 = "var div = document.getElementById('networks-table');var child= div.getElementsByTagName('td'); var text = child[1].textContent; return text;";
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[1] = (string)js1.ExecuteScript(script1);
                string impressionPortal = AppManageTableValues.tableArray[1].Replace(",", "");
                var script2 = "var div = document.getElementById('networks-table');var child = div.getElementsByTagName('td'); text = child[2].textContent; return text;";
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[2] = (string)js2.ExecuteScript(script2);
                var script3 = "var div = document.getElementById('networks-table');var child = div.getElementsByTagName('td'); text = child[3].textContent; return text;";
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[3] = (string)js3.ExecuteScript(script3);
                var script4 = "var div = document.getElementById('networks-table');var child = div.getElementsByTagName('td'); text = child[4].textContent; return text;";
                IJavaScriptExecutor js4 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[4] = (string)js4.ExecuteScript(script4);
                var script5 = "var div = document.getElementById('networks-table');var child = div.getElementsByTagName('td'); text = child[5].textContent; return text;";
                IJavaScriptExecutor js5 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[5] = (string)js5.ExecuteScript(script5);
                var script6 = "var div = document.getElementById('networks-table');var child = div.getElementsByTagName('td'); text = child[6].textContent; return text;";
                IJavaScriptExecutor js6 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[6] = (string)js6.ExecuteScript(script6);
                var script7 = "var div = document.getElementById('networks-table');var child = div.getElementsByTagName('td'); text = child[7].textContent; return text;";
                IJavaScriptExecutor js7 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[7] = (string)js7.ExecuteScript(script7);

                //Database Query
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "Reports_Mediation_Bottom_grid");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string Adnetwork = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][0].ToString());
                string Adtype = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][2].ToString());
                string Request = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][6].ToString());
                var RequestsDb = Convert.ToDouble(Request);
                string Impression = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][7].ToString());
                var ImpressionDb = Convert.ToDouble(Impression);
                string Click = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][8].ToString());
                var clickDb = Convert.ToDouble(Click);
                var fillrate = ImpressionDb / RequestsDb * 100;
                var fillrateroundoff = Math.Round(fillrate, 3);
                string fillrateDb = fillrateroundoff.ToString() + "%";
                var CTR = clickDb / ImpressionDb * 100;
                var CTRroundoff = Math.Round(CTR, 3);
                string CTRDb = CTRroundoff.ToString() + "%";

                if (requestPortal != Request)
                {
                    Assert.Fail("Requests not matched");
                }
                if (impressionPortal != Impression)
                {
                    Assert.Fail("Impressions not matched");
                }
                if (AppManageTableValues.tableArray[2] != fillrateDb)
                {
                    Assert.Fail("fillrate not matched");
                }
                if (AppManageTableValues.tableArray[3] != Click)
                {
                    Assert.Fail("click not matched");
                }
                if (AppManageTableValues.tableArray[4] != CTRDb)
                {
                    Assert.Fail("CTR not matched");
                }

            }
            catch (Exception e)
            {
                Assert.Fail("Mediation stats not matched" + " " + e.Message);
            }
            return;
        }
        internal void FindAndCompareValuesofAdnetworkMediationOfTopGrid()
        {
            try
            {
                var script = "var div = document.getElementsByClassName('inner-total'); var text=div[0].innerText; return text;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableArray[0] = (string)js.ExecuteScript(script);
                string requestPortal = AppManageTableValues.tableArray[0].Replace(",", "");
                var script1 = "var div = document.getElementsByClassName('inner-total'); var text=div[1].innerText;return text;";
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[1] = (string)js1.ExecuteScript(script1);
                var script2 = "var div = document.getElementsByClassName('inner-total'); var text=div[2].innerText;return text;";
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)DriverProperty.driver;
                string impressionPortal = AppManageTableValues.tableArray[1].Replace(",", "");
                AppManageTableValues.tableArray[2] = (string)js2.ExecuteScript(script2);
                var script3 = "var div = document.getElementsByClassName('inner-total'); var text=div[3].innerText;return text;";
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[3] = (string)js3.ExecuteScript(script3);
                var script4 = "var div = document.getElementsByClassName('inner-total'); var text=div[4].innerText;return text;";
                IJavaScriptExecutor js4 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[4] = (string)js4.ExecuteScript(script4);

                //Database Query
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "Reports_Mediation_Top_grid_stats");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string Requests = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][3].ToString());
                var RequestsDb = Convert.ToDouble(Requests);
                string Impressions = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());
                var ImpressionDb = Convert.ToDouble(Impressions);
                string click = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][5].ToString());
                var clickDb = Convert.ToDouble(click);
                var fillrate = ImpressionDb / RequestsDb * 100;
                var fillrateroundoff = Math.Round(fillrate, 3);
                string fillrateDb = fillrateroundoff.ToString() + 0.000 + "%";
                var CTR = clickDb / ImpressionDb * 100;
                var CTRroundoff = Math.Round(CTR, 3);
                string CTRDb = CTRroundoff.ToString() + "%";
                // string revenue = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());

                if (requestPortal != Requests)
                {
                    Assert.Fail("Requests not matched");
                }
                if (impressionPortal != Impressions)
                {
                    Assert.Fail("Impressions not matched");
                }
                /*/      if (AppManageTableValues.tableArray[2] != fillrateDb)
                      {
                          Assert.Fail("fillrate not matched");
                      }*/
                if (AppManageTableValues.tableArray[3] != click)
                {
                    Assert.Fail("click not matched");
                }
                if (AppManageTableValues.tableArray[4] != CTRDb)
                {
                    Assert.Fail("CTR not matched");
                }

            }
            catch (Exception e)
            {
                Assert.Fail("Mediation Adnetwork stats not matched" + " " + e.Message);
            }
            return;
        }
        internal void FindAndCompareValuesofAdnetworkMediationOfBottomGrid()
        { 
            try
            {
                var script = "var div = document.getElementById('example'); var child = div.getElementsByTagName('td'); text = child[1].innerText; return text;";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                AppManageTableValues.tableArray[0] = (string)js.ExecuteScript(script);
              //  string AppTitle = AppManageTableValues.tableArray[0].Replace(" ", "");
                var script1 = "var div = document.getElementById('example'); var child = div.getElementsByTagName('td'); text = child[2].innerText; return text;";
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[1] = (string)js1.ExecuteScript(script1);
                string impressionPortal = AppManageTableValues.tableArray[1].Replace(",", "");
                var script2 = "var div = document.getElementById('example'); var child = div.getElementsByTagName('td'); text = child[3].innerText; return text;";
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[2] = (string)js2.ExecuteScript(script2);
                var script3 = "var div = document.getElementById('example'); var child = div.getElementsByTagName('td'); text = child[4].innerText; return text;";
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[3] = (string)js3.ExecuteScript(script3);
                var script4 = "var div = document.getElementById('example'); var child = div.getElementsByTagName('td'); text = child[5].innerText; return text;";
                IJavaScriptExecutor js4 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[4] = (string)js4.ExecuteScript(script4);
                var script5 = "var div = document.getElementById('example'); var child = div.getElementsByTagName('td'); text = child[6].innerText; return text;";
                IJavaScriptExecutor js5 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[5] = (string)js5.ExecuteScript(script5);
                var script6 = "var div = document.getElementById('example'); var child = div.getElementsByTagName('td'); text = child[7].innerText; return text;";
                IJavaScriptExecutor js6 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[6] = (string)js6.ExecuteScript(script6);
                var script7 = "var div = document.getElementById('example'); var child = div.getElementsByTagName('td'); text = child[8].innerText; return text;";
                IJavaScriptExecutor js7 = (IJavaScriptExecutor)DriverProperty.driver;
                AppManageTableValues.tableArray[7] = (string)js7.ExecuteScript(script7);

                //Database Query
                int dataSetIndex = 1;
                Thread.Sleep(4000);
                Extension.OpenDBConnection();
                Thread.Sleep(4000);
                AppManageTableValues.queryArray[0] = ExcelUtil.ReadData(1, "Reports_Mediation_Bottom_grid");
                Extension.ExecuteQueryPortal(SqlConnectionInstance.SqlConnection, dataSetIndex);
                string AppTitle = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][3].ToString());
                string OsID = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][4].ToString());
                string SdkVersion = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][0].ToString());
                string Request = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][6].ToString());
                var RequestsDb = Convert.ToDouble(Request);
                string Impression = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][7].ToString());
                var ImpressionDb = Convert.ToDouble(Impression);
                string Click = (AppManageTableValues.dataSetPropertyFill[0].Tables[0].Rows[0][8].ToString());
                var clickDb = Convert.ToDouble(Click);
                var fillrate = ImpressionDb / RequestsDb * 100;
                var fillrateroundoff = Math.Round(fillrate, 3);
                string fillrateDb = fillrateroundoff.ToString() + "%";
                var CTR = clickDb / ImpressionDb * 100;
                var CTRroundoff = Math.Round(CTR, 3);
                string CTRDb = CTRroundoff.ToString() + "%";

                if (AppManageTableValues.tableArray[0] != AppTitle)
                {
                    Assert.Fail("Requests not matched");
                }
                if (AppManageTableValues.tableArray[2] != SdkVersion)
                {
                    Assert.Fail("SdkVersion not matched");
                }
                if (AppManageTableValues.tableArray[3] != Request)
                {
                    Assert.Fail("Request not matched");
                }
                if (AppManageTableValues.tableArray[4] != Impression)
                {
                    Assert.Fail("Impression not matched");
                }
                if (AppManageTableValues.tableArray[5] != fillrateDb)
                {
                    Assert.Fail("fillrate not matched");
                }
                if (AppManageTableValues.tableArray[6] != Click)
                {
                    Assert.Fail("Click not matched");
                }
                if (AppManageTableValues.tableArray[7] != CTRDb)
                {
                    Assert.Fail("CTR not matched");
                }

            }
            catch (Exception e)
            {
                Assert.Fail("Mediation Adnetwork stats not matched" + " " + e.Message);
            }
            return;
        }
        internal void FindAndSelectRevenueTable()
        {

            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                var table = window.FindElement(By.Id("networks-table"));
                actions.MoveToElement(table).Perform();
                var rows = table.FindElements(By.TagName("tr"));
                var cols = table.FindElements(By.TagName("td"));
                bool found = false;

                foreach (var row in rows)
                {
                    foreach (var col in cols)
                    {

                        Extension.HighLighterMethod(window, col);
                        Thread.Sleep(5000);
                        found = true;
                        MonetizationRow.RowElement = col;
                        //  actions.SendKeys(Keys.ArrowDown).Perform();
                        break;


                    }
                }
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Not Integrated Network advertising Campaign not found" + e.Message);
            }
        }
        internal void FindAndSelectIntegratedCrossPromoCampaign()
        {
            try
            {
                var script = "jQuery(\"label:contains('Yes')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign yes,no radio button not found" + e.Message);
            }
            return;
        }
        internal IWebElement FindAndClickCampaignsBrandAddNewBtn()
        {
            try
            {
                Thread.Sleep(1000);
                var script = "var div = document.getElementsByClassName('form-group'); var child = div[6].getElementsByTagName('label'); var final = child[0].getElementsByTagName('span'); var f = final[1].getElementsByTagName('a'); f[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                Assert.Fail("Campaign's Brand Add new link not found" + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickCrossCampaignsBrandAddNewBtn()
        {
            try
            {
                Thread.Sleep(1000);
                var script = "var div = document.getElementsByClassName('form-group'); var child = div[7].getElementsByTagName('label'); var final = child[0].getElementsByTagName('span'); var f = final[0].getElementsByTagName('a'); f[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                Assert.Fail("Campaign's Brand Add new link not found" + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickCampaignsBrandTitleName()
        {

            try
            {
                return window.FindElement(By.Id("brand_title"));
            }
            catch (Exception e)
            {
                Assert.Fail("Brand Title Field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickBrandSaveBtn()
        {
            try
            {

                return window.FindElement(By.XPath("//button[@id='btn-promoting-app'][@class='btn btn-primary']"));
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Ad Save Button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickBrandCloseBtn()
        {
            try
            {

                return window.FindElement(By.XPath("//button[@id='modal-content-brandTitle-close']"));
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Brand popup Close Button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickNotIntCampaignAddNewBtn()
        {
            try
                {
                  var script = "var div = document.getElementsByClassName('form-group appNameDiv'); var child = div[0].getElementsByTagName('label'); var final = child[0].getElementsByTagName('span'); var f = final[0].getElementsByTagName('a'); f[0].click();";
                  IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                  js.ExecuteScript(script);
                  Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
               }
             catch (Exception e)
                {
                    Assert.Fail("Campaign's Ad Add new link not found" + e.Message);
                }
                return null;
        }
        internal IWebElement FindAndClickNotIntAdvertisingCampaignAddNewBtn()
        {
            try
            {
                var script = "var div = document.getElementsByClassName('form-group'); var child = div[7].getElementsByTagName('label'); var final = child[0].getElementsByTagName('span'); var f = final[1].getElementsByTagName('a'); f[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign's Ad Add new link not found" + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickTitleName()
        {

            try
            {
                return window.FindElement(By.Id("adTitle"));
            }
            catch (Exception e)
            {
                Assert.Fail("AdTitle link not found" + " " + e.Message);
            }
            return null;
        }
        internal void FindAndClickAdSaveBtn()
         {
            try
            {

                var script = "jQuery(\"button:contains('Save changes')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Ad Save Button not found" + " " + e.Message);
            }
            return;
        }
        internal IWebElement FindAndClickAdOkBtn()
        {
            try
            {

                return window.FindElement(By.XPath("//button[@class='confirm btn btn-lg btn-primary']"));
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
               // Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Ad Ok Button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAdUrlToPromoteField()
        {

            try
            {
                return window.FindElement(By.XPath("//input[@id='adUrl']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Add New button not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectCampaignAttribution(String Attibution)
        {
            try
            {
                if (Attibution.Equals ("AppsFlyer"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("attribution"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("attribution")));
                    dropDown.SelectByValue("1");
                }
                if (Attibution .Equals ("Adjust"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("attribution"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("attribution")));
                    dropDown.SelectByValue("2");
                }
                if (Attibution.Equals ("Kochava"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("attribution"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("attribution")));
                    dropDown.SelectByValue("3");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Attribution field not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectCampaignPriority(String priority)
        {
            try
            {
                if (priority.Equals ("Highest"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("priority"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("priority")));
                    dropDown.SelectByValue("5");
                }
                if (priority.Equals ("High"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("priority"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("priority")));
                    dropDown.SelectByValue("4");
                }
                if (priority.Equals ("Medium"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("priority"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("priority")));
                    dropDown.SelectByValue("3");
                }
                if (priority.Equals ("Low"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("priority"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("priority")));
                    dropDown.SelectByValue("2");
                }
                if (priority.Equals ("Lowest"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("priority"));
                    SelectElement dropDown = new SelectElement(selectElement);
                   // Extension.HighLighterMethod(window, window.FindElement(By.Id("priority")));
                    dropDown.SelectByValue("1");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Priority field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndDailyImpressionsPerUserCap()
        {

            try
            {
                return window.FindElement(By.XPath("//input[@id='perUserImpCap']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Daily Impressions Per User Cap Field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndTotalImpressionsPerUserCap()
        {

            try
            {
                return window.FindElement(By.XPath("//input[@id='impressionsLimit']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Total Impressions Per User Cap Field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickCampaignClickUrl()
        {

            try
            {
                return window.FindElement(By.XPath("//input[@id='kochavaUrlLink']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Total Impressions Per User Cap Field not found" + " " + e.Message);
            }
            return null;
        }
        internal void FindAndClickCampaignSelectCategoriesBtn()
        {
            try
            {

                var script = "jQuery(\"button:contains('Select Categories')\").click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Select Categories Button not found" + " " + e.Message);
            }
            return;
        }
        internal void FindAndClickCampaignSelectCategoriesRadiobtn(string cat)
        {
            try
            {
                if (cat.Equals ("All"))
                {
                    var script = "jQuery(\"label:contains('Select All')\").click();";
                    IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                    js.ExecuteScript(script);
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                }
                if (cat.Equals ("Games"))
                {
                    var script = "jQuery(\"label:contains('Select Games')\").click();";
                    IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                    js.ExecuteScript(script);
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                }
                if (cat.Equals("Apps"))
                {
                    var script = "jQuery(\"label:contains('Select Apps')\").click();";
                    IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                    js.ExecuteScript(script);
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                    Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Select Categories Button not found" + " " + e.Message);
            }
            return;
        }
        internal IWebElement FindAndClickCampaignRegions()
        {

            try
            {
                return window.FindElement(By.CssSelector("input.select2-search__field"));
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Region Field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndSelectCrossCampaignBrands()
        {

            try
            {
                return window.FindElement(By.XPath("//input[@placeholder='All Brands']"));
                /*  var script = "var div = document.getElementsByClassName('select2-selection__rendered');var child= div[0].click();";
                  IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                  js.ExecuteScript(script);*/
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Brand Field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndSelectCrossCampaignApps()
        {

            try
            {
                return window.FindElement(By.XPath("//input[contains(@class,'select2-search__field')][@placeholder='All Applications']"));
                /*  var script = "var div = document.getElementsByClassName('select2-selection__rendered');var child= div[0].click();";
                  IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                  js.ExecuteScript(script);*/
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Brand Field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndSelectCrossCampaignScenes()
        {

            try
            {
                return window.FindElement(By.XPath("//input[contains(@class,'select2-search__field')][@placeholder='All Placeholders']"));
                /*  var script = "var div = document.getElementsByClassName('select2-selection__rendered');var child= div[0].click();";
                  IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                  js.ExecuteScript(script);*/
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Brand Field not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectCampaignIs(String Campaignis)
        {
            try
            {
                if (Campaignis.Equals("On"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("status"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                    dropDown.SelectByValue("Active");
                }
                if (Campaignis.Equals ("Off"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("status"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                    dropDown.SelectByValue("InActive");
                }
                if (Campaignis.Equals ("Paused"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("status"));
                    SelectElement dropDown = new SelectElement(selectElement);
                  //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                    dropDown.SelectByValue("Paused");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign is field not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectCampaignPromotingApps(string PromotingApps)
        {
            try
            {
                 if (PromotingApps.Equals("ABA English - Learn English"))
                 {
                     Thread.Sleep(1000);
                     var script = "var div = document.getElementsByClassName('filter-option pull-left'); div[0].click(); var child = document.getElementsByClassName('fa fa-android'); child[0].click();";
                     IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                     js.ExecuteScript(script);
                     Thread.Sleep(1000);

                 }
                 if (PromotingApps.Equals("Castle Fps"))
                 {
                     Thread.Sleep(1000);
                     var script = "var div = document.getElementsByClassName('filter-option pull-left'); div[0].click(); var child = document.getElementsByClassName('fa fa-android'); child[1].click();";
                     IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                     js.ExecuteScript(script);
                     Thread.Sleep(1000);
                 }
                 if (PromotingApps.Equals ("Modern Shooting"))
                 {
                     Thread.Sleep(1000);
                     var script = "var div = document.getElementsByClassName('filter-option pull-left'); div[0].click(); var child = document.getElementsByClassName('fa fa-android'); child[2].click();";
                     IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                     js.ExecuteScript(script);
                     Thread.Sleep(1000);
                 }
               /* IWebElement selectElement = window.FindElement(By.Id("status"));
                SelectElement dropDown = new SelectElement(selectElement);
                //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                dropDown.SelectByText(PromotingApps);*/
            }
            catch (Exception e)
            {
                Assert.Fail("Campaign Costing Type field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickLogOutBtn()
        {

            try
            {
                return window.FindElement(By.XPath("//a[@id='logout']"));
            }
            catch (Exception e)
            {
                Assert.Fail("logout button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickUserName()
        {

            try
            {
                return window.FindElement(By.XPath("//span[contains(@class, 'username username-hide-on-mobile')]"));
            }
            catch (Exception e)
            {
                Assert.Fail("User Name not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickFilterSubmitButton()
        {

            try
            {
                return window.FindElement(By.XPath("//button[@id='btn-submit']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Click Submit Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickApplybtn()
        {

            try
            {
                return window.FindElement(By.XPath("//button[@class='applyBtn btn btn-sm btn-success']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Apply Button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickImportApp()
        {

            try
            {
                return window.FindElement(By.XPath("//button[@id='importAppButton']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Apply Button not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickImportField()
        {

            try
            {
                return window.FindElement(By.Id("marketURL"));
            }
            catch (Exception e)
            {
                Assert.Fail("Click Import Field" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickImportBtn()
        {

            try
            {
                return window.FindElement(By.Id("importAppURL"));
            }
            catch (Exception e)
            {
                Assert.Fail("Click Import Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAdmobAdidsbtn()
        {

            try
            {
                var script = "var atag =document.getElementsByClassName('btn btn-primary btn-circle');atag[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click Import Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickChartboostAdidsbtn()
        {

            try
            {
                var script = "var atag =document.getElementsByClassName('btn btn-primary btn-circle');atag[1].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); 
            }
            catch (Exception e)
            {
                Assert.Fail("Click Import Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickFacebookAdidsbtn()
        {

            try
            {
                var script = "var atag = document.getElementsByClassName('btn btn-primary btn-circle');atag[2].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click Import Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndInsertDateFilterStartDate(string startdate)
        {

            try
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                var startDate = window.FindElement(By.XPath("//input[@class='input-mini form-control active']"));
                startDate.Clear();
                startDate.SendKeys(startdate);
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript("$(arguments[0]).change();", startDate);

            }
            catch (Exception e)
            {
                Assert.Fail("Date filter start date field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndInsertDateFilterEndDate(string enddate)
        {

            try
            {
                var EndDate = window.FindElement(By.XPath("//input[@class='input-mini form-control']"));
                EndDate.Clear();
                EndDate.SendKeys(enddate);
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript("$(arguments[0]).change();", EndDate);

            }
            catch (Exception e)
            {
                Assert.Fail("Date filter end date field not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement ClickAndInsertAdmobAdIds()
        {

            try
            {
             var bannerID= window.FindElement(By.XPath("//input[@id='ADFIELD1']"));
             bannerID.SendKeys("123");
             var interstitialID = window.FindElement(By.XPath("//input[@id='ADFIELD2']"));
             interstitialID.SendKeys("123");
             var RewardedID = window.FindElement(By.XPath("//input[@id='ADFIELD17']"));
             RewardedID.SendKeys("123");
             var AppID= window.FindElement(By.XPath("//input[@id='ADFIELD18']"));
             AppID.SendKeys("123");
             var NativeID = window.FindElement(By.XPath("//input[@id='ADFIELD19']"));
             NativeID.SendKeys("123");
            }
            catch (Exception e)
            {
                Assert.Fail("Banner Ad Unit ID not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement ClickAndInsertChartboostAdIds()
        {

            try
            {
                var ID = window.FindElement(By.XPath("//input[@id='ADFIELD6']"));
                ID.SendKeys("123");
                var signature = window.FindElement(By.XPath("//input[@id='ADFIELD7']"));
                signature.SendKeys("123");
               
            }
            catch (Exception e)
            {
                Assert.Fail("Chartboost ID not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement ClickAndInsertFacebookAdIds()
        {

            try
            {
               
                var interstitialID = window.FindElement(By.XPath("//input[@id='ADFIELD27']"));
                interstitialID.SendKeys("123");
                var RewardedID = window.FindElement(By.XPath("//input[@id='ADFIELD28']"));
                RewardedID.SendKeys("123");
                var bannerID = window.FindElement(By.XPath("//input[@id='ADFIELD36']"));
                bannerID.SendKeys("123");
                var NativeID = window.FindElement(By.XPath("//input[@id='ADFIELD37']"));
                NativeID.SendKeys("123");

            }
            catch (Exception e)
            {
                Assert.Fail("Banner Ad Unit ID not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickDateFilter()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('glyphicon glyphicon-calendar fa fa-calendar');div[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail(" not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAppEditBtn()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('table table-striped table-bordered table-hover dataTable no-footer'); var child = div[0].getElementsByTagName('td'); var final  = child[3].getElementsByTagName('i'); final[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Edit button of an app not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickSearchApp()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('table table-striped table-bordered table-hover dataTable no-footer'); var ch = div[0].getElementsByTagName('tr'); var fin=ch[1].getElementsByTagName('td'); var final= fin[5].getElementsByTagName('a'); final[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("App not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAdidsbtn()
        {

            try
            {
                var script = "var atag=document.getElementsByClassName('btn btn-primary btn-circle');atag[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Edit button of an app not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickDateRange()
        {

            try
            {
                var script = "var firstval= document.getElementsByClassName('table-condensed');var child = firstval[0].getElementsByTagName('td');var final= child[27].click();var secondval= document.getElementsByClassName('table-condensed');var child = secondval [1].getElementsByTagName('td'); var final = child[5]; final.click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Date range not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickChildDirectedToggle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-container'); var ch = div[0].getElementsByClassName('bootstrap-switch-handle-off bootstrap-switch-default'); ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click Import Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickCustomIconBtn()
        {

            try
            {
                var customIcon = window.FindElement(By.XPath("//input[@id='file']"));
                customIcon.SendKeys("E:\\Automation\\Monetization_Automation\\Montization_Automation\\CreativeSets\\3_2_image.png");
            }
            catch (Exception e)
            {
                Assert.Fail("Click Custom Icon Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickIsSkipAbleOnToggle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-container');var child = div[5].getElementsByClassName('bootstrap-switch-handle-off bootstrap-switch-default');child[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click Isskipable toggle Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickIsSkipAbleOffToggle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-container');var child = div[5].getElementsByClassName('bootstrap-switch-handle-on bootstrap-switch-primary');child[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click Isskipable toggle Button" + " " + e.Message);
            }
            return null;
        }
       
        internal IWebElement FindAndClickHideAdsOnToggle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-container'); var ch = div[3].getElementsByClassName('bootstrap-switch-handle-off bootstrap-switch-default'); ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click HideAds toggle button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClick()
        {

            try
            {
                var script = "var div = document.getElementsByName('first_skip');div[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail(" not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickIsHideAdsOffToggle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-container'); var ch = div[3].getElementsByClassName('bootstrap-switch-handle-on bootstrap-switch-primary'); ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click IsHideAds toggle Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickIsTestModeOnToggle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-container');var ch = div[4].getElementsByClassName('bootstrap-switch-handle-off bootstrap-switch-default');ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click Test Mode toggle Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickIsTestModeOffToggle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-container');var ch = div[4].getElementsByClassName('bootstrap-switch-handle-on bootstrap-switch-primary');ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click Test Mode toggle Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAutoMediationOnToggle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-container'); var ch = div[2].getElementsByClassName('bootstrap-switch-handle-off bootstrap-switch-default'); ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click AutoMediation toggle Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAutoMediationYesBtn()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('confirm btn btn-lg btn-primary'); div[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click AutoMediation yes Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAutoMediationOkBtn()
        {

            try
            {
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                return window.FindElement(By.XPath("//button[contains(text(),'OK')]"));
               
            }
            catch (Exception e)
            {
                Assert.Fail("Click AutoMediation Ok Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAutoMediationOffToggle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-container'); var ch = div[2].getElementsByClassName('bootstrap-switch-handle-on bootstrap-switch-primary'); ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click AutoMediation toggle Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickUploadIconBtn()
        {

            try
            {
                return window.FindElement(By.XPath("//a[@id='appCustomIcon']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Click Custom Icon Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAdnetworksTab()
        {

            try
            {
                return window.FindElement(By.XPath("//a[contains(text(),'Ad Networks')]"));
            }
            catch (Exception e)
            {
                Assert.Fail("Adnetworks Tab not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickPlaceholdersAndAdsTab()
        {

            try
            {
                return window.FindElement(By.XPath("//a[contains(text(),'Placeholders & Ads')]"));
            }
            catch (Exception e)
            {
                Assert.Fail("Adnetworks Tab not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAdNewBtnOfAdnetwork()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('button button-small'); div[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Ad New Button not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickPlaceholdersNameOfAdnetwork()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('btn btn-link no-padding'); var ch= div[0].getElementsByTagName('span'); ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Ad New Button not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickDebugLogToggle()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-container'); var ch = div[1].getElementsByClassName('bootstrap-switch-handle-off bootstrap-switch-default'); ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click Import Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickPriorityField()
        {

            try
            {
                return window.FindElement(By.XPath("//input[@class='form-control'][@min='0']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Click Priority Field" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickNewAdSaveBtn()
        {

            try
            {
                return window.FindElement(By.XPath("//form[@id='newAdForm']//button[@id='adPopupSaveButton']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Save New Ad btn Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndDeleteAdnetwork()
        {

            try
            {
                return window.FindElement(By.XPath("//span[@class='fa fa-trash-o icon-action'][@title='delete']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Delete Adnetwork btn Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickYesDeleteItBtn()
        {

            try
            {
                return window.FindElement(By.XPath("//button[contains(text(),'Yes, delete it!')]"));
            }
            catch (Exception e)
            {
                Assert.Fail("Yes Delete It button Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickSceneActionSaveButton()
        {

            try
            {
                return window.FindElement(By.XPath("//button[@id='seqPopupSaveButton']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Save button Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickNativeHeightField()
        {

            try
            {
                return window.FindElement(By.XPath("//input[@name='native_height']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Native Width field Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickNativeWidthField()
        {

            try
            {
                return window.FindElement(By.XPath("//input[@name='native_width']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Native Width field Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickEditBtnofAdnetwork()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('table table-striped table-bordered table-advance table-hover'); var ch = div[1].getElementsByTagName('a'); ch[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Edit icon Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickEditBtnofScene()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('table table-striped table-bordered table-advance table-hover green'); var ch = div[0].getElementsByTagName('a'); ch[1].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Edit icon Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickEditBtnofSceneOfIntrew()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('table table-striped table-bordered table-advance table-hover green'); var ch = div[0].getElementsByTagName('span'); ch[1].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Edit icon Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndMoveToAdnetworks()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('btn btn-primary btn-xm pull-right'); div[0].scrollIntoView();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click Import Button" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickDevPlaceholdersAndAdsBtn()
        {

            try
            {
                var script = "var div = document.getElementById('previewDevModePlaceholders');div.click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Devmode Placeholder Button Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickFirstSkipBtn()
        {

            try
            {
                var script = "var div = document.getElementsByName('first_skip');div[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Assert.Fail("Click Import Button" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectAdMechanism(String Admechanism)
        {
            try
            {
                if (Admechanism.Equals("RoundRobin"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("ads_queue_type"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                    dropDown.SelectByValue("round_robin");
                }
                if (Admechanism.Equals("Priority"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("ads_queue_type"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                    dropDown.SelectByValue("priority");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Ad Mechanism dropdown not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectAppAdType(String Adtype)
        {
            try
            {
                if (Adtype.Equals("Interstitial"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("sel_ads_type"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                    dropDown.SelectByValue("interstitial");
                }
                if (Adtype.Equals("Rewarded"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("sel_ads_type"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                    dropDown.SelectByValue("rewarded");
                }
                if (Adtype.Equals("Native"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("sel_ads_type"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                    dropDown.SelectByValue("native");
                }
                if (Adtype.Equals("Banner"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("sel_ads_type"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                    dropDown.SelectByValue("banner");
                }
                if (Adtype.Equals("Icon"))
                {
                    IWebElement selectElement = window.FindElement(By.Id("sel_ads_type"));
                    SelectElement dropDown = new SelectElement(selectElement);
                    //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                    dropDown.SelectByValue("icon");
                } 
               
            }
            catch (Exception e)
            {
                Assert.Fail("AdType dropdown not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectAdTitle()
        {
            try
            {
               /* var script = "var div = document.getElementsByClassName('btn btn-primary btn-xm pull-right'); div[0].scrollIntoView();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000);*/

                 IWebElement selectElement = window.FindElement(By.Name("adID"));
                 SelectElement dropDown = new SelectElement(selectElement);
                 dropDown.SelectByValue("57");
            }

            catch (Exception e)
            {
                Assert.Fail("Ad Mechanism dropdown not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectAdRegion(string Adregion)
        {
            try
            {

                IWebElement selectElement = window.FindElement(By.Name("countryID"));
                SelectElement dropDown = new SelectElement(selectElement);
                //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                dropDown.SelectByValue(Adregion);
            }

            catch (Exception e)
            {
                Assert.Fail("Ad Mechanism dropdown not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndClickBannerSizeDropdown(string bannersize)
        {
            try
            {

                IWebElement selectElement = window.FindElement(By.Name("banner_size_id"));
                SelectElement dropDown = new SelectElement(selectElement);
                //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                dropDown.SelectByValue(bannersize);
            }

            catch (Exception e)
            {
                Assert.Fail("Banner Size dropdown not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectFailoverAd(string Failover)
        {
            try
            {

                IWebElement selectElement = window.FindElement(By.Name("failOverAdID"));
                SelectElement dropDown = new SelectElement(selectElement);
                //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                dropDown.SelectByValue(Failover);
            }

            catch (Exception e)
            {
                Assert.Fail("Banner Size dropdown not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement SelectPositionOfBanner(string bannerposition)
        {
            try
            {

                IWebElement selectElement = window.FindElement(By.Name("banner_size_id"));
                SelectElement dropDown = new SelectElement(selectElement);
                //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                dropDown.SelectByValue(bannerposition);
            }

            catch (Exception e)
            {
                Assert.Fail("Banner Size dropdown not found" + " " + e.Message);
            }
            return null;
        }
        internal SelectElement FindAndSelectIconSize(string iconSize)
        {
            try
            {

                IWebElement selectElement = window.FindElement(By.Name("icon_size_id"));
                SelectElement dropDown = new SelectElement(selectElement);
                //  Extension.HighLighterMethod(window, window.FindElement(By.Id("status")));
                dropDown.SelectByValue(iconSize);
            }

            catch (Exception e)
            {
                Assert.Fail("Banner Size dropdown not found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickEditBtn()
        {

            try
            {
                var script = "var brandEdit = document.getElementsByClassName('fa fa-pencil');brandEdit[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000);
                //  return window.FindElement(By.XPath("//button[@id='dropdownMenu1']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Brand Edit Button Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndDeactivateBrand()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('fa fa-lock');div[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000);
                //  return window.FindElement(By.XPath("//button[@id='dropdownMenu1']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Brand Edit Button Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickEditBrandStatus()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('bootstrap-switch-handle-on bootstrap-switch-primary'); div[0].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000);
                //  return window.FindElement(By.XPath("//button[@id='dropdownMenu1']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Brand Status Toggle Button Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndDeleteUser()
        {

            try
            {
                var script = "var div = document.getElementsByClassName('fa fa-trash-o'); div[1].click();";
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                js.ExecuteScript(script);
                Thread.Sleep(1000); Thread.Sleep(1000);
                Thread.Sleep(1000); Thread.Sleep(1000);
                //  return window.FindElement(By.XPath("//button[@id='dropdownMenu1']"));
            }
            catch (Exception e)
            {
                Assert.Fail("User Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickEditBrandStatusYesBtn()
        {

            try
            {
               
                return window.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
            }
            catch (Exception e)
            {
                Assert.Fail("Brand Status Yes Button Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickAppButtonOfRevenueTab()
        {

            try
            {

                return window.FindElement(By.XPath("//label[@id='apps-btn']"));
            }
            catch (Exception e)
            {
                Assert.Fail("App Button Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickNetworkButtonOfRevenueTab()
        {

            try
            {

                return window.FindElement(By.XPath("//label[@id='networks-btn']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Network Button Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickDatesButtonOfRevenueTab()
        {

            try
            {

                return window.FindElement(By.XPath("//label[@id='networks-btn']"));
            }
            catch (Exception e)
            {
                Assert.Fail("Network Button Not Found" + " " + e.Message);
            }
            return null;
        }
        internal IWebElement FindAndClickSearchUserField()
        {

            try
            {

                return window.FindElement(By.XPath("//input[@class='form-control input-sm input-small input-inline'][@type='search']"));
            }
            catch (Exception e)
            {
                Assert.Fail("User Search Field Not Found" + " " + e.Message);
            }
            return null;
        }

        internal void SearchAppTitle(string AppName)
        {
            try
            {
                IWebElement divclass = window.FindElement(By.ClassName("table-scrollable"));
                var table = window.FindElement(By.Id("employee-grid"));
                actions.MoveToElement(table).Perform();
                var rows = table.FindElements(By.TagName("tr"));
                var cols = table.FindElements(By.TagName("td"));
                foreach (var row in rows)
                {
                    foreach (var col in cols)
                        if (col.Text.Equals(AppName))
                        {
                       //     Extension.HighLighterMethod(window, col);
                            Thread.Sleep(5000);
                            MonetizationRow.RowElement = col;
                            //  actions.SendKeys(Keys.ArrowDown).Perform();
                            break;
                        }

                }
                IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProperty.driver;
                //  
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("App not found" + " " + e.Message);
            }
            return;
        }
    }
}

