using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeDetailPage : TabbedPage
	{
		public RecipeDetailPage()
		{
			InitializeComponent ();
        }
	}
}