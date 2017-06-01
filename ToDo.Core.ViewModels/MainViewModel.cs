using System.Collections.ObjectModel;
using ToDo.Core.ViewModels.Base;
using TodoApi.Models;

namespace ToDo.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            _todoItems = new ObservableCollection<TodoItem>();
        }

        private ObservableCollection<TodoItem> _todoItems;

        public ObservableCollection<TodoItem> TodoItems
        {
            get { return _todoItems; }
            set { _todoItems = value; Raise(); }
        }

        public Command CommandAdd
        {
            get
            {
                return new Command(() =>
                {
                    NavigationService.NavigateTo<AddTodoItemViewModel>();
                });
            }
        }
    }
}
