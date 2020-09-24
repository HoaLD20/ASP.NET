using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenQA.Selenium.Firefox;

namespace SeleniumHowKTeam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirefoxDriver firefoxDriver = new FirefoxDriver();
            //firefoxDriver.Navigate().GoToUrl("ww.fb.com");
            //firefoxDriver.Url = "https://www.facebook.com/";
            firefoxDriver.Url = "https://www.howkteam.vn/";
            firefoxDriver.Navigate();

            //tìm đối tượng theo ID
            var searchBar = firefoxDriver.FindElementById("fa fa-search");
            //gõ giá trị cần tìm vào thanh tìm kiếm
            searchBar.Click();

           
        }
    }
}
