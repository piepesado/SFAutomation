using ApexPortal.Login.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace SFAutomation.Pages
{
    /// <summary>
    /// The login page for the pinSight Hotel platform.
    /// </summary>
    public class LoginPage : BasePage
    {

        [FindsBy(How = How.Id, Using = "nativeInput")]
        private IWebElement _username;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement _passWord;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement _cid;


        [FindsBy(How = How.Id, Using = "SubmitButton")]
        private IWebElement _signInButton;

        public string Username
        {
            get
            {
                return _username.Text;
            }
            set
            {
                _username.SendKeys(value);
            }
        }

        public string Password
        {
            set
            {
                _passWord.SendKeys(value);
            }
        }

        public string Cid
        {
            set
            {
                _cid.SendKeys(value);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver"></param>
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Navigate to the page.
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static LoginPage NavigateTo(IWebDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver));
            }

            driver.Url = ConfigurationManager.AppSettings["DEV_URL"];
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.Contains("Login"));
            return new LoginPage(driver);
        }

        /// <summary>
        /// Click the login button.
        /// </summary>
        /// <returns></returns>
        public HomePage Login()
        {
            _signInButton.Click();
            return new HomePage(_driver);
        }
        /// <summary>
        /// Log into the application using the given credentials.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public HomePage EnterCredentials(string username, string password, string cid)
        {
            this.Username = username;
            this.Password = password;
            this.Cid = cid;
            HomePage HomePage = Login();
            return HomePage;
        }
    }
}
