using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories.Interfaces;

public interface ICustomerRepository
{
    
    //Método para evaluar clientes:
    Task<Customer> SaveAsync(Customer customer);
    
    //Método para actualizar los clientes:
    Task<Customer> UpdateAsync(Customer customer);
    
    //Método para retornar una lista de clientes:
    Task<List<Customer>> GetAllAsync();
    
    //Método para retornar el ID de los clientes que borrará:
    Task<bool> DeleteAsync(int id);
    
    //Método para obtener un cliente por ID:
    Task<Customer> GetById(int id);
    
}