using ProjectBilling.DataAccess.Models.Contracts;
using System;

namespace ProjectBilling
{
    public class ProjectEventArgs : EventArgs
    {
        public IProject Project { get; set; }
        public ProjectEventArgs(IProject project)
        {
            Project = project;
        }
    }
}
