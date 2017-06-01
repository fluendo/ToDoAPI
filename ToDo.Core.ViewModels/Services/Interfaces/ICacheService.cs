using System.Collections.Generic;
using TodoApi.Models;

namespace ToDo.Core.ViewModels.Services.Interfaces
{
    public interface ICacheService
    {
        void Add(TodoItem item);

        void Delete(TodoItem item);

        IEnumerable<TodoItem> All();

        void Update(TodoItem item);
        
    }
}
