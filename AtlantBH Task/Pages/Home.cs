using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AtlantBH_Task.Pages
{
    public class Home : Base
    {
        [FindsBy(How = How.Id, Using = "signup")]
        IWebElement SignUpButton { get; set; }

        internal void ClickSignUp()
        {
            SignUpButton.Click();
        }
    }
}

