using Microsoft.AspNetCore.Mvc.Rendering;
using First_Exam.Data.Entities;

namespace First_Exam.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync();
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync(IEnumerable<Entrance> filter);
    }
}
