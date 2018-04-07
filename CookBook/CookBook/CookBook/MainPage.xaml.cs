using System;
using Xamarin.Forms;

namespace CookBook
{
	public partial class MainPage : MasterDetailPage
    {
        public MainPage()
		{
            InitializeComponent();

            // Below code is implemented in xaml
            //var menuItems = new List<MenuItem>();
            //menuItems.Add(new MenuItem() { Title = "Home Page", Icon = "icon.png", TargetType = typeof(Views.HomePage)});
            //menuItems.Add(new MenuItem() { Title = "Categories", Icon = "icon.png", TargetType = typeof(Views.CategoriesPage) });
            //navigationList.ItemsSource = menuItems;
            //Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                navigationList.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
