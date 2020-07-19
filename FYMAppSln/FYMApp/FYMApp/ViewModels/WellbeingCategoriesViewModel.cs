using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FYMApp.ViewModels
{
    public class WellbeingCategoriesViewModel : ViewModelBase
    {
        public WellbeingCategoriesViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            _navigationService = navigationService;
        }

        private INavigationService _navigationService;

        private DelegateCommand _nutritionPageCommand;
        public DelegateCommand NutritionPageCommand =>
            _nutritionPageCommand ?? (_nutritionPageCommand = new DelegateCommand(ExecuteNutritionPageCommand));

        async void ExecuteNutritionPageCommand()
        {
            await NavigationService.NavigateAsync("NutritionPage");
        }
    }
}
