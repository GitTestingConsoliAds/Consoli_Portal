//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

//usings...........
using System.IO;
using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using System.Threading;
using Monetization_Automation.Page.Login.Page;
using Monetization_Automation.Page.Home.Page;
using Monetization_Automation.Page.LoginWindows.Module;
using Monetization_Automation.Utils;
using Monetization_Automation;
using Monetization_Automation.Page.Login.Map;
using Monetization_Automation.Page.LoginWindows.Map;
using Monetization_Automation.Page.LoginWindows.Validator;
using Monetization_Automation.Page.Home.Map;
using Monetization_Automation.Page.Home.Validator;
using Monetization_Automation.Base;
using Monetization_Automation.Page.Login.Validator;
using PageFactory = Monetization_Automation.Base.PageFactory;

namespace Monetization_Automation.Test
{
    [TestClass]
    public class Monetization
    {
        static LoginPage loginPageMonetization = null;
        static HomePage homePageMonetization = null;
        static ModulePage LoginWindows = null;

        public Monetization()
        {
            try
            {
                if (ExcelUtil._dataCollection.Count == 0)
                {
                    DirectoryInfo directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
                    if (directoryInfo != null)
                    {
                        if (directoryInfo.Parent != null)
                        {
                            ExcelUtil.PopulateInCollection(@"E:\Automation\Automation_Data\Automation_Data.xlsx", "Sheeda");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Excel file is not loaded successfully" + " " + e.Message);
            }
        }
        /// <summary>
        /// Login test method to site.
        /// </summary>
        /// 
        /* public void Create_Cross_Promoation_Campaign_Scenario()
         { }*/


        [TestMethod]
        public void C_BS_Monetization_stats_Publisher_side()
        {
            Monetization_App_Management();
            TS_Monetization_App_Manage_Apps_stats();
            TS_Monetization_App_AdsStats();
            TS_Monetization_App_Logout();
        }

        public void TS_Monetize_Dynamic_filter_App()
        {
            homePageMonetization.ClickDateFilter();
            homePageMonetization.ClickStartdatefilter(Utils.ExcelUtil.ReadData(1, "StartDate"));
            homePageMonetization.ClickEnddatefilterApp(Utils.ExcelUtil.ReadData(1, "EndDate"));
            homePageMonetization.ClickApplyBtnApp();
            homePageMonetization.ClickFilterSubmitBtn();
        }

        public void TS_Monetization_App_AdsStats()
        {
            homePageMonetization.ClickManageTab();
            homePageMonetization.SearchRequiredApplicationForStats();
            homePageMonetization.ClickSearchedApp();
            Extension.CaptureScreenShot("SearchedApp");
            homePageMonetization.ClickAppAdsStatsTab();
            Extension.CaptureScreenShot("AppAdsStatsTab");
            TS_Monetize_Dynamic_filter_App();
            homePageMonetization.SearchRequiredScene();
            homePageMonetization.CompareStatsOfAnAppAdsStatsTab();
            homePageMonetization.SearchRequiredAdnetwork();
            homePageMonetization.CompareStatsOfAnAppAdnetworkStats();
        }

        public void TS_Login_Monetization()
         {
            loginPageMonetization = PageFactory.Create<LoginPage, LoginMap, LoginValidator>(null, false, false, true, false);
            loginPageMonetization.NavigateUrl(Utils.ExcelUtil.ReadData(1, "URL"));
            Extension.CaptureScreenShot("1_LoginScreen");
              loginPageMonetization.EnterUserId();
              loginPageMonetization.EnterPassword();
              loginPageMonetization.ClickSubmitButton();
            Extension.CaptureScreenShot("2_SuccessfullyLoggedinHomeWindow");
          }

        //Navigation and opening application
       
        public void Monetization_App_Management()
        {
            TS_Login_Monetization();
            homePageMonetization = PageFactory.Create<HomePage, HomeMap, HomeValidator>(null, false, true, false);
        }
            
            public void TS_Monetization_Brand_Creation()
            {
           
            //BRAND CREATION:
                homePageMonetization.ClickBrand();
                homePageMonetization.ClickNewBrandBtn();
                homePageMonetization.FillBrandNameField();
                homePageMonetization.FillBrandDetailsField();
                homePageMonetization.FillSupportemailField();
                homePageMonetization.FillGoogleMoreAppURLField();
                homePageMonetization.FillAmazonMoreAppsURLField();
                homePageMonetization.FillAppStoreMoreAppsURL();
                homePageMonetization.ClickSaveBtn();
                homePageMonetization.ClickBrand();
                homePageMonetization.SearchBrand();
                homePageMonetization.ValidateBrandtitle();
            }
   
        public void TS_Monetization_EditBrand()
        {
            Monetization_App_Management();
            homePageMonetization.ClickBrand();
            homePageMonetization.SearchBrandTitle();
            homePageMonetization.EditBTn();
            homePageMonetization.FillBrandDetailsField();
            homePageMonetization.FillSupportemailField();
            homePageMonetization.FillGoogleMoreAppURLField();
            homePageMonetization.FillAmazonMoreAppsURLField();
            homePageMonetization.FillAppStoreMoreAppsURL();
            homePageMonetization.ClickBrandStatus();
            homePageMonetization.ClickBrandStatusYesBtn();
            homePageMonetization.ClickSaveBtn();
        }
       
        public void TS_Monetization_DeactivateBrand()
        {
            Monetization_App_Management();
            homePageMonetization.ClickBrand();
            homePageMonetization.SearchBrandTitle();
            homePageMonetization.DeactivateBrand();
            homePageMonetization.ClickBrandStatusYesBtn();
        }

      
        public void TS_Monetization_App_Creation()
        {
            //APP CREATION:
            homePageMonetization.ClickNewApp();
            homePageMonetization.ClickCreateManuallybtn();
            homePageMonetization.ClickAppTitle();
            homePageMonetization.ClickPackageName();
            homePageMonetization.ClickEnvironmentRdbtn(Utils.ExcelUtil.ReadData(1, "App_Environment"));
            homePageMonetization.SelectPlatform(Utils.ExcelUtil.ReadData(1, "Platfrom"));
            homePageMonetization.SelectAppType(Utils.ExcelUtil.ReadData(1, "App_AppType"));
            homePageMonetization.SelectAppCategory(Utils.ExcelUtil.ReadData(1, "App_AppCategory"));
            homePageMonetization.ClickAppNewBrandBtn();
            homePageMonetization.FillBrandNameField();
            homePageMonetization.FillBrandDetailsField();
            homePageMonetization.FillSupportemailField();
            homePageMonetization.FillGoogleMoreAppURLField();
            homePageMonetization.FillAmazonMoreAppsURLField();
            homePageMonetization.FillAppStoreMoreAppsURL();
            homePageMonetization.ClickSaveBtn();
            homePageMonetization.SelectAgeRating(Utils.ExcelUtil.ReadData(1, "App_AgeRating"));
            homePageMonetization.ClickAppSaveBtn();
            homePageMonetization.clickAppsManagement();
            homePageMonetization.SearchRequiredApplication();
            homePageMonetization.ValidateApp();
      
        }

        public void TS_Monetization_Import_App()
        {
            Monetization_App_Management();
            homePageMonetization.ClickNewApp();
            homePageMonetization.ClickImportField();
            homePageMonetization.ClickImportBtn();
            homePageMonetization.ClickEnvironmentRdbtn(Utils.ExcelUtil.ReadData(1, "App_Environment"));
            homePageMonetization.SelectBrand();
            homePageMonetization.SelectAgeRating(Utils.ExcelUtil.ReadData(1, "App_AgeRating"));
            homePageMonetization.ClickAppSaveBtn();
        }


        //CROSS PROMOTIOM NON INTEGRATED CAMPAIGN CREATION:
        public void TS_Monetization_Not_Intergrated_CrossPromotion_Campaign_Creation()
        {
            homePageMonetization.ClickPromotesSection();
            Extension.CaptureScreenShot("3_promotesection");
            homePageMonetization.ClickNewCampaignBtn();
            Extension.CaptureScreenShot("4_NewCampaginButton");
            homePageMonetization.ClickCampaignType();
            homePageMonetization.ClickCampaignNotIntegrated();
            homePageMonetization.ClickCrossCampaignis(Utils.ExcelUtil.ReadData(1, "Campaign_campaignis"));
            homePageMonetization.SelectCampaignAdType(Utils.ExcelUtil.ReadData(1, "Campaign_Adtype"));
            homePageMonetization.ClickNotIntegratedCrossCampaignTitleField();
            homePageMonetization.ClickNotIntCrossCampaignBrandAddNewBtn();
            homePageMonetization.InsertCampaignBrandTitleName();
            Extension.CaptureScreenShot("5_Brand Details");
            homePageMonetization.ClickCampaignBrandSaveBtn();
            Extension.CaptureScreenShot("6_Brand Details Added and Saved");
            homePageMonetization.ClickCampaignAdOkBtn();
            Extension.CaptureScreenShot("7_CamapaignCreated");
            homePageMonetization.ClickCampaignBrandCloseBtn();
            homePageMonetization.ClickNotIntCampaignAdAddNewBtn();
            homePageMonetization.InsertCampaignAdTitleName();
            homePageMonetization.ClickCampaignAdSaveBtn();
            homePageMonetization.ClickCampaignAdOkBtn();
            homePageMonetization.SelectCampaignAttribution(Utils.ExcelUtil.ReadData(1, "Campaign_Attribution"));
            homePageMonetization.SelectCampaignClickUrl();
            homePageMonetization.ClickCampaignPlatform(Utils.ExcelUtil.ReadData(1, "Platfrom"));
            homePageMonetization.SelectCampaignRegions();
            homePageMonetization.SelectCampaignPriority(Utils.ExcelUtil.ReadData(1, "Campaign_Priority"));
            homePageMonetization.ClickCampaignPublishIn(Utils.ExcelUtil.ReadData(1, "Campaign_Publish_In"));
            homePageMonetization.SelectCrossCampaignBrands();
            homePageMonetization.SelectCrossCampaignApps();
            homePageMonetization.SelectCrossCampaignScenes();
            homePageMonetization.SelectCampaignDailyImpressionPerUserCap();
            homePageMonetization.SelectCampaignTotalImpressionPerUserCap();
            homePageMonetization.ClickNewBtnofCreatives();
            homePageMonetization.ClickCreativeNameField();
            homePageMonetization.ClickChooseCreatives(Utils.ExcelUtil.ReadData(1, "Campaign_Adtype"));
            Extension.CaptureScreenShot("8_creatives and other details saved");
            homePageMonetization.ClickCampaigncreativeSaveBtn();
            homePageMonetization.ClickCreativeCloseBtn();
            homePageMonetization.selectCreativeSet(ExcelUtil.ReadData(1, "Campaign_creatives"));
            homePageMonetization.ScrollToSave();
            homePageMonetization.ClickCampaignSaveBtn();
            homePageMonetization.SearchCrossNotIntCampaign();
            homePageMonetization.ValidateCrossNotIntegratedCampaign();
            
        }
     //   [TestMethod]
        public void TS_Monetization_Not_Intergrated_Network_Advertising_Campaign_Creation()
        //NETWORK NON INTEGRATED CAMPAIGN CREATION:
        {
            homePageMonetization.ClickNewCampaignBtn();
            Extension.CaptureScreenShot("9_Network Adveritising Campagin");
            homePageMonetization.selectNetworkCampaignRadioBtn();
            homePageMonetization.selectNetworkCampaignNoBtn();
            homePageMonetization.SelectCampaignAdType(Utils.ExcelUtil.ReadData(1, "Campaign_Adtype"));
            homePageMonetization.ClickNotIntegratedNetworkCampaignTitleField();
            homePageMonetization.ClickNotIntCampaignBrandAddNewBtn();
            homePageMonetization.InsertCampaignBrandTitleName();
            Extension.CaptureScreenShot("10_Campaign details added");
            homePageMonetization.ClickCampaignBrandSaveBtn();
            homePageMonetization.ClickCampaignAdOkBtn();
            homePageMonetization.ClickNotIntAdvertisingCampaignAdAddNewBtn();
            homePageMonetization.InsertCampaignAdTitleName();
            homePageMonetization.ClickCampaignAdSaveBtn();
            homePageMonetization.ClickCampaignAdOkBtn();
            homePageMonetization.SelectCampaignAttribution(Utils.ExcelUtil.ReadData(1, "Campaign_Attribution"));
            homePageMonetization.SelectCampaignClickUrl();
            homePageMonetization.ClickCampaignAdName();
            homePageMonetization.ClickCampaignPlatform(Utils.ExcelUtil.ReadData(1, "Platfrom"));
            homePageMonetization.SelectCampaignRegions();
            homePageMonetization.SelectCampaignDailyImpressionPerUserCap();
            homePageMonetization.ClickNewBtnofCreatives();
            homePageMonetization.ClickCreativeNameField();
            homePageMonetization.ClickChooseCreatives(Utils.ExcelUtil.ReadData(1, "Campaign_Adtype"));
            homePageMonetization.ClickCampaigncreativeSaveBtn();
            homePageMonetization.ClickCreativeCloseBtn();
            homePageMonetization.selectCreativeSet(ExcelUtil.ReadData(1, "Campaign_creatives"));
            homePageMonetization.SelectCampaignPricingType(Utils.ExcelUtil.ReadData(1, "Campaign_PricingType"));
            homePageMonetization.ClickDailyBudget();
            homePageMonetization.ClickTotalBudget();
            homePageMonetization.ClickBidField();
            homePageMonetization.ScrollToSave();
            homePageMonetization.ClickNotIntCampaignSaveBtn();
            homePageMonetization.SearchNetworkNotIntCampaign();
            homePageMonetization.ValidateNetworkNotIntegratedCampaign();
            
        }

        //CROSS PROMOTION INTEGRATED CAMPAIGN:
        public void TS_Monetization_Integrated_CrossPromotion_Campaign_Creation() {

            homePageMonetization.ClickNewCampaignBtn();
            homePageMonetization.ClickCampaignType();
            homePageMonetization.ClickIntegratedCrosspromoCampaign();
            homePageMonetization.ClickCrossCampaignis(Utils.ExcelUtil.ReadData(1, "Campaign_campaignis"));
            homePageMonetization.SelectCampaignAdType(Utils.ExcelUtil.ReadData(1, "Campaign_Adtype"));
            homePageMonetization.ClickIntegratedCrossCampaignTitleField();
            homePageMonetization.ClickCampaignBrandField(Utils.ExcelUtil.ReadData(1, "Campaign_brand"));
            homePageMonetization.SelectCampaignPromotingApp(Utils.ExcelUtil.ReadData(1, "Campaign_PromotingApp"));
            homePageMonetization.SelectCampaignRegions();
            homePageMonetization.ClickCampaignPublishIn(Utils.ExcelUtil.ReadData(1, "Campaign_Publish_In"));
            homePageMonetization.SelectCrossCampaignBrands();
            homePageMonetization.SelectCrossCampaignApps();
            homePageMonetization.SelectCrossCampaignScenes();
            homePageMonetization.SelectCampaignDailyImpressionPerUserCap();
            homePageMonetization.SelectCampaignTotalImpressionPerUserCap();
            homePageMonetization.ClickNewBtnofCreatives();
            homePageMonetization.ClickCreativeNameField();
            homePageMonetization.ClickChooseCreatives(Utils.ExcelUtil.ReadData(1, "Campaign_Adtype"));
            homePageMonetization.ClickCampaigncreativeSaveBtn();
            homePageMonetization.ClickCreativeCloseBtn();
            homePageMonetization.selectCreativeSet(Utils.ExcelUtil.ReadData(1, "Campaign_creatives"));
            homePageMonetization.ClickCampaignSaveBtn();
            homePageMonetization.SearchCrossIntCampaign();
            homePageMonetization.ValidateCrossIntegratedCampaign();
            

        }

        //NETWORK ADV INTEGRATED CAMPAIGN:
        public void TS_Monetization_Intergrated_Network_Advertising_Campaign_Creation() {
            homePageMonetization.ClickNewCampaignBtn();
            homePageMonetization.selectNetworkCampaignRadioBtn();
            homePageMonetization.ClickNetworkIntegratedCampaign();
            homePageMonetization.SelectCampaignAdType(Utils.ExcelUtil.ReadData(1, "Campaign_Adtype"));
            homePageMonetization.ClickIntegratedNetworkCampaignTitleField();
            homePageMonetization.ClickCampaignBrandField(Utils.ExcelUtil.ReadData(1, "Campaign_brand"));
            homePageMonetization.SelectCampaignPromotingApp(Utils.ExcelUtil.ReadData(1, "Campaign_PromotingApp"));
            homePageMonetization.ClickCampaignSelectCategoriesBtn();
            homePageMonetization.SelectCampaignCategories(Utils.ExcelUtil.ReadData(1, "Campaign_Categories"));
            homePageMonetization.ClickCreativeCloseBtn();
            homePageMonetization.SelectCampaignDailyImpressionPerUserCap();
            homePageMonetization.SelectCampaignRegions();
            homePageMonetization.ClickNewBtnofCreatives();
            homePageMonetization.ClickChooseCreatives(Utils.ExcelUtil.ReadData(1, "Campaign_Adtype"));
            homePageMonetization.ClickCampaigncreativeSaveBtn();
            homePageMonetization.ClickCreativeCloseBtn();
            homePageMonetization.selectCreativeSet(ExcelUtil.ReadData(1, "Campaign_creatives"));
            homePageMonetization.SelectCampaignPricingType(Utils.ExcelUtil.ReadData(1, "Campaign_PricingType"));
            homePageMonetization.ClickDailyBudget();
            homePageMonetization.ClickTotalBudget();
            homePageMonetization.ClickBidField();
            homePageMonetization.ScrollToSave();
            homePageMonetization.ClickCampaignSaveBtn();
            homePageMonetization.SearchNetworkIntCampaign();
            homePageMonetization.ValidateNetworkIntegratedCampaign();
        }
       
        public void TS_Monetization_User_creation() {
            // Create Users
            Monetization_App_Management();
            homePageMonetization.ClickUsersLink();
            homePageMonetization.ClickNewUserBtn();
            homePageMonetization.ClickUserRole(Utils.ExcelUtil.ReadData(1, "User_UserRole"));
            homePageMonetization.ClickUsersFullName();
            homePageMonetization.ClickUserEmail();
            homePageMonetization.ClickUsersBrandField(Utils.ExcelUtil.ReadData(1, "Campaign_brand"));
            homePageMonetization.ClickUsersSaveBtn();
          
        }
        
        public void TS_Monetization_Edit_User()
        {
            // Create Users
            Monetization_App_Management();
            homePageMonetization.ClickUsersLink();
            homePageMonetization.EditBTn();
            homePageMonetization.ClickUserRole(Utils.ExcelUtil.ReadData(1, "User_UserRole"));
            homePageMonetization.ClickUsersFullName();
            homePageMonetization.ClickUserEmail();
            homePageMonetization.ClickUsersBrandField(Utils.ExcelUtil.ReadData(1, "Campaign_brand"));
            homePageMonetization.ClickUsersSaveBtn();

        }
        
        public void TS_Monetization_Delete_User()
        {
            // Create Users
            Monetization_App_Management();
            homePageMonetization.ClickUsersLink();
            homePageMonetization.DeleteUser();
            homePageMonetization.ClickBrandStatusYesBtn();

        }
       
        public void TS_Monetization_App_Manage_Apps_stats()
        {
            homePageMonetization.ClickApps();
            homePageMonetization.ClickManageTab();
            TS_Monetize_Dynamic_filter();
            homePageMonetization.SearchRequiredApplicationForStats();
            homePageMonetization.CompareStatsofAnApp();
        }

        public void TS_Monetization_Date_Filter()
        {
            homePageMonetization.ClickDateFilter();
            homePageMonetization.SelectDateRange();
            homePageMonetization.ClickFilterSubmitBtn();
        }
       
        public void TS_Monetize_Dynamic_filter()
        {
            homePageMonetization.ClickDateFilter();
            homePageMonetization.ClickStartdatefilter(Utils.ExcelUtil.ReadData(1, "StartDate"));
            homePageMonetization.ClickEnddatefilter(Utils.ExcelUtil.ReadData(1, "EndDate"));
            homePageMonetization.ClickApplyBtn();
            homePageMonetization.ClickFilterSubmitBtn();
        }
       
        public void TS_Monetization_App_Logout()
        {
            homePageMonetization.ClickUserName();
            homePageMonetization.ClickLogOutButton();
            DriverProperty.driver.Quit();
        }

        [TestMethod]
        public void A_BS_Monetization_Advertiser_Flow()
        {
            Extension.DeleteOldFilesFolder();
            Monetization_App_Management();
            TS_Monetization_Not_Intergrated_CrossPromotion_Campaign_Creation();
            TS_Monetization_Not_Intergrated_Network_Advertising_Campaign_Creation();
            TS_Monetization_App_Logout();
        }
        
        [TestMethod]
        public void B_BS_Monetization_Both_publisheradvertiser_Flow()
        {
           Monetization_App_Management();
           TS_Monetization_Brand_Creation();
           TS_Monetization_App_Creation();
           TS_Monetization_Integrated_CrossPromotion_Campaign_Creation();
           TS_Monetization_Intergrated_Network_Advertising_Campaign_Creation();
           TS_Monetization_App_Logout();
        }

        public void TS_Monetization_Revenue_stats()
        {
            Monetization_App_Management();
            homePageMonetization.ClickRevenueLink();
            TS_Monetize_Dynamic_filter(); 
            homePageMonetization.ClickNetworkButtonOfRevenueTab();
            homePageMonetization.CompareBottomGridNetworkWiseStats();
        }
   
        public void TS_Monetization_App_Edit()
        {
            Monetization_App_Management();
            homePageMonetization.clickAppsManagement();
            homePageMonetization.SearchRequiredApplicationtoEdit();
            homePageMonetization.ClickAppEditField();
            homePageMonetization.ClickAdmobAdidsBtn();
            homePageMonetization.InsertAdmobAdIds();
            homePageMonetization.ClickAdidSaveBtn();
            homePageMonetization.ClickAdidCloseBtn();
            homePageMonetization.ClickChartboostAdidsBtn();
            homePageMonetization.InsertChartboostAdIds();
            homePageMonetization.ClickAdidSaveBtn();
            homePageMonetization.ClickAdidCloseBtn();
            homePageMonetization.ClickFacebookAdidsBtn();
            homePageMonetization.InsertFacebookAdIds();
            homePageMonetization.ClickAdidSaveBtn();
            homePageMonetization.ClickAdidSaveBtn();

        }
       
        public void TS_Monetization_App()
        {
            Monetization_App_Management();
            homePageMonetization.ClickApps();
            homePageMonetization.clickAppsManagement();
            homePageMonetization.SearchRequiredApplicationtoEdit();
            homePageMonetization.ClickSearchedApp();
            homePageMonetization.ClickPlaceholdersAddAdsTab();
            homePageMonetization.ClickDevPlaceHoldersAndAdsBtn();
            homePageMonetization.ClickIsSkipAbleOnToggle();
            homePageMonetization.SelectAdMechanism(Utils.ExcelUtil.ReadData(1, "Admechanism"));
            homePageMonetization.SelectAppAdType(Utils.ExcelUtil.ReadData(1, "Adtype"));
        }
    }
}
