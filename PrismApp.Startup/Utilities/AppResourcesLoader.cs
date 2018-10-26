using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismApp.Startup.Utilities
{
    public static class AppResourcesLoader
    {
        private static readonly string resourcesPath = @"pack://application:,,,/PrismApp.Core.UI;component/Resources/";

        public static void Load(Uri uri)
        {
            var generic = new ResourceDictionary
            {
                Source = uri
            };
            Application.Current.Resources.MergedDictionaries.Add(generic);
        }

        public static void Load(string resourceFile)
        {
            var uri = new Uri(resourcesPath + resourceFile);
            Load(uri);
        }

        public static void LoadColors()
        {
            Load("Colors.xaml");
        }

        public static void LoadStyles()
        {
            Load("Styles.xaml");
        }
    }
}
