using System.ComponentModel;
using Xamarin.Forms;
using XamarinNewProjectMobile.ViewModels;

namespace XamarinNewProjectMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}