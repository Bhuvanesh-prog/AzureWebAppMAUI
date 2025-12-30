using AzureWebAppMAUI.Models;
using CommunityToolkit.Mvvm.Input;

namespace AzureWebAppMAUI.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}