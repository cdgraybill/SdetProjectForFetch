using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SdetProjectForFetch
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void FindFakeGoldBar()
        {
            ChallengePage challengePage = new ChallengePage(Driver);

            challengePage.NavigateToChallengePage();
            challengePage.FindFakeBar();

            string correctAnswerAlert = Driver.SwitchTo().Alert().Text;
            string expectedAnswerText = "Yay! You find it!";

            Assert.AreEqual(correctAnswerAlert, expectedAnswerText);
        }
    }
}