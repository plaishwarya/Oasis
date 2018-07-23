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
    public partial class SellPage : ContentPage
    {
        public SellPage()
        {
            var vm = new SellModel();
            this.BindingContext = vm;
            InitializeComponent();
 
        }
       
    }
}