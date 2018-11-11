using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismApp.Core.Services
{
    public interface IAppResourcesLoader
    {
        Collection<ResourceDictionary> Resources { get; }
        void Load(Uri uri);
        void Load(string resourcePath);
        void Load(string assemblyName, string resourcePath);
    }
}
