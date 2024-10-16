using Parcial202419200088.Controllers;
using Parcial202419200088.Data;

namespace Parcial202419200088.Interfaces
{
    public interface ICompetencyRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Competency>> GetCompetency();
        Task<int> Insert(Competency competency);
    }
}
