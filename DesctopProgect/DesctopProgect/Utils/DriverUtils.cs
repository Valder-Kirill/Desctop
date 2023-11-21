using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace DesctopAuto.Utils
{
    public static class DriverUtils
    {
        private static WindowsDriver<WindowsElement>? Driver;

        public static WindowsDriver<WindowsElement> GetDriver()
        {
            try
            {
                if (Driver == null)
                {
                    var options = new AppiumOptions();

                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
                    options.AddAdditionalCapability("app", @"C:\Program Files\Notepad++\notepad++.exe");
                    options.AddAdditionalCapability("deviceName", @"WindowsPC");

                    Driver = new WindowsDriver<WindowsElement>(new Uri("http://localhost:4723/wd/hub"), options);
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                    //LogHelper.WriteMessage("Экземпляр драйвера успешно создан!");
                }
                else
                {
                    return Driver;
                }
            }
            catch (Exception ex)
            {
                //LogHelper.WriteExceprion(ex);
                throw;
            }

            return Driver;
        }
    }
}
