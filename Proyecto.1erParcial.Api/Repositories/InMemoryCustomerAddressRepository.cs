using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories;

public class InMemoryCustomerAddressRepository : ICustomerAddressRepository
{
    
    //Nota: El guión bajo en las variables indica que la variable es privada.
    private readonly List<CustomerAddress> _customersAddress;

    public InMemoryCustomerAddressRepository()
    {
        _customersAddress = new List<CustomerAddress>();
    }
    
    //Guardar Información:
    public async Task<CustomerAddress> SaveAsync(CustomerAddress customerAddress)
    {
        customerAddress.Id = _customersAddress.Count + 1;
        _customersAddress.Add(customerAddress);

        return customerAddress;
    }
    
    //Actualizar informacion:
    public async Task<CustomerAddress> UpdateAsync(CustomerAddress customerAddress)
    {
        var index = _customersAddress.FindIndex(x => x.Id == customerAddress.Id);
        
        if (index != -1)
            _customersAddress[index] = customerAddress;
        return await Task.FromResult(customerAddress);
    }
    
    // Nota: Con la palabra "async" creamos el método para que sea asíncrono.
    // Obtener toda la informacion almacenada:
    public async Task<List<CustomerAddress>> GetAllAsync()
    {
        return _customersAddress;
    }
    
    //Borrar información (registro mediante ID):
    public async Task<bool> DeleteAsync(int id)
    {
        _customersAddress.RemoveAll(x => x.Id == id);
        return true;
    }
    
    // Obtener información mediante un ID: 
    public async Task<CustomerAddress> GetById(int id)
    {
        var user = _customersAddress.FirstOrDefault(x => x.Id == id);
            
        return await Task.FromResult(user);
    }
    
}