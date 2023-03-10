using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories;

public class InMemoryCustomerRepository : ICustomerRepository
{
    
    //Nota: El guión bajo en las variables indica que la variable es privada.
    private readonly List<Customer> _customers;

    public InMemoryCustomerRepository()
    {
        _customers = new List<Customer>();
    }
    
    //Guardar Información:
    public async Task<Customer> SaveAsync(Customer customer)
    {
        customer.Id = _customers.Count + 1;
        _customers.Add(customer);

        return customer;
    }
    
    //Actualizar informacion:
    public async Task<Customer> UpdateAsync(Customer customer)
    {
        var index = _customers.FindIndex(x => x.Id == customer.Id);
        
        if (index != -1)
            _customers[index] = customer;
        return await Task.FromResult(customer);
    }
    
    // Nota: Con la palabra "async" creamos el método para que sea asíncrono.
    // Obtener toda la informacion almacenada:
    public async Task<List<Customer>> GetAllAsync()
    {
        return _customers;
    }
    
    //Borrar información (registro mediante ID):
    public async Task<bool> DeleteAsync(int id)
    {
        _customers.RemoveAll(x => x.Id == id);
        return true;
    }
    
    // Obtener información mediante un ID: 
    public async Task<Customer> GetById(int id)
    {
        var customer = _customers.FirstOrDefault(x => x.Id == id);
            
        return await Task.FromResult(customer);
    }
    
}