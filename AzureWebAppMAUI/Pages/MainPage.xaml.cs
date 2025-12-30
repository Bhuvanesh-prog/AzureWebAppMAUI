using AzureWebAppMAUI.Models;
using AzureWebAppMAUI.PageModels;

namespace AzureWebAppMAUI.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}