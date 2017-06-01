using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FluentToDo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTodoItemView : ContentPage
    {
        public AddTodoItemView()
        {
            InitializeComponent();
            BindingContext = new AddTodoItemViewModel();
        }
    }
}
