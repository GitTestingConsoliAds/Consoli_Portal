using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monetization_Automation.Utils
{
    public class AppManageTableValues
    {
        public static string[] tableValues = new string[6];
        public static DataSet[] dataSetPropertyFill = new DataSet[15];
        public static string[] queryArray = new string[10];
        public static string[] tableArray= new string[6];
        public static string AppTitle { get; set; }
        public static string BrandTitle { get; set; }
        public static string CrossIntCampaignTitle { get; set; }
        public static string CrossNotIntCampaignTitle { get; set; }
        public static string NetworkIntCampaignTitle { get; set; }
        public static string NetworkNotIntCampaignTitle { get; set; }
        public static string FirstCompareValue { get; set; }

        public static string SecondCompareValue { get; set; }

    }
}
