﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;
using DbEntities.Models;
using MobileApplication.Models;
using MobileApplication.Views;
using MobileApplication.Services;
using MobileApplication.Services.Rest;

namespace MobileApplication.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        private Item _selectedItem;

        public ObservableCollection<Category> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Item> ItemTapped { get; }

        private readonly IRestService<Category> RestService;

        public CategoryViewModel()
        {
            RestService = new RestService<Category>("api/Categories");
            Title = "Categories";
            Items = new ObservableCollection<Category>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Item>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;
            Items.Clear();

            try
            {
                var items = await RestService.RefreshDataAsync();

                items.ForEach(category => Items.Add(category));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        async void OnItemSelected(Item item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}