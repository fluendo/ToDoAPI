using ToDo.Core.ViewModels;
using ToDo.Core.ViewModels.Base;
using Xamarin.Forms;

namespace FluentToDo
{
    public partial class MainPage : ContentPage, IView
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            
        }
    }
}
