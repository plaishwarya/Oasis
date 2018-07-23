using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App6.Droid.ViewModels
{
    public class HomeModel : ContentView
    {
        public INavigation Navigation { get; internal set; }

        public HomeModel()
        {

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}