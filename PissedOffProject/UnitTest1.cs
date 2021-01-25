using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PissedOffProject
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void TestMethod()
        {
            
            driver.Navigate().GoToUrl("http://qaauto.co.nz/test-blank-form/");
            driver.FindElement(By.Id("wpforms-locked-16-field_form_locker_password")).SendKeys("Testing");
            driver.FindElement(By.Name("wpforms[submit]")).Click();
            driver.Manage().Window.Maximize();
           FillForm();


        }
        public void FillForm()
        {
            driver.FindElement(By.Id("wpforms-16-field_0")).SendKeys("Ajit");
            driver.FindElement(By.Id("wpforms-16-field_0-last")).SendKeys("Sharma");
            driver.FindElement(By.Id ("wpforms-16-field_1")).SendKeys("ajit@gmail.com");
            driver.FindElement(By.Id("wpforms-16-field_2")).SendKeys("Enter your comment Here");
            
            driver.FindElement(By.TagName ("button")).Click ();
            driver.FindElement(By.TagName   ("p")).SendKeys("finally its over");
        //  Console.WriteLine("Finally completed without POM model ");


    }
    }
}
