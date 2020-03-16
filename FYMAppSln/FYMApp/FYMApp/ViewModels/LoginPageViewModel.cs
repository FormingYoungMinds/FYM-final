using FYMApp.Models;
using FYMApp.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FYMApp.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        public LoginPageViewModel(INavigationService navigationService,IPageDialogService pageDialogService, IDatabase database) : base(navigationService, pageDialogService)
        {
            CurrentUser = new User();
            _database = database;

        }

        private readonly IDatabase _database;
        private User _user;

        public User CurrentUser
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }


        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        async void ExecuteLoginCommand()
        {
            await _database.SaveUserAsync(CurrentUser);
            LoginService service = new LoginService();
            var getLoginDetails = await service.CheckLoginIfExists(CurrentUser.Email, CurrentUser.Password);
            if (getLoginDetails)

            {
                await PageDialogService.DisplayAlertAsync("Login ", "Username or Password is incorrect or not exists", "Okay", "Cancel");
            }
            else if (CurrentUser.Email == null && CurrentUser.Password == null)
            {
                await PageDialogService.DisplayAlertAsync("Login Successful", "Username or Password is correct", "Okay", "Cancel");
            }
            else
            {
                await PageDialogService.DisplayAlertAsync("Login failed", "Enter your Email and Password before login", "Okay", "Cancel");
            }

            await NavigationService.NavigateAsync("MainPage");
        }
    }
}
