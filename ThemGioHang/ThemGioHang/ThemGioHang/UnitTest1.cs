using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit.Abstractions;
using System.Threading;


namespace ThemGioHang
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
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangNhap = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[3]/a/i"));
            btnDangNhap.Click();

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user2");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng nhập']"));
            dangnhap.Click();
            Thread.Sleep(5);

            var themGioHang = chromeDriver.FindElement(By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[1]/div/div/div/a[1]/img"));
            themGioHang.Click();

            var themGioHang1 = chromeDriver.FindElement(By.LinkText("Thêm vào giỏ hàng"));
            themGioHang1.Click();

            var check = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[1]/a")).Text;
            if (check.Contains("1"))
            {
                output.WriteLine("True");
            }
            else
            {
                output.WriteLine("False");
            }
            chromeDriver.Close();

        }
        [Fact]
        public void Test2()
        {
            //Thêm sản phẩm vào giỏ hàng(thêm đúng sản phẩm)
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangNhap = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[3]/a/i"));
            btnDangNhap.Click();

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user2");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng nhập']"));
            dangnhap.Click();
            Thread.Sleep(5);

            var banGamingHome = chromeDriver.FindElement(By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[1]/div/div/div/a[2]/p")).Text;
            output.WriteLine(banGamingHome);


            var themGioHang = chromeDriver.FindElement(By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[1]/div/div/div/a[1]/img"));
            themGioHang.Click();

            var themGioHang1 = chromeDriver.FindElement(By.LinkText("Thêm vào giỏ hàng"));
            themGioHang1.Click();

            var gioHang = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[1]/a"));
            gioHang.Click();

            var banGamingCart = chromeDriver.FindElement(By.XPath("//*[@id=\"row_ 1\"]/td[2]/h4")).Text;
            output.WriteLine(banGamingCart);

            if (banGamingHome == banGamingCart)
            {
                output.WriteLine("True");
            }
            else
            {
                output.WriteLine("False");
            }

            chromeDriver.Close();
        }
        [Fact]
        public void Test3()
        {
            //Xóa sản phẩm khỏi giỏ hàng.
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangNhap = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[3]/a/i"));
            btnDangNhap.Click();

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user2");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng nhập']"));
            dangnhap.Click();
            Thread.Sleep(5);

            var themGioHang = chromeDriver.FindElement(By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[1]/div/div/div/a[1]/img"));
            themGioHang.Click();

            var themGioHang1 = chromeDriver.FindElement(By.LinkText("Thêm vào giỏ hàng"));
            themGioHang1.Click();

            var gioHang = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[1]/a"));
            gioHang.Click();

            var xoaSanPham = chromeDriver.FindElement(By.XPath("//*[@id=\"row_ 1\"]/td[6]/a "));
            xoaSanPham.Click();

            var check = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[1]/a")).Text;
            if (check.Contains("0"))
            {
                output.WriteLine("True");
            }
            else
            {
                output.WriteLine("False");
            }

            chromeDriver.Close();
        }
        [Fact]
        public void Test4()
        {
            //Thay đổi số lượng sản phẩm trong giỏ hàng (tăng số lượng sản phẩm)
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangNhap = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[3]/a/i"));
            btnDangNhap.Click();

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user2");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng nhập']"));
            dangnhap.Click();
            Thread.Sleep(5);

            var themGioHang = chromeDriver.FindElement(By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[1]/div/div/div/a[1]/img"));
            themGioHang.Click();

            var themGioHang1 = chromeDriver.FindElement(By.LinkText("Thêm vào giỏ hàng"));
            themGioHang1.Click();

            var gioHang = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[1]/a"));
            gioHang.Click();

            var themSoLuongSP = chromeDriver.FindElement(By.XPath("//*[@id=\"row_ 1\"]/td[4]/div/a[2]"));
            themSoLuongSP.Click();

            var gioHang1 = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[1]/a"));
            gioHang1.Click();

            var soLuong = chromeDriver.FindElement(By.XPath("//*[@id=\"row_ 1\"]/td[4]/div/input")).GetAttribute("value");
            output.WriteLine(soLuong);

            var tongTien = chromeDriver.FindElement(By.XPath("//*[@id=\"row_ 1\"]/td[5]/p")).Text;
            output.WriteLine(tongTien);

            if (soLuong.Contains("2") && tongTien.Contains("460000"))
            {
                output.WriteLine("True");
            }
            else
            {
                output.WriteLine("False");
            }
            chromeDriver.Close();

        }
        [Fact]
        public void Test5()
        {
            //Thay đổi số lượng sản phẩm trong giỏ hàng (giảm số lượng sản phẩm)
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangNhap = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[3]/a/i"));
            btnDangNhap.Click();

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user2");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng nhập']"));
            dangnhap.Click();
            Thread.Sleep(5);

            var themGioHang = chromeDriver.FindElement(By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[1]/div/div/div/a[1]/img"));
            themGioHang.Click();

            var themGioHang1 = chromeDriver.FindElement(By.LinkText("Thêm vào giỏ hàng"));
            themGioHang1.Click();

            var gioHang = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[1]/a"));
            gioHang.Click();

            var giamSoLuongSP = chromeDriver.FindElement(By.XPath("/html/body/section/div/div[2]/table/tbody/tr[1]/td[4]/div/a[1]"));
            giamSoLuongSP.Click();

            var gioHang1 = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[1]/a"));
            gioHang1.Click();

            var soLuong = chromeDriver.FindElement(By.XPath("//*[@id=\"row_ 1\"]/td[4]/div/input")).GetAttribute("value");
            output.WriteLine(soLuong);

            var tongTien = chromeDriver.FindElement(By.XPath("//*[@id=\"row_ 1\"]/td[5]/p")).Text;
            output.WriteLine(tongTien);

            if (soLuong.Contains("0") && tongTien.Contains("0"))
            {
                output.WriteLine("True");
            }
            else
            {
                output.WriteLine("False");
            }

            chromeDriver.Close();

        }

        [Fact]
        public void Test6()
        {
            //Thay đổi số lượng sản phẩm trong giỏ hàng (nhap số lượng sản phẩm)
            ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "http://TakashopDoAn.somee.com";
            chromeDriver.Navigate();
            chromeDriver.Manage().Window.Maximize();

            var btnDangNhap = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[3]/a/i"));
            btnDangNhap.Click();

            var username = chromeDriver.FindElement(By.Name("UserName"));
            username.Clear();
            username.SendKeys("user2");

            var password = chromeDriver.FindElement(By.Name("Password"));
            password.Clear();
            password.SendKeys("Abc@123");

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Đăng nhập']"));
            dangnhap.Click();
            Thread.Sleep(5);

            var themGioHang = chromeDriver.FindElement(By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[1]/div/div/div/a[1]/img"));
            themGioHang.Click();

            var themGioHang1 = chromeDriver.FindElement(By.LinkText("Thêm vào giỏ hàng"));
            themGioHang1.Click();

            var gioHang = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[1]/a"));
            gioHang.Click();

            var soLuong = chromeDriver.FindElement(By.XPath("//*[@id=\"row_ 1\"]/td[4]/div/input"));
            soLuong.SendKeys("123");

            var soLuongText = chromeDriver.FindElement(By.XPath("//*[@id=\"row_ 1\"]/td[4]/div/input")).Text;

            var gioHang1 = chromeDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/div[2]/div/ul/li[1]/a"));
            gioHang1.Click();

            if (soLuongText.Contains("123"))
            {
                output.WriteLine("True");
            }
            else
            {
                output.WriteLine("False");
            }

            chromeDriver.Close();

        }
    }
}