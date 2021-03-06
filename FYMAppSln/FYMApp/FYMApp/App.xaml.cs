﻿using Prism;
using Prism.Ioc;
using FYMApp.ViewModels;
using FYMApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FYMApp.Services.Interfaces;
using FYMApp.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FYMApp
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/AboutPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IDatabase, CareGiverDataBase>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LanguageSelectionPage, LanguageSelectionPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<SignUpPage, SignUpPageViewModel>();
            containerRegistry.RegisterForNavigation<EmotionalWellBeingPage, EmotionalWellBeingPageViewModel>();

            containerRegistry.RegisterForNavigation<SecurityandSafetyPage, SecurityandSafetyPageViewModel>();
            containerRegistry.RegisterForNavigation<NutritionPage, NutritionPageViewModel>();
            containerRegistry.RegisterForNavigation<HygienePage, HygienePageViewModel>();
            containerRegistry.RegisterForNavigation<ContentList, ContentListViewModel>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutPageViewModel>();
            containerRegistry.RegisterForNavigation<WellbeingCategories, WellbeingCategoriesViewModel>();
            containerRegistry.RegisterForNavigation<FoodActivity, FoodActivityViewModel>();
        }
    }
}
