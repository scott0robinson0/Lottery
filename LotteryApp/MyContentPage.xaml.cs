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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LotteryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MyContentPage : Page
    {
        public MyContentPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            tbName.Text = App.customer.Name;
            tbPhone.Text = App.customer.Phone;
            tbEmail.Text = App.customer.Email;

            App.euro.Numbers = App.euro.Numbers.SortHighestToLowest();
            App.euro.LuckyStar = App.euro.LuckyStar.SortHighestToLowest();

            tbNum1.Text = App.euro.Numbers[0].ToString();
            tbNum2.Text = App.euro.Numbers[1].ToString();
            tbNum3.Text = App.euro.Numbers[2].ToString();
            tbNum4.Text = App.euro.Numbers[3].ToString();
            tbNum5.Text = App.euro.Numbers[4].ToString();
            tbNum6.Text = App.euro.Numbers[5].ToString();

            tbLuc1.Text = App.euro.LuckyStar[0].ToString();
            tbLuc2.Text = App.euro.LuckyStar[1].ToString();

            App.lotto.Numbers = App.lotto.Numbers.SortLowestToHighest();

            tbNum21.Text = App.lotto.Numbers[0].ToString();
            tbNum22.Text = App.lotto.Numbers[1].ToString();
            tbNum23.Text = App.lotto.Numbers[2].ToString();
            tbNum24.Text = App.lotto.Numbers[3].ToString();
            tbNum25.Text = App.lotto.Numbers[4].ToString();
            tbNum26.Text = App.lotto.Numbers[5].ToString();

            tbBon.Text = App.lotto.BonusBall.ToString();
        }

    }
}
