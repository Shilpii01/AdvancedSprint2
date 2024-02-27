using AdvancedTaskSpecflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskSpecflow.Pages.Components.ProfileOverview
{
    public class ManageListingComponent:BaseClass
    {

        private IWebElement TitleBox;
        private IWebElement DescriptionBox;
        private IWebElement CategoryBox;
        private IWebElement SubcategoryBox;
        private IWebElement AddTagsBox;
        private IWebElement HourlyBasisBox;
        private IWebElement ClickOneOffBox;
        private IWebElement PopUpMessage;
        private IWebElement ClickOnsite;
        private IWebElement ClickOnline;
        private IWebElement StartDateBox;
        private IWebElement EndDateBox;
        private IWebElement SelectedDayBox;
        private IWebElement StartTimeBox;
        private IWebElement EndTimeBox;
        private IWebElement ClickCredit;
        private IWebElement EnterCharge;
        private IWebElement ClearTag;
        private IWebElement SaveButton;
        private IWebElement ShareSkillDeleteIcon;
        private IWebElement ClickYes;
        private readonly string Message = "";
        private IWebElement UpdateShareSkillIcon;
        private IWebElement ManageListingTab;
        private IWebElement SkillTitle;
        private IWebElement ActivateDeactivateToggle;


        public void renderComponents()
        {
            TitleBox = driver.FindElement(By.Name("title"));
            DescriptionBox = driver.FindElement(By.Name("description"));
            CategoryBox = driver.FindElement(By.Name("categoryId"));
            SubcategoryBox = driver.FindElement(By.Name("subcategoryId"));
            AddTagsBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            HourlyBasisBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            ClickOneOffBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            ClickOnsite = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
            ClickOnline = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            EndDateBox = driver.FindElement(By.Name("endDate"));
            SelectedDayBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
            StartTimeBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
            EndTimeBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
            ClickCredit = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
            EnterCharge = driver.FindElement(By.Name("charge"));
            ClearTag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/span[2]/a[last()]"));
            SaveButton = driver.FindElement(By.XPath("//input[@type='button'][@value='Save']"));
            ActivateDeactivateToggle = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div"));



        }

    
        public void renderUpdateShareSkillIcon()
        {
            try
            {

                UpdateShareSkillIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ClickonUpdateShareSkill()
        {
            renderUpdateShareSkillIcon();
            Thread.Sleep(2000);
            Thread.Sleep(4000);
            UpdateShareSkillIcon.Click();
            Thread.Sleep(4000);

        }

        public void UpdateShareSkill(string Title, string Description, string Category, string Subcategory, string Tagone, string Tagtwo, string EndDate, string StartTime, string EndTime, string Charge)
        {
            renderComponents();
           
            TitleBox.Clear();
            TitleBox.SendKeys(Title);
            DescriptionBox.Clear();
            DescriptionBox.SendKeys(Description);
            Thread.Sleep(1000);
            CategoryBox.Click();
            Thread.Sleep(1000);
            CategoryBox.SendKeys(Category);
            CategoryBox.Click();
            Thread.Sleep(1000);            
            SubcategoryBox.Click();
            Thread.Sleep(1000);
            SubcategoryBox.SendKeys(Subcategory);
            SubcategoryBox.Click();
            Thread.Sleep(2000);           
            ClearTag.Click();
            Thread.Sleep(1000);
            AddTagsBox.SendKeys(Tagone);
            AddTagsBox.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            AddTagsBox.SendKeys(Tagtwo);
            AddTagsBox.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            EndDateBox.Click();
            EndDateBox.SendKeys(EndDate);
            SelectedDayBox.Click();
            StartTimeBox.Click();
            Thread.Sleep(1000);
            StartTimeBox.SendKeys(StartTime);
            Thread.Sleep(2000);
            EndTimeBox.Click();
            EndTimeBox.SendKeys(EndTime);
            Thread.Sleep(1000);          
            ClickCredit.Click();          
            EnterCharge.Click();
            EnterCharge.SendKeys(Charge);
            Thread.Sleep(1000);          
            SaveButton.Click();
        }
        public void renderDeleteIcon()
        {
            try
            {
                ShareSkillDeleteIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDeleteConfirmation()
        {
            try
            {

                ClickYes = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void DeleteShareSkill()
        {
            renderDeleteIcon();
            ShareSkillDeleteIcon.Click();
            Thread.Sleep(2000);
            renderDeleteConfirmation();
            ClickYes.Click();
        }
        public void renderMessage()
        {
            try
            {
                PopUpMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public string GetPopUpMessageText()
        {
            renderMessage();
            Thread.Sleep(2000);
            string Message = PopUpMessage.Text;
            return Message;
        }

       
    }
}
