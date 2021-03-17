using System.ComponentModel;
using Test2.ViewModels;
using Xamarin.Forms;

namespace Test2.Views
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