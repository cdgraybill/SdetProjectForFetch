using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SdetProjectForFetch
{
    public class ChallengePage : DriverHelper
    {
        public ChallengePage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement LeftOne => Driver.FindElement(By.Id("left_0"));

        IWebElement LeftTwo => Driver.FindElement(By.Id("left_1"));

        IWebElement LeftThree => Driver.FindElement(By.Id("left_2"));
        
        IWebElement LeftFour => Driver.FindElement(By.Id("left_3"));
        
        IWebElement RightOne => Driver.FindElement(By.Id("right_0"));
        
        IWebElement RightTwo => Driver.FindElement(By.Id("right_1"));
        
        IWebElement RightThree => Driver.FindElement(By.Id("right_2"));
        
        IWebElement RightFour => Driver.FindElement(By.Id("right_3"));
        
        IWebElement WeighButton => Driver.FindElement(By.Id("weigh"));
        
        IWebElement ZeroButton => Driver.FindElement(By.Id("coin_0"));
        
        IWebElement OneButton => Driver.FindElement(By.Id("coin_1"));
        
        IWebElement TwoButton => Driver.FindElement(By.Id("coin_2"));
        
        IWebElement ThreeButton => Driver.FindElement(By.Id("coin_3"));
        
        IWebElement FourButton => Driver.FindElement(By.Id("coin_4"));
        
        IWebElement FiveButton => Driver.FindElement(By.Id("coin_5"));
        
        IWebElement SixButton => Driver.FindElement(By.Id("coin_6"));
        
        IWebElement SevenButton => Driver.FindElement(By.Id("coin_7"));
        
        IWebElement EightButton => Driver.FindElement(By.Id("coin_8"));
        
        IWebElement ResetButton => Driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[4]/button[1]"));

        public string resultsOperator { get; set; }

        public void NavigateToChallengePage()
        {
            Driver.Navigate().GoToUrl("http://ec2-54-208-152-154.compute-1.amazonaws.com/");
        }

        public void FindFakeBar()
        {
            LeftOne.Click();
            LeftOne.SendKeys("1");

            LeftTwo.Click();
            LeftTwo.SendKeys("2");

            LeftThree.Click();
            LeftThree.SendKeys("3");

            LeftFour.Click();
            LeftFour.SendKeys("4");

            RightOne.Click();
            RightOne.SendKeys("5");

            RightTwo.Click();
            RightTwo.SendKeys("6");

            RightThree.Click();
            RightThree.SendKeys("7");

            RightFour.Click();
            RightFour.SendKeys("8");

            WeighButton.Click();
            Thread.Sleep(2000);
            resultsOperator = Driver.FindElement(By.Id("reset")).Text;

            if (resultsOperator == "=")
            {
                ZeroButton.Click();
            }

            if (resultsOperator == "<")
            {
                ResetButton.Click();

                LeftOne.Click();
                LeftOne.SendKeys("1");
                RightOne.Click();
                RightOne.SendKeys("2");
                WeighButton.Click();
                Thread.Sleep(2000);

                resultsOperator = Driver.FindElement(By.Id("reset")).Text;

                if (resultsOperator == "<")
                {
                    OneButton.Click();
                }
                else if (resultsOperator == ">")
                {
                    TwoButton.Click();
                }
                else
                {
                    ResetButton.Click();

                    LeftOne.Click();
                    LeftOne.SendKeys("3");
                    RightOne.Click();
                    RightOne.SendKeys("4");
                    WeighButton.Click();
                    Thread.Sleep(2000);

                    resultsOperator = Driver.FindElement(By.Id("reset")).Text;

                    if (resultsOperator == "<")
                    {
                        ThreeButton.Click();
                    }
                    else
                    {
                        FourButton.Click();
                    }
                }
            }

            if (resultsOperator == ">")
            {
                ResetButton.Click();

                LeftOne.Click();
                LeftOne.SendKeys("5");
                RightOne.Click();
                RightOne.SendKeys("6");
                WeighButton.Click();
                Thread.Sleep(2000);

                resultsOperator = Driver.FindElement(By.Id("reset")).Text;

                if (resultsOperator == "<")
                {
                    FiveButton.Click();
                }
                else if (resultsOperator == ">")
                {
                    SixButton.Click();
                }
                else
                {
                    ResetButton.Click();

                    LeftOne.Click();
                    LeftOne.SendKeys("7");
                    RightOne.Click();
                    RightOne.SendKeys("8");
                    WeighButton.Click();
                    Thread.Sleep(2000);

                    resultsOperator = Driver.FindElement(By.Id("reset")).Text;

                    if (resultsOperator == "<")
                    {
                        SevenButton.Click();
                    }
                    else
                    {
                        EightButton.Click();
                    }
                }
            }
        }
    }
}
