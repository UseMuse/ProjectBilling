using ProjectBilling.DataAccess.Models;
using ProjectBilling.DataAccess.Models.Contracts;
using System;
using System.Collections.ObjectModel;

namespace ProjectBilling
{
    public interface IProjectsModel
    {
        ObservableCollection<Project> Projects { get; set; }
        event EventHandler<ProjectEventArgs> ProjectUpdated;
        void UpdateProject(IProject updatedProject);
    }
}
