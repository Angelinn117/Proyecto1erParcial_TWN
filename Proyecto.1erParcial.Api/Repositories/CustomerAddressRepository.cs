using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories;

public class CustomerAddressRepository : ICustomerAddressRepository
{
    
    public Task<CustomerAddress> SaveAsync(CustomerAddress customerAddress)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerAddress> UpdateAsync(CustomerAddress customerAddress)
    {
        throw new NotImplementedException();
    }

    public Task<List<CustomerAddress>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerAddress> GetById(int id)
    {
        throw new NotImplementedException();
    }
    
}