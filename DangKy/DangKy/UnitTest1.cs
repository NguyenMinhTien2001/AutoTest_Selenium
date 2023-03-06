using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit.Abstractions;
using System.Threading;

namespace DangKy
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
            //mật khẩu không có ít nhất 1 chữ viết hoa
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangKy = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[2]/a"));
            btnDangKy.Click();

            var fullname = chromeDriver.FindElement(By.Name("FullName"));
            fullname.Clear();
            fullname.SendKeys("user1");

            var username  = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user1");

            var email = chromeDriver.FindElement(By.Name("Email"));
            email.Clear();
            email.SendKeys("mtien1002@gmail.com");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("abc@123");

            var confirmPassword = chromeDriver.FindElement(By.Name("ConfirmPassword"));
            confirmPassword.Clear();
            confirmPassword.SendKeys("abc@123");

            var dangky = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng ký']"));
            dangky.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//div/div/div[2]/div/div/form/div/ul/li")).Text;
            output.WriteLine(check);
            if (check.Equals("Passwords must have at least one uppercase ('A'-'Z')."))
            {
                output.WriteLine("Pass");
            }
            else
            {
                output.WriteLine("Fail");
            }

            //chromeDriver.Close();
        }
        [Fact]
        public void Test2()
        {
            //Đăng ký tài khoản mới (mật khẩu không có ít nhất 1 ký tự đặc biệt)
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();


            var btnDangKy = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[2]/a"));
            btnDangKy.Click();

            var fullname = chromeDriver.FindElement(By.Name("FullName"));
            fullname.Clear();
            fullname.SendKeys("user1");

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user1");

            var email = chromeDriver.FindElement(By.Name("Email"));
            email.Clear();
            email.SendKeys("mtien1002@gmail.com");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc123");

            var confirmPassword = chromeDriver.FindElement(By.Name("ConfirmPassword"));
            confirmPassword.Clear();
            confirmPassword.SendKeys("Abc123");

            var dangky = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng ký']"));
            dangky.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//div/div/div[2]/div/div/form/div/ul/li")).Text;
            
            
            if (check.Equals("Passwords must have at least one non letter or digit character."))
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
            //Đăng ký tài khoản mới (nhập sai định dạng Email)

            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();


            var btnDangKy = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[2]/a"));
            btnDangKy.Click();

            var fullname = chromeDriver.FindElement(By.Name("FullName"));
            fullname.Clear();
            fullname.SendKeys("user1");

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user1");

            var email = chromeDriver.FindElement(By.Name("Email"));
            email.Clear();
            email.SendKeys("mtien1002gmail.com");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var confirmPassword = chromeDriver.FindElement(By.Name("ConfirmPassword"));
            confirmPassword.Clear();
            confirmPassword.SendKeys("Abc@123");

            var dangky = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng ký']"));
            dangky.Click();
            Thread.Sleep(5000);

            //chromeDriver.Close();
        }
        [Fact]
        public void Test4()
        {
            //Đăng ký tài khoản mới (không nhập Họ và tên)

            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();


            var btnDangKy = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[2]/a"));
            btnDangKy.Click();

            var fullname = chromeDriver.FindElement(By.Name("FullName"));
            fullname.Clear();
            fullname.SendKeys("");

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user1");

            var email = chromeDriver.FindElement(By.Name("Email"));
            email.Clear();
            email.SendKeys("mtien1002@gmail.com");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var confirmPassword = chromeDriver.FindElement(By.Name("ConfirmPassword"));
            confirmPassword.Clear();
            confirmPassword.SendKeys("Abc@123");

            var dangky = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng ký']"));
            dangky.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//div/div/div[2]/div/div/form/div/ul/li")).Text;


            if (check.Equals("Please enter your full name ."))
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
        public void Test5()
        {
            //Đăng ký tài khoản mới (không nhập Tên đăng nhập)
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();


            var btnDangKy = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[2]/a"));
            btnDangKy.Click();

            var fullname = chromeDriver.FindElement(By.Name("FullName"));
            fullname.Clear();
            fullname.SendKeys("user1");

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("");

            var email = chromeDriver.FindElement(By.Name("Email"));
            email.Clear();
            email.SendKeys("mtien1002@gmail.com");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var confirmPassword = chromeDriver.FindElement(By.Name("ConfirmPassword"));
            confirmPassword.Clear();
            confirmPassword.SendKeys("Abc@123");

            var dangky = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng ký']"));
            dangky.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//div/div/div[2]/div/div/form/div/ul/li")).Text;
            if (check.Equals("Please enter username."))
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
        public void Test6()
        {
            //Đăng ký tài khoản mới (nhập trùng email đã đăng ký tài khoản)
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangKy = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[2]/a"));
            btnDangKy.Click();

            var fullname = chromeDriver.FindElement(By.Name("FullName"));
            fullname.Clear();
            fullname.SendKeys("user1");

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user2");

            var email = chromeDriver.FindElement(By.Name("Email"));
            email.Clear();
            email.SendKeys("mtien1002@gmail.com");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var confirmPassword = chromeDriver.FindElement(By.Name("ConfirmPassword"));
            confirmPassword.Clear();
            confirmPassword.SendKeys("Abc@123");

            var dangky = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng ký']"));
            dangky.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//*[contains(text(),'is already taken')]")).Text;
            if (check.Contains("is already taken") )
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
        public void Test7()
        {
            //Đăng ký tài khoản mới (nhập trùng username đã đăng ký tài khoản)
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();


            var btnDangKy = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[2]/a"));
            btnDangKy.Click();

            var fullname = chromeDriver.FindElement(By.Name("FullName"));
            fullname.Clear();
            fullname.SendKeys("user1");

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user1");

            var email = chromeDriver.FindElement(By.Name("Email"));
            email.Clear();
            email.SendKeys("mtien1002@gmail.com");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var confirmPassword = chromeDriver.FindElement(By.Name("ConfirmPassword"));
            confirmPassword.Clear();
            confirmPassword.SendKeys("Abc@123");

            var dangky = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng ký']"));
            dangky.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//*[contains(text(),'is already taken')]")).Text;
            if (check.Contains("is already taken") && check.Contains("Name"))
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