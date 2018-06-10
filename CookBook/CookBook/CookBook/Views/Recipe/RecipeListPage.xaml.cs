using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeListPage : ContentPage
    {
        public RecipeListPage()
        {
            InitializeComponent();
        }

        //private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    var item = e.Item as Recipe;
        //    if (item == null)
        //        return;
                
        //    ((ListView)sender).SelectedItem = null;

        //    await Navigation.PushAsync(new RecipeDetailPage());
        //}
    }
}
