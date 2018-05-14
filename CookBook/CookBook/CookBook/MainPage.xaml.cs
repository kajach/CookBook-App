using System;
using Xamarin.Forms;

namespace CookBook
{
	public partial class MainPage : MasterDetailPage
    {
        public MainPage()
		{
            InitializeComponent();
        }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MenuItem item)
            {
                //((ListView)sender).SelectedItem = null;
                var root = Detail.Navigation.NavigationStack[0];
                Detail.Navigation.InsertPageBefore((Page)Activator.CreateInstance(item.TargetType), root);
                await Detail.Navigation.PopToRootAsync();
                IsPresented = false;
            }
        }
    }
}
