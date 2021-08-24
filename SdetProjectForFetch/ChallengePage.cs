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

        private string ResultsOperator { get; set; }

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
            ResultsOperator = Driver.FindElement(By.Id("reset")).Text;

            if (ResultsOperator == "=")
            {
                ZeroButton.Click();
            }

            if (ResultsOperator == "<")
            {
                ResetButton.Click();

                LeftOne.Click();
                LeftOne.SendKeys("1");
                RightOne.Click();
                RightOne.SendKeys("2");
                WeighButton.Click();
                Thread.Sleep(2000);

                ResultsOperator = Driver.FindElement(By.Id("reset")).Text;

                if (ResultsOperator == "<")
                {
                    OneButton.Click();
                }
                else if (ResultsOperator == ">")
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

                    ResultsOperator = Driver.FindElement(By.Id("reset")).Text;

                    if (ResultsOperator == "<")
                    {
                        ThreeButton.Click();
                    }
                    else
                    {
                        FourButton.Click();
                    }
                }
            }

            if (ResultsOperator == ">")
            {
                ResetButton.Click();

                LeftOne.Click();
                LeftOne.SendKeys("5");
                RightOne.Click();
                RightOne.SendKeys("6");
                WeighButton.Click();
                Thread.Sleep(2000);

                ResultsOperator = Driver.FindElement(By.Id("reset")).Text;

                if (ResultsOperator == "<")
                {
                    FiveButton.Click();
                }
                else if (ResultsOperator == ">")
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

                    ResultsOperator = Driver.FindElement(By.Id("reset")).Text;

                    if (ResultsOperator == "<")
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
