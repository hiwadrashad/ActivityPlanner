using ActivityPlannerBlazor.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.Interfaces
{
    public interface IInitialDataService
    {
        Task<IEnumerable<InitialModel>> GetAllInitials();
        Task<InitialModel> GetInitialDetails(string id);
        Task<InitialModel> AddInitial(InitialModel model);
        Task UpdateInitial(InitialModel model);
        Task DeleteInitial(string id);
    }
}
