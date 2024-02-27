using AdvancedTask.Test_Model;
using AdvancedTaskSpecflow.Utilities;
using OpenQA.Selenium;

namespace AdvancedTaskSpecflow.Pages.Components.Sign_In
{
    public class LoginComponent:BaseClass

    {

        private IWebElement EmailTextbox;
        private IWebElement PasswordTextbox;
        private IWebElement LoginButton;



        public void renderComponents()
        {
            try
            {
                EmailTextbox = driver.FindElement(By.XPath("//*[@placeholder='Email address']"));
                PasswordTextbox = driver.FindElement(By.XPath("//*[@placeholder='Password']"));
                LoginButton = driver.FindElement(By.XPath("//*[text()='Login']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public void DoSignIn()
        {

            renderComponents();


            List<Login> credentialsList = JsonReader.ReadTestDataFromJson<Login>("A:\\Industry Connect\\AdvancedSprint2\\AdvancedTaskSpecflow\\AdvancedTaskSpecflow\\JsonTestData\\LoginCredentials.json");

            EmailTextbox.SendKeys(credentialsList[0].Email);
            PasswordTextbox.SendKeys(credentialsList[0].Password);
                LoginButton.Click();
                Thread.Sleep(5000);
            
        }
    }
}
