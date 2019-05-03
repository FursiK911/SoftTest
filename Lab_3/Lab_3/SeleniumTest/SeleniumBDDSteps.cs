using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SeleniumTest
{
    [Binding]
    public class SeleniumBDDSteps
    {

        ChromeDriver chrome;
        WebDriverWait wait;
        IWebElement _element;

        [BeforeScenario]
        public void Init()
        {
            chrome = new ChromeDriver();
            wait = new WebDriverWait(chrome, TimeSpan.FromSeconds(10));
        }

        [AfterScenario]
        public void Quit()
        {
            chrome.Quit();
        }


        [Given(@"I have opened Google search page")]
        public void GivenIHaveOpenedGoogleSearchPage()
        {
            chrome.Navigate().GoToUrl("http://www.google.com/");
        }
        
        [Given(@"I entered unit testing")]
        public void GivenIEnteredUnitTesting()
        {
            chrome.FindElement(By.Name("q")).SendKeys("unit testing");
        }
        
        [Given(@"I have opened Unit Testing page in Wikipedia")]
        public void GivenIHaveOpenedUnitTestingPageInWikipedia()
        {
            chrome.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Unit_testing");
        }
        
        [Given(@"I entered NUnit in search field")]
        public void GivenIEnteredNUnitInSearchField()
        {
            chrome.FindElement(By.XPath("//*[contains(@placeholder,'Search Wikipedia')]")).SendKeys("NUnit");
        }

        [When(@"I press search button in Google")]
        public void WhenIPressSearchButtonInGoogle()
        {
            chrome.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }

        [When(@"I press search button in Wikipedia")]
        public void WhenIPressSearchButtonInWikipedia()
        {
            chrome.FindElement(By.XPath("//*[contains(@placeholder,'Search Wikipedia')]")).SendKeys(Keys.Enter);
        }

        [Then(@"The search contains link in Wikipedia")]
        public void ThenTheSearchContainsLinkInWikipedia()
        {
            var entries = chrome.FindElements(By.Id("main"));
            foreach (IWebElement entry in entries)
            {
                if (entry.Text.Contains("https://en.wikipedia.org/wiki/Unit_testing"))
                {
                    _element = entry.FindElement(By.XPath("//a[@href='https://en.wikipedia.org/wiki/Unit_testing']"));
                }
            }
            Assert.AreNotEqual(null, _element);
        }
        
        [Then(@"I click link in Wikipedia")]
        public void ThenIClickLinkInWikipedia()
        {
            _element.Click();
            Assert.AreEqual(@"https://en.wikipedia.org/wiki/Unit_testing", chrome.Url);
        }
        
        [Then(@"Check the availability of Russian articles")]
        public void ThenCheckTheAvailabilityOfRussianArticles()
        {
            wait.Until(d => d.FindElement(By.Id("p-lang")));
            var entries = chrome.FindElements(By.Id("p-lang"));
            foreach (IWebElement entry in entries)
            {
                if (entry.Text.Contains("Русский"))
                {
                    _element = entry.FindElement(By.XPath("//a[@lang='ru']"));
                }
            }
            Assert.AreNotEqual(null, _element);
        }
    }
}
