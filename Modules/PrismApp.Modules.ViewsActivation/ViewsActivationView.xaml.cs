using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrismApp.Modules.ViewsActivation
{
    /// <summary>
    /// Interaction logic for ViewsActivationView.xaml
    /// </summary>
    public partial class ViewsActivationView : UserControl
    {
        private IContainerExtension container;
        private IRegionManager regionManager;
        private IRegion region;

        private ViewA viewA;
        private ViewB viewB;

        public ViewsActivationView(IContainerExtension container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;

            InitializeComponent();
        }

        private void ViewsActivationView_Loaded(object sender, RoutedEventArgs e)
        {
            region = regionManager.Regions[ViewsActivationModule.ViewsActivationRegion];

            viewA = container.Resolve<ViewA>();
            viewB = container.Resolve<ViewB>();

            region.Add(viewA);
            region.Add(viewB);
            Clear();
        }

        private void btnShowViewA_Click(object sender, RoutedEventArgs e)
        {
            region.Activate(viewA);
        }

        private void btnShowViewB_Click(object sender, RoutedEventArgs e)
        {
            region.Activate(viewB);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            region.Deactivate(viewA);
            region.Deactivate(viewB);
        }
    }
}
