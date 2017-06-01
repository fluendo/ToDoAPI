using TodoApi.Models;

namespace ToDo.Core.ViewModels.Services.Interfaces
{
    public interface ICacheService
    {
        void Add(TodoItem item);
        
    }
}
