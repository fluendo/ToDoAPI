using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ToDo.Core.ViewModels.Base;
using ToDo.Core.ViewModels.WrapModels;
using TodoApi.Models;


namespace ToDo.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            _todoItems = new ObservableCollection<WrapToDoItem>();
        }

        private ObservableCollection<WrapToDoItem> _todoItems;

        public ObservableCollection<WrapToDoItem> TodoItems
        {
            get { return _todoItems; }
            set { _todoItems = value; Raise(); }
        }

        public ICommand CommandRefresh
        {
            get
            {
                return new Command(async () =>
                {
                    IsBusy = true;
                    var elements = await CacheService.All();
                    foreach (var itemWrapped in elements.Select(x => new WrapToDoItem(this, x)))
                    {
                        TodoItems.Add(itemWrapped);
                    }
                    IsBusy = false;
                });
            }
        }

        public ICommand CommandAdd
        {
            get
            {
                return new Command(() =>
                {
                    NavigationService.NavigateTo<AddTodoItemViewModel>();
                });
            }
        }

        public ICommand CommandDelete
        {
            get

            {
                return new Command<TodoItem>((todoItem) =>
                {
                    CacheService.Delete(todoItem);
                });
            }
        }

        public ICommand CommandUpdate
        {
            get
            {
                return new Command<TodoItem>((todoItem) =>
                {
                    CacheService.Update(todoItem);
                });
            }
        }

    }
}