using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinNewProjectMobile.ViewModels;
using XamarinNewProjectMobile.Views;

namespace XamarinNewProjectMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
