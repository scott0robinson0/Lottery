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
using LotteryClasses;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LotteryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EuroPage : Page
    {
        public EuroPage()
        {
            this.InitializeComponent();
        }

        private void btnRandomNums_Click(object sender, RoutedEventArgs e)
        {
            int[] nums = new int[6];
            nums = Euro.RandomNum(9);

            txtNum1.Text = nums[0].ToString();
            txtNum2.Text = nums[1].ToString();
            txtNum3.Text = nums[2].ToString();
            txtNum4.Text = nums[3].ToString();
            txtNum5.Text = nums[4].ToString();
            txtNum6.Text = nums[5].ToString();
            txtLuc1.Text = nums[6].ToString();
            txtLuc2.Text = nums[7].ToString();
        }

        private async void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            App.euro.customer = App.customer;

            App.euro.Numbers[0] = Int16.Parse(txtNum1.Text);
            App.euro.Numbers[1] = Int16.Parse(txtNum2.Text);
            App.euro.Numbers[2] = Int16.Parse(txtNum3.Text);
            App.euro.Numbers[3] = Int16.Parse(txtNum4.Text);
            App.euro.Numbers[4] = Int16.Parse(txtNum5.Text);
            App.euro.Numbers[5] = Int16.Parse(txtNum6.Text);

            App.euro.LuckyStar[0] = Int16.Parse(txtLuc1.Text);
            App.euro.LuckyStar[1] = Int16.Parse(txtLuc2.Text);

            int[] combined = App.euro.Numbers.Concat(App.euro.LuckyStar).ToArray();
            if (combined.HasDuplicate())
            {
                await new MessageDialog("Duplicate numbers are not allowed.", "Retry").ShowAsync();
                Array.Clear(App.euro.Numbers, 0, App.euro.Numbers.Length);
                Array.Clear(App.euro.LuckyStar, 0, App.euro.LuckyStar.Length);
            }            
        }

    }
}
