using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
        }

        //private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    if (e.Item == null)
        //        return;

        //    ((ListView)sender).SelectedItem = null;

        //    await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
        //}

        //private async void OnSearchBarButtonPressed(object sender, ItemTappedEventArgs e)
        //{
            
        //    await DisplayAlert("Button pressed", "A button was pressed.", "OK");
        //}
    }
}