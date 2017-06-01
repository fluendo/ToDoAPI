using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Core.ViewModels.Services.Interfaces;
using TodoApi.Models;

namespace ToDo.Core.ViewModels.Services
{
    public class CacheService : ICacheService
    {
        private readonly INetworking _networking;

        public CacheService()
        {
            _networking = new Networking();
            TodoItems = new List<TodoItem>();
        }

        public List<TodoItem> TodoItems { get; set; }


        public async Task<bool> Add(TodoItem item)
        {
            TodoItems.Add(item);
            return await _networking.Add(item);
        }

        public async Task<IEnumerable<TodoItem>> All()
        {            
            var items = await _networking.All();

            foreach(var item in items)
            {
                if(!TodoItems.Any(x => x.Key == item.Key))
                {
                    TodoItems.Add(item);
                }
            }

            return TodoItems;
        }

        public async Task<bool> Delete(TodoItem item)
        {
            var itemFind = TodoItems.FirstOrDefault(x => x.Key == item.Key);
            if(itemFind != null)
            {
                TodoItems.Remove(itemFind);
            }
                        
            return await _networking.Delete(item);
        }

        public async Task<bool> Update(TodoItem item)
        {
            var itemFind = TodoItems.FirstOrDefault(x => x.Key == item.Key);

            if(itemFind != null)
            {
                itemFind.IsComplete = item.IsComplete;
            }

            return await _networking.Update(item);
        }
    }
}
