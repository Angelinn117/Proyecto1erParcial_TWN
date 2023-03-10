using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories.Interfaces;

public class ReparationRepository : IReparationRepository
{
    public Task<Reparation> SaveAsync(Reparation reparation)
    {
        throw new NotImplementedException();
    }

    public Task<Reparation> UpdateAsync(Reparation reparation)
    {
        throw new NotImplementedException();
    }

    public Task<List<Reparation>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Reparation> GetById(int id)
    {
        throw new NotImplementedException();
    }
}