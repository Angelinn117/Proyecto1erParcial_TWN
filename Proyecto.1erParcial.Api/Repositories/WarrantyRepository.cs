using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories;

public class WarrantyRepository : IWarrantyRepository
{
    
    public Task<Warranty> SaveAsync(Warranty warranty)
    {
        throw new NotImplementedException();
    }

    public Task<Warranty> UpdateAsync(Warranty warranty)
    {
        throw new NotImplementedException();
    }

    public Task<List<Warranty>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Warranty> GetById(int id)
    {
        throw new NotImplementedException();
    }
    
}