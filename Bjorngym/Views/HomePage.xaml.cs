using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Bjorngym.ViewModels;
using Bjorngym.Models;

namespace Bjorngym.Views
{
    [DesignTimeVisible(true)]
    public partial class HomePage : ContentPage
    {
        PromotionViewModel viewModel;

        public HomePage()
        {
            Title = "Home";
            InitializeComponent();
            BindingContext = viewModel = new PromotionViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Promotion;
            if (item == null)
                return;

            //await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            //PromotionListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Promotions.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
