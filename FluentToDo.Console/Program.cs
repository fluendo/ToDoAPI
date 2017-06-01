using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Core.ViewModels;

namespace FluentToDo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
        }        
    }

    static class MainView
    {
        static MainViewModel _mainViewModel = new MainViewModel();

        static void Show()
        {
            
        }

        static void ShowElements()
        {
            foreach(var item in _mainViewModel.TodoItems)
            {
                System.Console.WriteLine(item.)
            }

            
        }
    }

    static class AddTodoView
    {
        static void Show()
        {

        }
    }

    
}
