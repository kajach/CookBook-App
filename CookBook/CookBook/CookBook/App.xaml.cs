using CookBook.Interfaces;
using CookBook.Views;
using Prism;
using Prism.Autofac;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CookBook
{
    public partial class App : PrismApplication
    {
        private static string _dbPath;

        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        public static string DbPath
        {
            get
            {
                if (_dbPath == null)
                {
                    _dbPath = DependencyService.Get<IFileHelper>().GetLocalFilePath("CookBookDatabase.db3");
                }
                return _dbPath;
            }
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<CategoriesPage>();
            containerRegistry.RegisterForNavigation<HomePage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<RecipeDetailPage>();
            containerRegistry.RegisterForNavigation<RecipeListPage>();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
