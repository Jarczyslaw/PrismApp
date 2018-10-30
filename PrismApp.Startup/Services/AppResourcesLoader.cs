using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismApp.Startup.Services
{
    public class AppResourcesLoader : IAppResourcesLoader
    {
        public Collection<ResourceDictionary> Resources { get; private set; }

        public AppResourcesLoader()
        {
            Resources = Application.Current.Resources.MergedDictionaries;
        }

        public void Load(Uri uri)
        {
            if (Resources.Any(r => r.Source == uri))
                return;

            var generic = new ResourceDictionary
            {
                Source = uri
            };
            Resources.Add(generic);
        }

        public void Load(string resourcePath)
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            Load(assemblyName, resourcePath);
        }

        public void Load(string assemblyName, string resourcePath)
        {
            var uri = new Uri(GetResourcesPath(assemblyName, resourcePath));
            Load(uri);
        }

        private string GetResourcesPath(string assemblyName, string resourcePath)
        {
            return $"pack://application:,,,/{assemblyName};component/{resourcePath}";
        }
    }
}
