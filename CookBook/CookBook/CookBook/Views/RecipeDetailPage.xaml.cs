using CookBook.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeDetailPage : ContentPage
	{
		public RecipeDetailPage ()
		{
			InitializeComponent ();

            BindingContext = new RecipeDetailViewModel();
        }
	}
}