using ToDo.Core.ViewModels.Base;

namespace ToDo.Core.ViewModels.Services.Interfaces
{
    public interface INavigationService
    {
        void Back();

        void NavigateTo<TViewModel>() where TViewModel : BaseViewModel;

    }
}
