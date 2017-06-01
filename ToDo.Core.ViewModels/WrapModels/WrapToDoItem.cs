using System.Windows.Input;
using TodoApi.Models;

namespace ToDo.Core.ViewModels.WrapModels
{
    public class WrapToDoItem 
    {
        private MainViewModel _mainViewModel;
        private TodoItem _todoItem;

        public WrapToDoItem(MainViewModel mainViewModel, TodoItem todoItem)
        {
            _mainViewModel = mainViewModel;
            _todoItem = todoItem;
        }

        public ICommand CommandDelete
        {
            get
            {
                return new Command(() =>
                {
                    _mainViewModel?.CommandDelete.Execute(_todoItem);
                });
            }
        }

    }
}
