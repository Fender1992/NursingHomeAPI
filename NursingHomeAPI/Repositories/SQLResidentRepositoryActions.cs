using NursingHomeAPI.Data;
using NursingHomeAPI.Domains;

namespace NursingHomeAPI.Repositories
{
    public class SQLResidentRepositoryActions: IResidentRepository
    {
        private readonly ResidentDbContext _residentDbContext;

        public SQLResidentRepositoryActions(ResidentDbContext residentDbContext)
        {
            _residentDbContext = residentDbContext;
        }

        public async Task<Resident> AddResidentAsync(Resident resident)
        {
            var newResident = _residentDbContext.Add(resident).Entity;
            await _residentDbContext.SaveChangesAsync();
            return newResident;
        }

        public Task<List<Resident>> GetAllResidentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Resident> GetResidentsByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Resident> UpdateResidentAsync(Guid id, Resident resident)
        {
            throw new NotImplementedException();
        }
    }
}
