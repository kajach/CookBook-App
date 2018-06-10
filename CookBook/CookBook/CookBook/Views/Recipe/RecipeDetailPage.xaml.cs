using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeDetailPage : TabbedPage, INavigatingAware
    {
		public RecipeDetailPage()
		{
			InitializeComponent();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            foreach (var child in Children)
            {
                (child as INavigatingAware)?.OnNavigatingTo(parameters);
                (child?.BindingContext as INavigatingAware)?.OnNavigatingTo(parameters);
            }
        }
    }
}