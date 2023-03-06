
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit.Abstractions;
using System.Threading;

namespace DangNhap
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        public void Test1()
        {
            //Không nhập tên hoặc mật khẩu
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangNhap = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[3]/a[1]"));
            btnDangNhap.Click();

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[contains(text(),'Đăng nhập')]"));
            dangnhap.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]")).Text;

            if (check.Equals("Username or password empty."))
            {
                output.WriteLine("True");
            }
            else
            {
                output.WriteLine("false");
            }
            chromeDriver.Close();
        }
        [Fact]
        public void Test2()
        {
            //Đăng nhập sai tên tài khoản hoặc tài khoản chưa được đăng ký
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangNhap = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[3]/a[1]"));
            btnDangNhap.Click();

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user3");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[contains(text(),'Đăng nhập')]"));
            dangnhap.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]")).Text;

            if (check.Equals("Invalid username or Username not sign."))
            {
                output.WriteLine("True");
            }
            else
            {
                output.WriteLine("false");
            }
            chromeDriver.Close();
        }
        [Fact]
        public void Test3()
        {
            //Đăng nhập sai mật khẩu 
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangNhap = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[3]/a[1]"));
            btnDangNhap.Click();

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user2");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("abc@12");

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[contains(text(),'Đăng nhập')]"));
            dangnhap.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]")).Text;

            if (check.Equals("Invalid password."))
            {
                output.WriteLine("True");
            }
            else
            {
                output.WriteLine("false");
            }
            chromeDriver.Close();
        }
        [Fact]
        public void Test4()
        {
            //Đăng nhập thành công
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangNhap = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[3]/a[1]"));
            btnDangNhap.Click();

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user2");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[contains(text(),'Đăng nhập')]"));
            dangnhap.Click();
            Thread.Sleep(5);

            var trangchu = chromeDriver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/li[1]/a/i"));
            if (trangchu.Displayed)
            {
                output.WriteLine("True");
            }
            else
            {
                output.WriteLine("false");
            }
            chromeDriver.Close();
        }
    }
}
