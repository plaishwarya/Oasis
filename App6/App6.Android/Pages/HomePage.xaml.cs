using App6.Android.ViewModels;
using App6.Droid.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6.Android.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            var vm = new HomeModel();
            this.BindingContext = vm;
            InitializeComponent();
            vm.Navigation = Navigation;
            BindingContext = vm;

            var testButton = this.FindByName<Button>("btntest");
            testButton.Clicked += OnClickButton;

            var sellButton = this.FindByName<Button>("btnSell");
            sellButton.Clicked += OnClickButtonSell;

            var wishListButton = this.FindByName<Button>("btnWishList");
            wishListButton.Clicked += OnClickButtonWishList;
        }
        private void OnClickButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BuyPage());
        }
        private void OnClickButtonSell(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SellPage());
        }
        private void OnClickButtonWishList(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WishListPage());
        }
    }
}