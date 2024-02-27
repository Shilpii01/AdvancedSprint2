using AdvancedTaskSpecflow.Utilities;
using OpenQA.Selenium;

namespace AdvancedTaskSpecflow.Pages.Components.ProfileOverview
{
    public class ManageRequestComponent:BaseClass
    {
        private IWebElement ReceivedRequestsTab;
        private IWebElement SentRequestsTab;
        private IWebElement WithdrawRequestButton;
        private IWebElement CompleteRequestButton;

        public void renderComponents()
        {
            try
            {
                ReceivedRequestsTab = driver.FindElement(By.XPath("//a[contains(text(),'Received Requests')]"));
                SentRequestsTab = driver.FindElement(By.XPath("//a[contains(text(),'Sent Requests')]"));
                WithdrawRequestButton = driver.FindElement(By.XPath("///button[contains(text(),'Withdraw')]"));
                CompleteRequestButton = driver.FindElement(By.XPath("//button[contains(text(),'Complete')]"));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void ClickReceivedRequestsTab()
        {
            renderComponents();
            ReceivedRequestsTab.Click();
            Thread.Sleep(4000);
        }

        public void ClickSentRequestsTab()
        {
            renderComponents();
            SentRequestsTab.Click();
            Thread.Sleep(4000);
        }
        public void ClickCompleteRequestsButton()
        {
            renderComponents();
            CompleteRequestButton.Click();
            Thread.Sleep(4000);
        }
        public void ClickWithdrawRequestsButton()
        {
            renderComponents();
            WithdrawRequestButton.Click();
            Thread.Sleep(4000);
        }





















    }



    }
}
