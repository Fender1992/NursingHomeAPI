using NursingHomeAPI.Domains;

namespace NursingHomeAPI.Repositories
{
    public interface IResidentRepository
    {
        Task<Resident> AddResidentAsync(Resident resident);
        Task<List<Resident>> GetAllResidentsAsync();
        Task<Resident> GetResidentsByIdAsync(Guid id);
        Task<Resident> UpdateResidentAsync(Guid id, Resident resident);
    }
}
