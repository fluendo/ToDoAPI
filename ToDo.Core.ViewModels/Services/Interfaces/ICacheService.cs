using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApi.Models;

namespace ToDo.Core.ViewModels.Services.Interfaces
{
    public interface ICacheService
    {
        Task<bool> Add(TodoItem item);

        Task<bool> Delete(TodoItem item);

        Task<IEnumerable<TodoItem>> All();

        Task<bool> Update(TodoItem item);
        
    }
}
