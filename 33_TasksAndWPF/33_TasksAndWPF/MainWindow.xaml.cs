using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace _33_TasksAndWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty property = DependencyProperty.RegisterAttached(
            "Html", typeof(string), typeof(MainWindow), new FrameworkPropertyMetadata(OnHtmlChanged));
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myBut_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Debug.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
                HttpClient client = new HttpClient();
                //string html = client.GetStringAsync("http://ipv4.download.thinkbroadband.com/2MB.zip").Result;
                string awesomeDone = "Awesome done!";
                string legendaryBegin = "Legendary Begin!";

                myBut.Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine($"Thread Id {Thread.CurrentThread.ManagedThreadId} owns the button");

                    if (myBut.Content.ToString().Equals(awesomeDone))
                    {
                        myBut.Content = legendaryBegin;
                    }
                    else
                    {
                        myBut.Content = awesomeDone;
                    }
                });
            });
        }

        private async void myBut_ClickAsc(object sender, RoutedEventArgs e)
        {
            string myHtml = "Biu~~";
            Debug.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");

            await Task.Run(async () =>
            {
                HttpClient client = new HttpClient();
                myHtml = client.GetStringAsync("https://www.google.com").Result;
                
            });

            string awesomeDone = "Awesome done!";
            string legendaryBegin = "Legendary Begin!";

            myBut.Dispatcher.Invoke(() =>
            {
                Debug.WriteLine($"Thread Id {Thread.CurrentThread.ManagedThreadId} owns the button");

                if (myBut.Content.ToString().Equals(awesomeDone))
                {
                    myBut.Content = legendaryBegin;
                }
                else
                {
                    myBut.Content = awesomeDone;
                }
            });

            myWebBrowser.SetValue(property, myHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser browser = dependencyObject as WebBrowser;

            if (browser != null)
            {
                browser.NavigateToString(e.NewValue as string);
            }
        }
    }
}
