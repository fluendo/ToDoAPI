using System.Windows;
using ToDo.Core.ViewModels;
using ToDo.Core.ViewModels.Base;

namespace FluentToDo.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
