using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FYMApp.ViewModels
{
    public class ContentListViewModel : ViewModelBase
    {
        public ContentListViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            _navigationService = navigationService;
        }

        private INavigationService _navigationService;

        private DelegateCommand _wellbeingCategoriesCommand;
        public DelegateCommand WellbeingCategoriesCommand =>
            _wellbeingCategoriesCommand ?? (_wellbeingCategoriesCommand = new DelegateCommand(ExecuteWellbeingCategoriesCommand));

        async void ExecuteWellbeingCategoriesCommand()
        {
            await NavigationService.NavigateAsync("WellbeingCategories");
        }
    }
}
