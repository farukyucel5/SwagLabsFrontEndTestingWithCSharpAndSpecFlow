using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using SwagLabAssessment2.Drivers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabAssessment2.Pages
{
    public class SwagLabPage:DriverClass
    {
        IWebElement usernameBox => Driver.FindElement(By.XPath("//input[@id='user-name']"));
        public void typeInTheUsername(string username) => usernameBox.SendKeys(username);

        IWebElement passwordBox => Driver.FindElement(By.XPath("//input[@id='password']"));
        public void typeInThePassword(string password) => passwordBox.SendKeys(password);

        public IWebElement loginBtn => Driver.FindElement(By.XPath("//input[@id='login-button']"));
        IWebElement addToCartBtn => Driver.FindElement(By.XPath("(//*[text()='Add to cart'])[1]"));
        IWebElement RemoveBtn => Driver.FindElement(By.XPath("//*[text()='Remove']"));
        
        IWebElement ShoppingCart => Driver.FindElement(By.XPath("//*[@*='shopping_cart_badge']"));
        IWebElement productAdded => Driver.FindElement(By.XPath("//*[text()='Sauce Labs Backpack']"));
        public void AssertThatIsNotVisible() => Assert.IsFalse(productAdded.Displayed);

        IWebElement dropdown => Driver.FindElement(By.XPath("//select[@data-test='product_sort_container']"));

        public void selectAnOption(string value)
        {
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByValue(value);

        }
        
        IWebElement openMenuBtn => Driver.FindElement(By.Id("react-burger-menu-btn"));
        IWebElement aboutBtn => Driver.FindElement(By.Id("about_sidebar_link"));
        IWebElement logOutBtn => Driver.FindElement(By.Id("logout_sidebar_link"));


        public void clicking(String element)
        {

            if (element.Equals("openMenu"))
                openMenuBtn.Click();
            if (element.Equals("loginBtn"))
                loginBtn.Click();
            if (element.Equals("addToCartBtn"))
                addToCartBtn.Click();
            if (element.Equals("removeBtn"))
                RemoveBtn.Click();
            if (element.Equals("cart"))
                ShoppingCart.Click();
            if (element.Equals("aboutBtn"))
                aboutBtn.Click();
            if (element.Equals("loggedOut"))
                logOutBtn.Click();

          
        }

        IList<IWebElement> productList => Driver.FindElements(By.XPath("//div[@class='inventory_item_name']"));
        IList<IWebElement> priceList => Driver.FindElements(By.XPath("//div[@class='inventory_item_price']"));

        public void sortingProducts(String value)
        {
            List<String> stringList = new List<String>();

           
           

            if (value.Equals("za"))
            {
                foreach (IWebElement each in productList)
                {
                    stringList.Add(each.Text);
                    Console.WriteLine(each.Text);

                }
                String ActualProductTextatatTheEnd = stringList.ElementAt(stringList.Count - 1);
                stringList.Sort();
                String ProductTextAtTheBeginingAfterSorting = stringList.ElementAt(0);
                Assert.IsTrue(ActualProductTextatatTheEnd.Equals(ProductTextAtTheBeginingAfterSorting));

            }
            if (value.Equals("lohi")){
                List<int> prices = new List<int>();
                foreach (IWebElement each in priceList){
                    
                    String eachone= each.Text.Replace("$", "");
                    eachone=eachone.Replace(".", "");
                    int intEachone = Convert.ToInt32(eachone);
                    prices.Add(intEachone);
                }

                int actualValueatTheBegining=prices.ElementAt(0);

                prices.Sort();

                int expectedValueAtTheBeging = prices.ElementAt(0);

                Assert.AreEqual(expectedValueAtTheBeging, actualValueatTheBegining);
            }
            if (value.Equals("hilo"))
            {
                List<int> prices = new List<int>();
                foreach (IWebElement each in priceList){

                    String eachone = each.Text.Replace("$", "");
                    eachone = eachone.Replace(".", "");
                    int intEachone = Convert.ToInt32(eachone);
                    prices.Add(intEachone);
                }

                int actualValueatTheBegining = prices.ElementAt(0);

                prices.Sort();

                int valueAtTheEndAfterSorting = prices.ElementAt(prices.Count-1);

                Assert.AreEqual(valueAtTheEndAfterSorting, actualValueatTheBegining);
             }
        }

        






    }
}
