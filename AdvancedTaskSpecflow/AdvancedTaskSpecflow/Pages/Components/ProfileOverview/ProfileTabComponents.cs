
using AdvancedTaskSpecflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskSpecflow.Pages.Components.ProfileOverview
{
    public class ProfileTabComponents : BaseClass
    {
        private IWebElement EducationTab;
        private IWebElement CertificationTab;
        private IWebElement ManageListingTab;
        private IWebElement ManageRequestsTab;
        private IWebElement GoToChangePassword;
        private IWebElement ProfileDescription;
        private IWebElement SearchSkillIcon;


        public void renderComponents()
        {
            try
            {
                EducationTab = driver.FindElement(By.XPath("//*[contains(text(), 'Education')][@data-tab=\"third\"]"));
                CertificationTab = driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
                ManageListingTab = driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]"));
                ManageRequestsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]"));
                GoToChangePassword = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
                ProfileDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void renderSearchSkillIconComponents()
        {
            try
            {
                
                SearchSkillIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/div[1]/div[1]/i[1]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ClickManageListingTab()
        {
           renderComponents();
            ManageListingTab.Click();
            Thread.Sleep(2000);

        }

        public void CLickManageRequestsTab()
        {
            renderComponents();
            ManageRequestsTab.Click();
            Thread.Sleep(2000);
        }

        public void ClickCertificationTab()
        {
            renderComponents();
            Thread.Sleep(1000);
            CertificationTab.Click();
            Thread.Sleep(1000);


        }

        public void ClickprofileDescription()
        {
            renderComponents();
            ProfileDescription.Click();
            Thread.Sleep(1000);
        }

        public void ClickProfileIcon()
        {
            renderComponents();
            GoToChangePassword.Click();
            Thread.Sleep(1000);
        }

        public void ClickEducationTab()
        {
            renderComponents();
            Thread.Sleep(2000);
            EducationTab.Click();

            Thread.Sleep(1000);
        }
       

        public void ClickSearchSkillIcon()
        {


            renderSearchSkillIconComponents();
            Thread.Sleep(1000);
            SearchSkillIcon.Click();
            Thread.Sleep(1000);

        }
        


    }
}
