using AdvancedTaskSpecflow.Pages.Components.ProfileOverview;
using AdvancedTaskSpecflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskSpecflow.Pages
{
    public class HomePage:BaseClass
    {
        private IWebElement userNameLabel;
        private ProfileTabComponents profileTabComponentsObj;
        private ProfileTabComponents profileTabComponents;

        public HomePage()
        {
            profileTabComponentsObj = new ProfileTabComponents();

        }


        public void renderComponents()
        {
            try
            {
                userNameLabel = driver.FindElement(By.XPath("//span[contains(@class,'item ui')]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public ProfileTabComponents getProfileTabComponents()
        {
            return profileTabComponents;

        }



        public String getFirstName()
        {
            //Return username
            try
            {
                renderComponents();
                return userNameLabel.Text;

            }
            catch (Exception ex)
            {
                driver.Navigate().Refresh();
                return ex.Message;
            }
        }
    }
}
