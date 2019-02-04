using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.Windows;

namespace SVOArt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var container = InitializeMef();
            DataContext = container.GetExportedValue<MainWindowViewModel>();
            InitializeComponent();
        }

        private CompositionContainer InitializeMef()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            return new CompositionContainer(catalog);
        }
    }
}
