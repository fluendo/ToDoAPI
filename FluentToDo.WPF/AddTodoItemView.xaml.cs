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
using System.Windows.Shapes;
using ToDo.Core.ViewModels;
using ToDo.Core.ViewModels.Base;

namespace FluentToDo.WPF
{
    /// <summary>
    /// Lógica de interacción para AddTodoItemView.xaml
    /// </summary>
    public partial class AddTodoItemView : Window, IView
    {
        public AddTodoItemView()
        {
            InitializeComponent();
            DataContext = new AddTodoItemViewModel();
        }
    }
}
