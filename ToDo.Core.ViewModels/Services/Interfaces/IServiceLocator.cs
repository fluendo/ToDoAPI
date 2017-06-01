namespace ToDo.Core.ViewModels.Services.Interfaces
{
    public interface IServiceLocator
    {
        T Get<T>() where T : new();

        void Register<T>(T implementation) where T : new();
    }
}
