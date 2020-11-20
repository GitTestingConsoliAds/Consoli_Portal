//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

namespace Monetization_Automation.Utils
{
    using System;
    using System.Collections;
    using System.Data;
    using System.Diagnostics;
    using System.IO;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Appium.Windows;
    using MySql.Data.MySqlClient;
    using System.Net;
    using RestSharp;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Web.UI.WebControls;
    using System.Windows.Forms;
    using System.Threading;
    using Monetization_Automation.Base;

    public static class Extension
    {

        public static void HighLighterMethod(IWebDriver driver , IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].setAttribute('style', 'background: yellow; border: 2px solid red;');", element);
        }

        public static void CaptureScreenShot(string fileName)
        {
            System.DateTime currentDate = DateTime.Now;
            string dateFormat = @"MMddyyyy";
            string timeFormat = @"hhmmss";
            string directoryPath = @"E:\Automation\Monetization_Automation\Monetization_Automation\" + "PortalScreenShots" + currentDate.ToString(dateFormat);
            Directory.CreateDirectory(directoryPath);
            var pathToSave = System.IO.Path.Combine(directoryPath, " - " + DateTime.Now.ToString(timeFormat) + fileName + ".jpg");
            Screenshot screenShot = ((ITakesScreenshot)DriverProperty.driver).GetScreenshot();
            screenShot.SaveAsFile(pathToSave);
        }

        public static void ExecuteCronJob(string URL)
        {
            try
            {
                RestClient restClient = new RestClient(URL);
                RestRequest restRequest = new RestRequest(Method.POST);
                IRestResponse response = restClient.Execute(restRequest);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Assert.Fail("Cronjob did not execute successfully");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        public static void OpenDBConnection()
        {
            MySqlConnection mySqlconnection;
            string connetionString = "server=aurora-shoeda-2020aug21.cvpiqdvbgbus.us-west-2.rds.amazonaws.com;database=db_consoliads;uid=sheeda_user;pwd=consoli123;";
            mySqlconnection = new MySqlConnection(connetionString);
            try
            {
                mySqlconnection.Open();
                SqlConnectionInstance.SqlConnection = mySqlconnection;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public static string ExecuteQuery(MySqlConnection connection, string sqlQuery)
        {
            string firstrowvalue = null;
            try
            {
                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlQuery, connection);
                mySqlDataAdapter.Fill(dataSet);
                //dataSet.WriteXml(@"H:/Automation/Automation_Data/APIExcels/testDataSet.csv");
               // firstrowvalue = AppManageTableValues.appManagementDataSet.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);

            }
            return firstrowvalue;
        }

        public static void ExecuteQueryPortal(MySqlConnection connection, int dataSetIndex)
        {
           // for (int i = 1; i <= dataSetIndex; i++)
            //{
                try
                {
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(AppManageTableValues.queryArray[0], connection);
                      AppManageTableValues.dataSetPropertyFill[0] = new DataSet();
                    Thread.Sleep(40000);
                    try
                    {
                   // AppManageTableValues.dataSetPropertyFill[0] = new DataSet();
                    mySqlDataAdapter.Fill(AppManageTableValues.dataSetPropertyFill[0]);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                    // DataSetPropertyFill.dataSetPropertyFill.WriteXml(@"/Volumes/DataDisk/Ahmad khisal/Consoliads/Automation_Data/APIExcels/APIExcelCodeGenerator.csv");
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
           // }
        }

        public static void ExecuteQueryAPICodeGenerator(MySqlConnection connection, int dataSetIndex)
        {
            for (int i = 1; i <= dataSetIndex; i++)
            {
                try
                {
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(QueryArrayAllAPI.queryArrayAllAPI[i - 1], connection);
                    DataSetPropertyFill.dataSetPropertyFill[i - 1] = new DataSet();
                    try
                    {
                        mySqlDataAdapter.Fill(DataSetPropertyFill.dataSetPropertyFill[i - 1]);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                    //  DataSetPropertyFill.dataSetPropertyFill[i-1].WriteXml(@"/Volumes/DataDisk/APIExcelCodeGenerator" + i + ".xml");
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
        }

        public static int randomNumberGenerator(int startvalue, int endvalue)
        {
            Random random = new Random();
            int randomValue = random.Next(startvalue, endvalue);
            return randomValue;
        }

        public static void  comparisonValidation(string first, string second, string FieldName)
        {
            if (first.Equals(second))
            {
                Debug.WriteLine(FieldName + "validation is successful");
            }
        }
        
        

        public static void CreateLogFile()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            //Table start.
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            //Adding HeaderRow.
            html += "<tr>";
            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>Name</th>";
            html += "</tr>";

            //Adding DataRow.
            html += "<tr>";
            html += "<td style='width:120px;border: 1px solid #ccc'>" + name + "</td>";
            html += "</tr>";

            //Table end.
            html += "</table>";

            //Create the HTML file.
            File.WriteAllText(@"E:\Files\Console.htm", html);
            

            Console.WriteLine("HTML File created.");
            Console.ReadLine();
        }

    

    public enum PropertyType
        {
            Id,
            Name,
            ControlName,
            FriendlyName,
            Text,
            ClassName
        }
    }
}
