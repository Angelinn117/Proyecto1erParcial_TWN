using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories;

public class CustomerRepository : ICustomerRepository
{
    
    public Task<Customer> SaveAsync(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> UpdateAsync(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Task<List<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> GetById(int id)
    {
        throw new NotImplementedException();
    }
    
}