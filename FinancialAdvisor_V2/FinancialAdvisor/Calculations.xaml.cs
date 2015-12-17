using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FinancialAdvisor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Calculations : Page
    {
        public Calculations()
        {
            this.InitializeComponent();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            try
            {
                double presentVal = Convert.ToDouble(textBox6.Text);
                double futureVal = Convert.ToDouble(textBox8.Text);
                double interest = Convert.ToDouble(textBox7.Text)/100; // input is in percent
                double ans;

                double num = Math.Log(futureVal / presentVal);
                double denom = Math.Log(1 + interest);
                ans = num / denom;

                string ans1 = ans.ToString("#.##"); // two decimal places only

                textBox5.Text = ans1 + " years";
            }
            catch (Exception)
            {

                textBox5.Text = "error!";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
