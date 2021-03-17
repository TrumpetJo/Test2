using System;
using System.Collections.Generic;
using System.ComponentModel;
using Test2.Models;
using Test2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}