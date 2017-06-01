using System;
using System.Collections.Generic;
using ToDo.Core.ViewModels.Services.Interfaces;
using TodoApi.Models;

namespace FluentToDo.Services
{
    public class CacheService : ICacheService
    {
        public void Add(TodoItem item)
        {
            //TODO: To implement
        }

        public IEnumerable<TodoItem> All()
        {
            throw new NotImplementedException();
        }

        public void Delete(TodoItem item)
        {
            //TODO: To implement
        }

        public void Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
