using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TodoApi.Models;

namespace ToDo.Core.ViewModels.WrapModels
{
    public class WrapToDoItem : INotifyPropertyChanged
    {
        private MainViewModel _mainViewModel;
        private TodoItem _todoItem;

        public TodoItem Item
        {
            get
            {
                return _todoItem;
            }
        }

        public WrapToDoItem(MainViewModel mainViewModel, TodoItem todoItem)
        {
            _mainViewModel = mainViewModel;
            _todoItem = todoItem;
        }
        
        public bool IsCompleted
        {
            get { return _todoItem.IsComplete; }
            set
            {
                _todoItem.IsComplete = value;
                Raise();
                _mainViewModel?.CommandUpdate(_todoItem);
            }
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void Raise([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}

