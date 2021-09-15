using ProjectBilling.Models;
using ProjectBilling.DataAccess.Models.Contracts;

namespace ProjectBilling
{
    public interface IProjectViewModel : IProject
    {
        Status EstimateStatus { get; set; }
    }
}
