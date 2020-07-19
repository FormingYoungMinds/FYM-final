using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FYMApp.ViewModels
{
    public class NutritionPageViewModel : ViewModelBase
    {
        public NutritionPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            _navigationService = navigationService;
        }

        private INavigationService _navigationService;

        private DelegateCommand _foodActivityCommand;
        public DelegateCommand FoodActivityCommand =>
            _foodActivityCommand ?? (_foodActivityCommand = new DelegateCommand(ExecuteFoodActivityCommand));

        async void ExecuteFoodActivityCommand()
        {
            await NavigationService.NavigateAsync("FoodActivity");
        }
    }
}
