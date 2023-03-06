using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit.Abstractions;
using System.Threading;
using System.Collections.Generic;
using System;
using System.Linq;

namespace DatHang
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
            //Để trống số điện thoại và địa chỉ
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

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[contains(text(),'Đăng nhập')]"));
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


            var dathang = chromeDriver.FindElement(By.ClassName("dropdown"));
            dathang.Click();

            var giaodich = chromeDriver.FindElement(By.LinkText("Giao Hàng Tận nơi"));
            giaodich.Click();

            var bntsave = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/form[1]/div[1]/div[6]/div[1]/input[1]"));
            bntsave.Click();

            var check = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]")).Text;

            if (check.Equals("Phone or Address is empty."))
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
            //Số điện thoại nhập sai cú pháp
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

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[contains(text(),'Đăng nhập')]"));
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


            var dathang = chromeDriver.FindElement(By.ClassName("dropdown"));
            dathang.Click();

            var giaodich = chromeDriver.FindElement(By.LinkText("Giao Hàng Tận nơi"));
            giaodich.Click();

            var phone = chromeDriver.FindElement(By.Name("PhoneNumber"));
            phone.Clear();
            phone.SendKeys("09038804a#");

            var dc = chromeDriver.FindElement(By.Name("Address"));
            dc.Clear();
            dc.SendKeys("113 Cảnh sát");

            var bntsave = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/form[1]/div[1]/div[6]/div[1]/input[1]"));
            bntsave.Click();

            var check = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]")).Text;

            if (check.Equals("Invalid phonenumber."))
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
            //Số điện thoại không quá 13
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

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[contains(text(),'Đăng nhập')]"));
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


            var dathang = chromeDriver.FindElement(By.ClassName("dropdown"));
            dathang.Click();

            var giaodich = chromeDriver.FindElement(By.LinkText("Giao Hàng Tận nơi"));
            giaodich.Click();

            var phone = chromeDriver.FindElement(By.Name("PhoneNumber"));
            phone.Clear();
            phone.SendKeys("09038804671234");

            var dc = chromeDriver.FindElement(By.Name("Address"));
            dc.Clear();
            dc.SendKeys("113 Cảnh sát");

            var bntsave = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/form[1]/div[1]/div[6]/div[1]/input[1]"));
            bntsave.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]")).Text;

            if (check.Equals("Phone Number too long. Must lower 13."))
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
            //Đặt hàng thành công
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

            var dangnhap = chromeDriver.FindElement(By.XPath("//button[contains(text(),'Đăng nhập')]"));
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


            var dathang = chromeDriver.FindElement(By.ClassName("dropdown"));
            dathang.Click();

            var giaodich = chromeDriver.FindElement(By.LinkText("Giao Hàng Tận nơi"));
            giaodich.Click();

            var phone = chromeDriver.FindElement(By.Name("PhoneNumber"));
            phone.Clear();
            phone.SendKeys("0903880467");

            var dc = chromeDriver.FindElement(By.Name("Address"));
            dc.Clear();
            dc.SendKeys("113 Cảnh sát");

            var bntsave = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/form[1]/div[1]/div[6]/div[1]/input[1]"));
            bntsave.Click();
            Thread.Sleep(5);

            var check = chromeDriver.FindElement(By.XPath("//body/section[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]")).Text;

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