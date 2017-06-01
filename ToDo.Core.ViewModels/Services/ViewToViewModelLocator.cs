


using System.Collections.Generic;
using ToDo.Core.ViewModels.Base;

namespace ToDo.Core.ViewModels.Services
{
    public static class ViewToViewModelLocator
    {
        private static Dictionary<IView, BaseViewModel> _pairViews = new Dictionary<IView, BaseViewModel>();

        public static void Add<TView, TViewModel>(TView view, TViewModel viewModel) where TView : IView
            where TViewModel : BaseViewModel
        {
            if(!_pairViews.ContainsKey(view))
            {
                _pairViews.Add(view, viewModel);
            }
        }
    }
}
