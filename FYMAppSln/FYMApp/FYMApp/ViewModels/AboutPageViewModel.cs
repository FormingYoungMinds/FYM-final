using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace FYMApp.ViewModels
{
    public class AboutPageViewModel : ViewModelBase
    {
        public AboutPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            _navigationService = navigationService;
        }

        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        private DelegateCommand _navigationCommand;
        private INavigationService _navigationService;

        public DelegateCommand NavigationCommand =>
            _navigationCommand ?? (_navigationCommand = new DelegateCommand(ExcuteNavigationCommand));

        async void ExecuteNavigateCommand()
        {
            await NavigationService.NavigateAsync("LoginPage");
        }

        async void ExcuteNavigationCommand()
        {
            await NavigationService.NavigateAsync("SignUpPage");
        }
    }
}
