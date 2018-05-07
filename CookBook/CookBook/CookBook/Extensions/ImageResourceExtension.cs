using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension<ImageSource>
    {
        public string Source { get; set; }

        public ImageSource ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrEmpty(Source))
            {
                return null;
            }

            string assemblyName = GetType().GetTypeInfo().Assembly.GetName().Name;
            return ImageSource.FromResource(assemblyName + "." + Source); ;
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return (this as IMarkupExtension<ImageSource>).ProvideValue(serviceProvider);
        }
    }
}
