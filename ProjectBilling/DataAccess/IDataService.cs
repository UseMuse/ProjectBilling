using ProjectBilling.DataAccess.Models;
using System.Collections.Generic;

namespace ProjectBilling.DataAccess
{
    public interface IDataService
    {
        IList<Project> GetProjects();
    }
}
