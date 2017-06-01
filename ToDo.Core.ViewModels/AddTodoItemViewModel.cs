using System.Windows.Input;
using ToDo.Core.ViewModels.Base;
using TodoApi.Models;

namespace ToDo.Core.ViewModels
{
    public class AddTodoItemViewModel : BaseViewModel
    {
        private string _itemName;

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; Raise(); }
        }

        public ICommand CommandSave
        {
            get
            {
                return new Command(() =>
                {
                    CacheService.Add(new TodoItem()
                    {
                        IsComplete = false,
                        Name = ItemName                        
                    });
                });
            }
        }
    }
}
