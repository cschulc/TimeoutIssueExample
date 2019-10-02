// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Browser.cs" company="SMA Solar Technology AG, 34266 Niestetal, Germany">
//   Copyright (c) SMA Solar Technology AG, 34266 Niestetal, Germany.  All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TimeoutIssueExample
{
    public static class Browser
    {
        public static IWebDriver WebDriver { get; set; }

        public static void Start()
        {
            var options = new ChromeOptions();
            options.AddArguments("ignore-certificate-errors");
            var msChromeDriverService = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            msChromeDriverService.Port = 9510;
            msChromeDriverService.Start();
            WebDriver = new ChromeDriver(msChromeDriverService, options);
        }

        public static void Navigate(Uri uri)
        {
            WebDriver.Navigate().GoToUrl(uri);
        }

        public static void Close()
        {
            WebDriver.Close();
            WebDriver?.Quit();
        }
    }
}