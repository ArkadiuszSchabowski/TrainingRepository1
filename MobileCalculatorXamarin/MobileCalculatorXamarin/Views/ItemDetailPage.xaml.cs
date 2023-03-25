using MobileCalculatorXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileCalculatorXamarin.Views
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