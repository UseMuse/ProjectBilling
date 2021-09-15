using System.ComponentModel;

namespace ProjectBilling.ViewModels.Contracts
{
    public interface IProjectsViewModel : INotifyPropertyChanged
    {
        IProjectViewModel SelectedProject { get; set; }
        void UpdateProject();
    }
}
