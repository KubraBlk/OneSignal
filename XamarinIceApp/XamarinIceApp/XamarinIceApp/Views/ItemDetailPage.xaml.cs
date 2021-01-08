using System.ComponentModel;
using Xamarin.Forms;
using XamarinIceApp.ViewModels;

namespace XamarinIceApp.Views
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