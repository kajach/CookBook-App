using CookBook.Data;
using CookBook.Interfaces;
using CookBook.Models;
using CookBook.Services;
using Xamarin.Forms;

namespace CookBook
{
    public partial class App : Application
	{
        private static IRecipeService _recipeService;
        private static ICategoryService _categoryService;
        private static IIngredientService _ingredientService;
        private static string _dbPath;

        public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

        public static string dbPath
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


        public static IRecipeService RecipeService
        {
            get
            {
                if (_recipeService == null)
                {
                    IRepository<Recipe> recipeRepo = new BaseRepository<Recipe>(dbPath);
                    _recipeService = new RecipeService(recipeRepo);
                }
                return _recipeService;
            }
        }

        public static ICategoryService CategoryService
        {
            get
            {
                if (_categoryService == null)
                {
                    IRepository<Category> categoryRepo = new BaseRepository<Category>(dbPath);
                    _categoryService = new CategoryService(categoryRepo);
                }
                return _categoryService;
            }
        }

        public static IIngredientService IngredientService
        {
            get
            {
                if (_ingredientService == null)
                {
                    IRepository<Ingredient> ingredientRepo = new BaseRepository<Ingredient>(dbPath);
                    _ingredientService = new IngredientService(ingredientRepo);
                }
                return _ingredientService;
            }
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
