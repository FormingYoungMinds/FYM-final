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

        private INavigationService _navigationService;

        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        async void ExecuteNavigateCommand()
        {
            await NavigationService.NavigateAsync("LoginPage");
        }

        private DelegateCommand _navigationCommand;
        public DelegateCommand NavigationCommand =>
            _navigationCommand ?? (_navigationCommand = new DelegateCommand(ExecuteNavigationCommand));

        async void ExecuteNavigationCommand()
        {
            await NavigationService.NavigateAsync("SignUpPage");
        }

        private DelegateCommand _contentListPageCommand;
        public DelegateCommand ContentListPageCommand =>
            _contentListPageCommand ?? (_contentListPageCommand = new DelegateCommand(ExecuteContentListPageCommand));

        async void ExecuteContentListPageCommand()
        {
            await NavigationService.NavigateAsync("ContentList");
        }
    }
}
