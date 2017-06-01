using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Core.ViewModels.Services.Interfaces;
using Xamarin.Forms;

namespace FluentToDo.Services
{
    public class ServiceLocator : IServiceLocator
    {
        public T Get<T>() where T : new()
        {
            return DependencyService.Get<T>();
        }

        public void Register<T>(T implementation) where T : new()
        {
            DependencyService.Register<T>();
        }
    }
}
