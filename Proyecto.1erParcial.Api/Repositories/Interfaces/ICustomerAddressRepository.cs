using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories.Interfaces;

public interface ICustomerAddressRepository
{
    
    //Método para evaluar direcciones de clientes:
    Task<CustomerAddress> SaveAsync(CustomerAddress customerAddress);
    
    //Método para actualizar las direcciones de clientes:
    Task<CustomerAddress> UpdateAsync(CustomerAddress customerAddress);
    
    //Método para retornar una lista de direcciones de clientes:
    Task<List<CustomerAddress>> GetAllAsync();
    
    //Método para retornar el ID de las direcciones de clientes que borrará:
    Task<bool> DeleteAsync(int id);
    
    //Método para obtener una direccion de cliente por ID:
    Task<CustomerAddress> GetById(int id);
    
}