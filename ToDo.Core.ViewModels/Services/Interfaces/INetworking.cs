using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApi.Models;

namespace ToDo.Core.ViewModels.Services.Interfaces
{
    public interface INetworking
    {
        Task<bool> Add(TodoItem item);

        Task<bool> Delete(TodoItem item);

        Task<IEnumerable<TodoItem>> All();

        Task<bool> Update(TodoItem item);
    }
}
