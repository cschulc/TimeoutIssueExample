// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AngularHomePage.cs" company="SMA Solar Technology AG, 34266 Niestetal, Germany">
//   Copyright (c) SMA Solar Technology AG, 34266 Niestetal, Germany.  All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using OpenQA.Selenium;

namespace TimeoutIssueExample
{
    public class GoogleHomePage
    {
        public IWebElement SearchInput => Browser.WebDriver.FindElement(By.CssSelector("input[name='q']"));

        public IWebElement SearchBtn => Browser.WebDriver.FindElement(By.CssSelector("input[name='btnK']"));

        public bool IsPageOpenend()
        {
            var searchBtnDisplayed = SearchBtn.Displayed;
            var searchInputDisplayed = SearchInput.Displayed;
            return searchBtnDisplayed
                   && searchInputDisplayed;
        }
    }
}