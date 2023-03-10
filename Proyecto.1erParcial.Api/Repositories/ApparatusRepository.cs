using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories;

public class ApparatusRepository : IApparatusRepository
{
    public Task<Apparatus> SaveAsync(Apparatus apparatus)
    {
        throw new NotImplementedException();
    }

    public Task<Apparatus> UpdateAsync(Apparatus apparatus)
    {
        throw new NotImplementedException();
    }

    public Task<List<Apparatus>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Apparatus> GetById(int id)
    {
        throw new NotImplementedException();
    }
}