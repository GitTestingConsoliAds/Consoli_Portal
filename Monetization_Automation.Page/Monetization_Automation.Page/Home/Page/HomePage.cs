//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

using Monetization_Automation.Base;
using Monetization_Automation.Utils;
using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Monetization_Automation.Page.Home.Map;
using Monetization_Automation.Page.Home.Validator;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Selenium.Utils.Html;
using OpenQA.Selenium.Interactions;
using System.Diagnostics;
using System.Windows.Input;
using System.Threading;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Monetization_Automation.Page.Home.Page
{
    
    public class HomePage : BasePage<HomeMap,HomeValidator>
    {
       
        private IWebDriver driver;

        public HomePage()
        {         
        }
          //Company Creation
          public HomePage ClickBrand()
          {
              Thread.Sleep(2000);
              Map.FindAndClickBrand();
              return this;
          }
          public HomePage ClickNewBrandBtn()
          {
              Thread.Sleep(3000);
              Map.FindAndClickBrandBtn().Click();
              return this;
          }
          public HomePage FillBrandNameField()
          {

              Thread.Sleep(2000);
              Map.FindBrandNameField().Click();
              AppManageTableValues.SecondCompareValue = ExcelUtil.ReadData(1, "BrandTitle") + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
              Map.FindBrandNameField().SendKeys(AppManageTableValues.SecondCompareValue);
              AppManageTableValues.BrandTitle = AppManageTableValues.SecondCompareValue;
              return this;
          }
          public HomePage FillBrandDetailsField()
          {

              Thread.Sleep(2000);
              Map.FindBrandDetailsField().Click();
              Map.FindBrandDetailsField().SendKeys(ExcelUtil.ReadData(1, "BrandDetails"));

              return this;
          }
             public HomePage FillSupportemailField()
             {

                 Thread.Sleep(2000);
                 Map.FindSupportemailField().Click();
                 Map.FindSupportemailField().SendKeys(ExcelUtil.ReadData(1, "Supportemail"));
                 return this;
             }
             public HomePage FillGoogleMoreAppURLField()
             {

                 Thread.Sleep(2000);
                 Map.FindGoogleMoreAppURLField().Click();
                 Map.FindGoogleMoreAppURLField().SendKeys(ExcelUtil.ReadData(1, "GoogleMoreAppsURL"));
                 return this;
             }
             public HomePage FillAmazonMoreAppsURLField()
             {

                 Thread.Sleep(2000);
                 Map.FindAmazonMoreAppsURLField().Click();
                 Map.FindAmazonMoreAppsURLField().SendKeys(ExcelUtil.ReadData(1, "AmazonMoreAppsURL"));
                 return this;
             }
             public HomePage FillAppStoreMoreAppsURL()
             {

                 Thread.Sleep(2000);
                 Map.FindAppStoreMoreAppsURL().Click();
                 Map.FindAppStoreMoreAppsURL().SendKeys(ExcelUtil.ReadData(1, "AppStoreMoreAppsURL"));
                 return this;
             }
             public HomePage ClickSaveBtn()
             {

                 Thread.Sleep(2000);
                 Map.FindAndClickSaveBtn().Click();
                 return this;
             }
        /*  public HomePage Editbrand()
        {
            Thread.Sleep(2000);
            Map.FindAndClickEditbrand().Click();
            return this;
        }*/
         public HomePage ClickNewApp()
           {
             Thread.Sleep(2000);
             Map.FindAndClickNewApp();
             return this;
           }
         public HomePage ClickCreateManuallybtn()
         {
             Thread.Sleep(2000);
             Map.FindAndClickCreateManuallyButton();
             return this;
         }
         public HomePage ClickAppTitle()
         {
             Thread.Sleep(2000);
             Map.FindAndClickAppTitle().Click();
            AppManageTableValues.FirstCompareValue = ExcelUtil.ReadData(1, "AppTitle") + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
             Map.FindAndClickAppTitle().SendKeys(AppManageTableValues.FirstCompareValue);
            AppManageTableValues.AppTitle = AppManageTableValues.FirstCompareValue;
             return this;
         }
         public HomePage ClickPackageName()
         {
             Thread.Sleep(2000);
             Map.FindAndClickPackageName().Click();
             Map.FindAndClickPackageName().SendKeys(ExcelUtil.ReadData(1, "PackageName") + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
             return this;
         }
         public HomePage SelectPlatform(string Platform)
         {
             Thread.Sleep(2000);
             Map.FindAndSelectPlatform(Platform);
             return this;
         }
        public HomePage InsertAmazonASINORAppleID()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAmazonASINORAppleID();
            return this;
        }
        public HomePage ClickAppCreateButton()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAppCreateButton();
            return this;
        }
        public HomePage SelectAppType(string Apptype)
         {
             Thread.Sleep(2000);
             Map.FindAndSelectAppType(Apptype);
             return this;
         }
         public HomePage SelectAppCategory(string Categories)
         {
             Thread.Sleep(2000);
             Map.FindAndSelectAppCategory(Categories);
             return this;
         }
        public HomePage ClickAppNewBrandBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAppNewBrandBtn();
            return this;
        }
        /* public HomePage ClickImpotField()
          {
              Thread.Sleep(2000);
              Map.FindImportField().Click();
              Map.FindImportField().SendKeys("https://play.google.com/store/apps/details?id=com.backstreet.ambulance.car.stunts.mega.ramp&hl=en");
              return this;
          }
          public HomePage ClickImportbtn()
          {
              Thread.Sleep(2000);
              Map.FindAndClickImportButton();
              return this;
          }*/

        public HomePage ClickEnvironmentRdbtn(string environment)
            {
                Thread.Sleep(2000);
                Map.FindAndSelectEnvironment(environment);
                return this;
            }

            public HomePage SelectBrand()
            {
                Thread.Sleep(2000);
            //  Map.FindAndSelectBrand(AppManageTableValues.BrandTitle);
            Map.FindAndSelectBrand(Utils.ExcelUtil.ReadData(1, "Campaign_brandCombo"));
            return this;
            }
            public HomePage SelectAgeRating(string AgeRating)
            {
                Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
                Map.FindAndSelectAgeRating(AgeRating);
                return this;
            }
            public HomePage ClickAppSaveBtn()
            {

                Thread.Sleep(2000);
                Map.FindAndClickAppSaveBtn().Click();
                return this;
            }

        public HomePage ClickPromotesSection()
        {
            Thread.Sleep(2000);
            Map.FindAndClickPromote();
            return this;
        }
        public HomePage ClickNewCampaignBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickNewCampaigns();
            return this;
        }
        public HomePage ClickCrossCampaignis(string Campaignis)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCampaignIs(Campaignis);
            return this;
        }
        public HomePage ClickCampaignType()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCampaignType();
            return this;
        }
        public HomePage ClickCampaignNotIntegrated()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectNotIntegratedCampaign();
            return this;
        }
        public HomePage SelectCampaignAdType(String Campaign_Adtype)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectAdType(Campaign_Adtype);
            return this;
        }
        public HomePage ClickIntegratedCrossCampaignTitleField()
        {
            Thread.Sleep(2000);
            //  Map.FindAndClickCampaignTitleField().Click();
            AppManageTableValues.SecondCompareValue = ExcelUtil.ReadData(1, "CampaignTitle") + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            Map.FindAndClickCampaignTitleField().SendKeys(AppManageTableValues.SecondCompareValue);
            return this;
        }
        public HomePage ClickNotIntegratedCrossCampaignTitleField()
        {
            Thread.Sleep(2000);
            //  Map.FindAndClickCampaignTitleField().Click();
            AppManageTableValues.SecondCompareValue = ExcelUtil.ReadData(1, "CampaignTitle") + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            Map.FindAndClickCampaignTitleField().SendKeys(AppManageTableValues.SecondCompareValue);
            return this;
        }
        public HomePage ClickIntegratedNetworkCampaignTitleField()
        {
            Thread.Sleep(2000);
            //  Map.FindAndClickCampaignTitleField().Click();
            AppManageTableValues.SecondCompareValue = ExcelUtil.ReadData(1, "CampaignTitle") + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            Map.FindAndClickCampaignTitleField().SendKeys(AppManageTableValues.SecondCompareValue);
            return this;
        }
        public HomePage ClickNotIntegratedNetworkCampaignTitleField()
        {
            Thread.Sleep(2000);
            //  Map.FindAndClickCampaignTitleField().Click();
            AppManageTableValues.SecondCompareValue = ExcelUtil.ReadData(1, "CampaignTitle") + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            Map.FindAndClickCampaignTitleField().SendKeys(AppManageTableValues.SecondCompareValue);
            return this;
        }
        public HomePage ClickCampaignBrandField(String Campaign_brand)
        {
            Thread.Sleep(2000);
            Map.FindAndClickCampaignBrandField(Campaign_brand);
            return this;
        }
        public HomePage ClickCampaignAdName()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectAdName();
            return this;
        }
        public HomePage ClickNewBtnofCreatives()
        {
            Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindAndClickNewbtnofCreatives();
            return this;
        }
        public HomePage ClickCreativeNameField()
        {
            Thread.Sleep(2000);
            Map.FindAndClickCreativeName();
            Map.FindAndClickCreativeName().SendKeys(ExcelUtil.ReadData(1, "Campaign_creatives"));
            return this;
        }
        public HomePage ClickChooseCreatives(string Campaign_Adtype)
        {
            Thread.Sleep(2000);
             Map.FindAndClickChooseImage(Campaign_Adtype);
            return this;
        }
        public HomePage ClickCampaigncreativeSaveBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickCreativeSaveBtn().Click();
            return this;
        }
        public HomePage ClickCreativeCloseBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickCreativeCloseBtn();
            return this;
        }
        public HomePage ClickCampaignPlatform(String Campaign_Platform)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCampaignPlatform(Campaign_Platform);
            return this;
        }
        public HomePage ClickCampaignPublishIn(String PublishIn)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCampaignPublishIn(PublishIn);
            return this;
        }
        public HomePage SelectCrossCampaignBrands()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCrossCampaignBrands().SendKeys(ExcelUtil.ReadData(1, "Campaign_brandCombo"));
            Map.FindAndSelectCrossCampaignBrands().SendKeys(Keys.Enter);
            return this;
        }
        public HomePage SelectCrossCampaignApps()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCrossCampaignApps().SendKeys(ExcelUtil.ReadData(1, "Campaign_App"));
            Map.FindAndSelectCrossCampaignApps().SendKeys(Keys.Enter);
            return this;
        }
        public HomePage ScrollToSave()
        {
            Thread.Sleep(2000);
            Map.FindAndScrollToSaveBtn();
            return this;
        }
        public HomePage ClickCampaignSaveBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickCampaignSaveBtn().Click();
            return this;
        }
        public HomePage ClickAdidSaveBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAdidSaveBtn().Click();
            return this;
        }
        public HomePage ClickAdidCloseBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAdidCloseBtn().Click();
            return this;
        }
        public HomePage ClickNotIntCampaignSaveBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickNonIntCampaignSaveBtn();
            return this;
        }
        public HomePage selectCreativeSet(string Creativename)
        {
            Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindAndSelectCampaignCreatives(Creativename);
            return this;
        }
        public HomePage selectNetworkCampaignRadioBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectNetworkCampaignType();
            return this;
        }
        public HomePage selectNetworkCampaignNoBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectNotIntegratedNetwortCampaign();
            return this;
        }
        public HomePage SelectCampaignPricingType(string Campaign_PricingType)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCampaignCostingType(Campaign_PricingType);
            return this;
        }
        public HomePage ClickDailyBudget()
        {
            Thread.Sleep(2000);
            Map.FindAndClickDailyBudget().Click();
            Map.FindAndClickDailyBudget().SendKeys(ExcelUtil.ReadData(1, "Campaign_DailyBudget"));
            return this;
        }
        public HomePage ClickTotalBudget()
        {
            Thread.Sleep(2000);
            Map.FindAndClickTotalBudget().Click();
            Map.FindAndClickTotalBudget().SendKeys(ExcelUtil.ReadData(1, "Campaign_TotalBudget"));
            return this;
        }
      
        public HomePage ClickCampaignPromotingField()
        {
            Thread.Sleep(2000);
            Map.FindAndClickPromotingField();
            return this;
        }
        public HomePage ClickBidField()
        {
            Thread.Sleep(2000);
            Map.FindAndClickBid().Click();
            Map.FindAndClickBid().SendKeys(ExcelUtil.ReadData(1, "Campaign_Bid"));
            return this;
        }
        public HomePage ClickNetworkIntegratedCampaign()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectNetworkIntegratedCampaign();
            return this;
        }
        public HomePage ValidateApp()
        {


            Map.FindAndValidateApp();
              //char[] charsToTrim = {' ','\t' };
             /* var app = AppName.Replace("\r", "").Replace("\n", "");
             // var RmvSpaces = app.Trim(charsToTrim);
             // var app = Regex.Replace(AppName, "\r\n")[1];
              Validator.AssertApp(app);*/
            Thread.Sleep(2000);
            
            Validator.AssertBrand("App title");

            return this;
        }
        public HomePage ClickApps()
        {
            Thread.Sleep(2000);
            Map.FindAndClickApps().Click();
            return this;
        }
          public HomePage clickAppsManagement()
        {

            Thread.Sleep(2000);
            Map.FindAndClickAppsManagement();
            return this;
        }
        public HomePage SearchRequiredApplication()
        {
            Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindRequiredApplicationSearchField().SendKeys(AppManageTableValues.FirstCompareValue); 
            return this;
        }
        public HomePage SearchRequiredApplicationForStats()
        {
            Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindRequiredApplicationSearchField().SendKeys(ExcelUtil.ReadData(1, "searchappforstats"));
            return this;
        }
        public HomePage SearchRequiredApplicationtoEdit()
        {
            Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindRequiredApplicationSearchField().SendKeys("Police Robot Car Rampage");
            return this;
        }
        public HomePage SelectApplication()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectApplication(ExcelUtil.ReadData(1, "searchappforstats"));
            return this;
        }
        public HomePage ClickPlaceholdersAndAds()
        {
            Thread.Sleep(2000);
            Map.FindAndClickPlaceholdersAndAds().Click();
            return this;
        }
        
        public HomePage ClickAdFilter()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAdFilter().Click();
           
            return this;
        }

        public HomePage SelectAddNetwork()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectAddNetwork(Convert.ToInt32(ExcelUtil.ReadData(1, "AdNetworkName")));
            return this;
        }

        public HomePage ClickMediatoinTab()
        {
            Thread.Sleep(2000);
            Map.FindAndClickMediatoinTab().Click();
            return this;
        }
        

        public HomePage SelectShowAdMechanism()
        {
            Thread.Sleep(2000);
            Map.FindSelectShowAdMechanism(Convert.ToInt32(ExcelUtil.ReadData(1, "ShowAdMechanism")));
            return this;
        }

     /*   public HomePage SelectAdType()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectAdType(Convert.ToInt32(ExcelUtil.ReadData(1, "AdType")));
            return this;
        }*/
        

        public HomePage SelectAdContentCheckBox()
        {
            Thread.Sleep(2000);
            if (Map.FindAndSelectAdContentCheckBox().Selected == false)
            {
                Map.FindAndSelectAdContentCheckBox().Click();
            }
            return this;
        }

        public HomePage ClickSaveButton()
        {
            Map.FindAndClickSaveButton();
            Map.FindAndClickSaveButton();
            return this;
        }
        
        public HomePage ClickAdNework()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAdNework().Click();
            return this;
        }
        public HomePage SearchCrossIntCampaign()
        {
            Thread.Sleep(3000); Thread.Sleep(3000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindCrossPromotionCampaignSearchField().SendKeys(AppManageTableValues.SecondCompareValue);
            return this;
        }
        public HomePage SearchCrossNotIntCampaign()
        {
            Thread.Sleep(3000); Thread.Sleep(3000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindCrossPromotionCampaignSearchField().SendKeys(AppManageTableValues.SecondCompareValue);
            return this;
        }
        public HomePage SearchNetworkIntCampaign()
        {
            Thread.Sleep(3000); Thread.Sleep(3000); Thread.Sleep(3000); Thread.Sleep(3000);
            Map.FindCrossPromotionCampaignSearchField().SendKeys(AppManageTableValues.SecondCompareValue);
            return this;
        }
        public HomePage SearchNetworkNotIntCampaign()
        {
            Thread.Sleep(3000); Thread.Sleep(3000); Thread.Sleep(3000); Thread.Sleep(3000);
            Map.FindCrossPromotionCampaignSearchField().SendKeys(AppManageTableValues.SecondCompareValue);
            return this;
        }
        public HomePage ValidateCrossIntegratedCampaign()
        {
            //  var CrossPromo = Map.FindAndValidateCrossCampaignType().Text;
            //char[] charsToTrim = {' ','\t' };
            Map.FindAndSelectCrossNotIntegratedCampaign();
            Validator.AssertCampaign("campaign title");
            
            // var RmvSpaces = app.Trim(charsToTrim);
            // var app = Regex.Replace(AppName, "\r\n")[1];
            // Validator.AssertCampaign(CrossPromo);
            return this; 
        }
        public HomePage ValidateCrossNotIntegratedCampaign()
        {
            //  var CrossPromo = Map.FindAndValidateCrossCampaignType().Text;
            //char[] charsToTrim = {' ','\t' };
            Map.FindAndSelectCrossNotIntegratedCampaign();

            // var RmvSpaces = app.Trim(charsToTrim);
            // var app = Regex.Replace(AppName, "\r\n")[1];
            // Validator.AssertCampaign(CrossPromo);
            Validator.AssertCampaign("campaign title");
            return this;
        }
        public HomePage ValidateNetworkIntegratedCampaign()
        {
            //  var CrossPromo = Map.FindAndValidateCrossCampaignType().Text;
            //char[] charsToTrim = {' ','\t' };
            Map.FindAndSelectNetworkIntegratedCampaigntitle();

            // var RmvSpaces = app.Trim(charsToTrim);
            // var app = Regex.Replace(AppName, "\r\n")[1];
            // Validator.AssertCampaign(CrossPromo);
            Validator.AssertCampaign("Int Network Adverting");
            return this;
        }
        public HomePage ValidateNetworkNotIntegratedCampaign()
        {
            //  var CrossPromo = Map.FindAndValidateCrossCampaignType().Text;
            //char[] charsToTrim = {' ','\t' };
            Map.FindAndSelectNetworkIntegratedCampaigntitle();

            // var RmvSpaces = app.Trim(charsToTrim);
            // var app = Regex.Replace(AppName, "\r\n")[1];
             Validator.AssertCampaign("Non Int Network Adverting");
            return this;
        }
        public HomePage SearchBrand()
        {
            Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindAndSearchBrand().SendKeys(AppManageTableValues.SecondCompareValue);
            return this;
        }
        public HomePage SearchBrandTitle()
        {
            Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindAndSearchBrand().SendKeys(Utils.ExcelUtil.ReadData(1, "searchBrand"));
            return this;
        }
        public HomePage ValidateBrand()
        {
            Thread.Sleep(2000);
            Map.SearchBrandTitle(AppManageTableValues.BrandTitle);
            return this;
        }
        public HomePage ValidateBrandtitle()
        {
            Thread.Sleep(2000);
            Map.SearchBrandName();
            Validator.AssertBrand("Brand Title");
            return this;
        }
        /* public HomePage ValidateNetworkNotIntegratedCampaign()
         {
             Map.FindAndSelectNetworkNotIntegratedCampaign(ExcelUtil.ReadData(1, "validateCampaign"));
             return this;
         }*/
        public HomePage ClickUsersLink()
        {
            Map.FindAndClickUsersLink();
            return this;
        }
        public HomePage ClickNewUserBtn()
        {
            Map.FindAndClickNewUserBtn().Click();
            return this;
        }
        public HomePage ClickUserRole(string userrole)
        {
            Map.FindAndSelectUserRole(userrole);
            return this;
        }
        public HomePage ClickUsersFullName()
        {
            Map.FindAndClickUserFullNameField().SendKeys(ExcelUtil.ReadData(1, "User_username") + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            return this;
        }
        public HomePage ClickUserEmail()
        {
            Map.FindAndClickUsersEmail().SendKeys(ExcelUtil.ReadData(1, "User_UserEmail"));
            return this;
        }
        public HomePage ClickUsersBrandField(String brand)
        {
            Map.FindAndSelectUsersBrands(brand);
            return this;
        }
        public HomePage ClickUsersSaveBtn()
        {
            Map.FindAndClickUsersSaveBtn();
            return this;
        }
        public HomePage CompareStatsofAnApp()
        {
            Map.FindAndCompareStatsofApps();
            return this;
        }
        public HomePage ClickRevenueLink()
        {
            Map.FindAndClickRevenueLink();
            return this;
        }
        public HomePage CompareTopGridStats()
        {
            Map.FindAndCompareValuesofRevenueTopGrid();
            return this;
        }
        public HomePage CompareBottomGridAppWiseStats()
        {
            Map.FindAndCompareValuesofRevenueBottomGridAppWise();
            return this;
        }
        public HomePage CompareBottomGridDateWiseStats()
        {
            Map.FindAndCompareValuesofRevenueBottomGridDateWise();
            return this;
        }
        public HomePage CompareBottomGridNetworkWiseStats()
        {
            Map.FindAndCompareValuesofRevenueBottomGridNetworkWise();
            return this;
        }
        public HomePage ClickAppButtonOfRevenueTab()
        {
            Map.FindAndClickAppButtonOfRevenueTab().Click();
            return this;
        }
        public HomePage ClickNetworkButtonOfRevenueTab()
        {
            Map.FindAndClickNetworkButtonOfRevenueTab().Click();
            return this;
        }
        public HomePage ClickDateButtonOfRevenueTab()
        {
            Map.FindAndClickDatesButtonOfRevenueTab().Click();
            return this;
        }
        public HomePage ClickIntegratedCrosspromoCampaign()
        {
            Map.FindAndSelectIntegratedCrossPromoCampaign();
            return this;
        }
        public HomePage ClickManageTab()
        {
            Thread.Sleep(2000);
            Map.FindAndClickManageTab();
            return this;
        }
        public HomePage ClickNotIntCampaignBrandAddNewBtn()
        {
            Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindAndClickCampaignsBrandAddNewBtn();
            //Map.FindAndClickNotIntCampaignAddNewBtn().SendKeys(ExcelUtil.ReadData(1, "Campaign_Add New") + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            return this;
        }
        public HomePage ClickNotIntCrossCampaignBrandAddNewBtn()
        {
            Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000); Thread.Sleep(1000);
            Map.FindAndClickCrossCampaignsBrandAddNewBtn();
            //Map.FindAndClickNotIntCampaignAddNewBtn().SendKeys(ExcelUtil.ReadData(1, "Campaign_Add New") + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            return this;
        }

        public HomePage InsertCampaignBrandTitleName()
        {
            Thread.Sleep(1000); Thread.Sleep(2000); 
            Map.FindAndClickCampaignsBrandTitleName().Click();
            Map.FindAndClickCampaignsBrandTitleName().SendKeys(ExcelUtil.ReadData(1, "Campaign_brands_AddNew") + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            return this;
        }
        public HomePage ClickCampaignBrandSaveBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickBrandSaveBtn();
            return this;
        }
        public HomePage ClickCampaignBrandCloseBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickBrandCloseBtn();
            return this;
        }
        public HomePage ClickNotIntCampaignAdAddNewBtn()
        {
            Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindAndClickNotIntCampaignAddNewBtn();
            //Map.FindAndClickCampaignsBrandAddNewBtn().SendKeys(ExcelUtil.ReadData(1, "Campaign_Add New") + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            return this;
        }
        public HomePage ClickNotIntAdvertisingCampaignAdAddNewBtn()
        {
            Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindAndClickNotIntAdvertisingCampaignAddNewBtn();
            //Map.FindAndClickCampaignsBrandAddNewBtn().SendKeys(ExcelUtil.ReadData(1, "Campaign_Add New") + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            return this;
        }

        public HomePage InsertCampaignAdTitleName()
        {
            Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindAndClickTitleName().Click();
            Map.FindAndClickTitleName().SendKeys(ExcelUtil.ReadData(1, "Campaign_Add New") + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            return this;
        }
        public HomePage ClickCampaignAdSaveBtn()
        {
            Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000); Thread.Sleep(2000);
            Map.FindAndClickAdSaveBtn();
            return this;
        }
        public HomePage ClickCampaignAdOkBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAdOkBtn();
            return this;
        }
        public HomePage ClickCampaignAdUrl()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAdUrlToPromoteField().Click();
            Map.FindAndClickAdUrlToPromoteField().SendKeys(ExcelUtil.ReadData(1, "Campaign_URL_to_Promote"));
            return this;
        }
        public HomePage SelectCampaignAttribution(string Attribution)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCampaignAttribution(Attribution);
            return this;
         }
        public HomePage SelectCampaignPriority(string Priority)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCampaignPriority(Priority);
            return this;
        }
        public HomePage SelectCampaignDailyImpressionPerUserCap()
        {
            Thread.Sleep(2000);
            Map.FindAndDailyImpressionsPerUserCap().SendKeys(ExcelUtil.ReadData(1, "Campaign_Daily_Impressions")); 
            return this;
            
        }
        public HomePage SelectCampaignTotalImpressionPerUserCap()
        {
            Thread.Sleep(2000);
            Map.FindAndTotalImpressionsPerUserCap().SendKeys(ExcelUtil.ReadData(1, "Campaign_User_impressions")); 
            return this;
        }
        public HomePage SelectCampaignClickUrl()
        {
            Thread.Sleep(2000);
            Map.FindAndClickCampaignClickUrl().SendKeys(ExcelUtil.ReadData(1, "Campaign_Click_Url"));
            return this;
        }
        public HomePage ClickCampaignSelectCategoriesBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickCampaignSelectCategoriesBtn();
            return this;
        }
        public HomePage SelectCampaignCategories(string cat)
        {
            Thread.Sleep(2000);
            Map.FindAndClickCampaignSelectCategoriesRadiobtn(cat);
            return this;
        }
        public HomePage SelectCampaignRegions()
        {
            Thread.Sleep(2000);
           // Map.FindAndClickCampaignRegions().Click();
            Map.FindAndClickCampaignRegions().SendKeys(ExcelUtil.ReadData(1, "Campaign_Region"));
            Map.FindAndClickCampaignRegions().SendKeys(Keys.Enter);
            return this;
        }
        public HomePage SelectCrossCampaignScenes()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCrossCampaignScenes().SendKeys(ExcelUtil.ReadData(1, "Campaign_Scene"));
            Map.FindAndSelectCrossCampaignScenes().SendKeys(Keys.Enter);
            return this;
        }
        public HomePage SelectCampaignPromotingApp(string PromotingApp)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectCampaignPromotingApps(PromotingApp);
            return this;
        }
        public HomePage ValidateAppName()
        {
            Thread.Sleep(2000);
            Map.SearchAppTitle(AppManageTableValues.AppTitle);
            return this;
        }
        public HomePage ClickLogOutButton()
        {
            Thread.Sleep(2000);
            Map.FindAndClickLogOutBtn().Click();
            return this;
        }
        public HomePage ClickUserName()
        {
            Thread.Sleep(2000);
            Map.FindAndClickUserName().Click();
            return this;
        }
        public HomePage ClickDateFilter()
        {
            Thread.Sleep(2000);
            Map.FindAndClickDateFilter();
            return this;
        }
        public HomePage ClickFilterSubmitBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickFilterSubmitButton().Click();
            return this;
        }
        public HomePage ClickApplyBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickApplybtn().Click();
            return this;
        }
        public HomePage SelectDateRange()
        {
            Thread.Sleep(2000);
            Map.FindAndClickDateRange();
            return this;
        }
        public HomePage ClickImportField()
        {
            Thread.Sleep(2000);
            Map.FindAndClickImportField().Click();
            Map.FindAndClickImportField().SendKeys("https://play.google.com/store/apps/details?id=com.Struct9.BarKeep");
            return this;
        }
        public HomePage comparestats()
        {
            Thread.Sleep(2000);
            Map.Comparestats();
            return this;
        }
        public HomePage ClickImportBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickImportBtn().Click();
            return this;
        }
        public HomePage ClickAppEditField()
        {
            Thread.Sleep(2000);
             Map.FindAndClickAppEditBtn();
            return this;
        }
        public HomePage ClickAdmobAdidsBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAdmobAdidsbtn();
            return this;
        }
        public HomePage ClickChartboostAdidsBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickChartboostAdidsbtn();
            return this;
        }
        public HomePage ClickFacebookAdidsBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickFacebookAdidsbtn();
            return this;
        }
        public HomePage ClickStartdatefilter(string startdate)
        {
            Thread.Sleep(2000);
            Map.FindAndInsertDateFilterStartDate(startdate);
            return this;
        }
        public HomePage ClickEnddatefilter(string enddate)
        {
            Thread.Sleep(2000);
            Map.FindAndInsertDateFilterEndDate(enddate);
            return this;
        }
        public HomePage InsertAdmobAdIds()
        {
            Thread.Sleep(2000);
            Map.ClickAndInsertAdmobAdIds();
            return this;
        }
        public HomePage InsertChartboostAdIds()
        {
            Thread.Sleep(2000);
            Map.ClickAndInsertChartboostAdIds();
            return this;
        }
        public HomePage InsertFacebookAdIds()
        {
            Thread.Sleep(2000);
            Map.ClickAndInsertFacebookAdIds();
            return this;
        }
        public HomePage ClickSearchedApp()
        {
            Thread.Sleep(2000);
            Map.FindAndClickSearchApp();
            return this;
        }
        public HomePage ImportApp()
        {
            Thread.Sleep(2000);
            Map.FindAndClickImportApp().Click();
            return this;
        }
        public HomePage ClickChildDirectedToggle()
        {
            Thread.Sleep(2000);
            Map.FindAndClickChildDirectedToggle();
            return this;
        }
      
        public HomePage ClickDebugDirectedToggle()
        {
            Thread.Sleep(2000);
            Map.FindAndClickDebugLogToggle();
            return this;
        }
        public HomePage ClickIsSkipAbleOnToggle()
        {
            Thread.Sleep(2000);
            Map.FindAndClickIsSkipAbleOnToggle();
            return this;
        }
        public HomePage ClickIsSkipAbleOffToggle()
        {
            Thread.Sleep(2000);
            Map.FindAndClickIsSkipAbleOffToggle();
            return this;
        }
        public HomePage ClickHideAdsOnToggle()
        {
            Thread.Sleep(2000);
            Map.FindAndClickHideAdsOnToggle();
            return this;
        }
        public HomePage ClickHideAdsOffToggle()
        {
            Thread.Sleep(2000);
            Map.FindAndClickIsHideAdsOffToggle();
            return this;
        }
        public HomePage ClickTestModeOnToggle()
        {
            Thread.Sleep(2000);
            Map.FindAndClickIsTestModeOnToggle();
            return this;
        }
        public HomePage ClickTestModeOffToggle()
        {
            Thread.Sleep(2000);
            Map.FindAndClickIsTestModeOffToggle();
            return this;
        }
        public HomePage ClickAutoMediationOnToggle()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAutoMediationOnToggle();
            return this;
        }
        public HomePage ClickAutoMediationYesBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAutoMediationYesBtn();
            return this;
        }
        public HomePage ClickAutoMediationOkBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAutoMediationOkBtn().Click();
            return this;
        }
        public HomePage ClickAutoMediationOffToggle()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAutoMediationOffToggle();
            return this;
        }
        public HomePage SelectAdMechanism(string Admechanism)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectAdMechanism(Admechanism);
            return this;
        }
        public HomePage SelectAppAdType(string adType)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectAppAdType(adType);
            return this;
        }
        public HomePage MoveToAdnetworks()
        {
            Thread.Sleep(2000);
            Map.FindAndMoveToAdnetworks();
            return this;
        }
        public HomePage ClickAppCustomIcon()
        {
            Thread.Sleep(2000);
            Map.FindAndClickCustomIconBtn();
            return this;
        }
        public HomePage ClickAppUploadIcon()
        {
            Thread.Sleep(2000);
            Map.FindAndClickUploadIconBtn().Click(); ;
            return this;
        }
        public HomePage ClickAdnetworksTab()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAdnetworksTab().Click(); 
            return this;
        }
        public HomePage ClickPlaceholdersAddAdsTab()
        {
            Thread.Sleep(2000);
            Map.FindAndClickPlaceholdersAndAdsTab().Click();
            return this;
        }
        public HomePage ClickNewAdBtnOfAdnetwork()
        {
            Thread.Sleep(2000);
            Map.FindAndClickAdNewBtnOfAdnetwork();
            return this;
        }
        public HomePage ClickPlaceholderNameOFAdnetwork()
        {
            Thread.Sleep(2000);
            Map.FindAndClickPlaceholdersNameOfAdnetwork();
            return this;
        }
        public HomePage SelectAdTitleField()
        {
            Thread.Sleep(2000);
            Map.FindAndSelectAdTitle();
            return this;
        }
        public HomePage SelectAdRegionField(string adregion)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectAdRegion(adregion);
            return this;
        }
        public HomePage InsertPriorityValue()
        {
            Thread.Sleep(2000);
            Map.FindAndClickPriorityField().SendKeys("3");
            return this;
        }
        public HomePage ClickNewAdSaveBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickNewAdSaveBtn().Click();
            return this;
        }
        public HomePage DeleteAdnetwork()
        {
            Thread.Sleep(2000);
            Map.FindAndDeleteAdnetwork().Click();
            return this;
        }
        public HomePage ClickYesDeleteItBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickYesDeleteItBtn().Click();
            return this;
        }
        public HomePage ClickEditBtnOfAdnetwork()
        {
            Thread.Sleep(2000);
            Map.FindAndClickEditBtnofAdnetwork();
            return this;
        }
        public HomePage ClickEditBtnOfScene()
        {
            Thread.Sleep(2000);
            Map.FindAndClickEditBtnofScene();
            return this;
        }
        public HomePage SelectSizeOfBanner(string bannersize)
        {
            Thread.Sleep(2000);
            Map.FindAndClickBannerSizeDropdown(bannersize);
            return this;
        }
        public HomePage SelectPositionOfBanner(string bannerposition)
        {
            Thread.Sleep(2000);
            Map.FindAndClickBannerSizeDropdown(bannerposition);
            return this;
        }
        public HomePage SelectFailOverAd(string Failover)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectFailoverAd(Failover);
            return this;
        }
        public HomePage SelectSceneActionSaveBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickSceneActionSaveButton().Click();
            return this;
        }
        public HomePage ClickNativeHeightField()
        {
            Thread.Sleep(2000);
            Map.FindAndClickNativeHeightField().SendKeys("300");
            return this;
        }
        public HomePage ClickNativeWidthField()
        {
            Thread.Sleep(2000);
            Map.FindAndClickNativeWidthField().SendKeys("200");
            return this;
        }
        public HomePage ClickFirstSkipBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickFirstSkipBtn();
            return this;
        }
        public HomePage SelectIconSize(string iconSize)
        {
            Thread.Sleep(2000);
            Map.FindAndSelectIconSize(iconSize);
            return this;
        }
        public HomePage ClickEditBtnOfSceneOFInterstitial()
        {
            Thread.Sleep(2000);
            Map.FindAndClickEditBtnofSceneOfIntrew();
            return this;
        }
        public HomePage ClickDevPlaceHoldersAndAdsBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickDevPlaceholdersAndAdsBtn();
            return this;
        }
        public HomePage DeleteUser()
        {
            Thread.Sleep(2000);
            Map.FindAndDeleteUser();
            return this;
        }
        public HomePage EditBTn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickEditBtn();
            return this;
        }
        public HomePage DeactivateBrand()
        {
            Thread.Sleep(2000);
            Map.FindAndDeactivateBrand();
            return this;
        }
        public HomePage ClickBrandStatus()
        {
            Thread.Sleep(2000);
            Map.FindAndClickEditBrandStatus();
            return this;
        }
        public HomePage ClickBrandStatusYesBtn()
        {
            Thread.Sleep(2000);
            Map.FindAndClickEditBrandStatusYesBtn().Click();
            return this;
        }
        public HomePage SeachUser()
        {
            Thread.Sleep(2000);
            Map.FindAndClickSearchUserField().SendKeys("Anwar");
            return this;
        }
        /*  public HomePage CompareAppsstats()
          {
              Map.Comparestats();
              return this;
          }*/
        /// <summary>
        /// Click order products hyperlink.
        /// </summary>
        /// <param></param>
        /// <returns></returns>

    }
}
