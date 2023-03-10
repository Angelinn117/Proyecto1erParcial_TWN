using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories;

public class InMemoryReparationRepository : IReparationRepository
{
    
    //Nota: El guión bajo en las variables indica que la variable es privada.
    private readonly List<Reparation> _repairs;

    public InMemoryReparationRepository()
    {
        _repairs = new List<Reparation>();
    }
    
    //Guardar Información:
    public async Task<Reparation> SaveAsync(Reparation reparation)
    {
        reparation.Id = _repairs.Count + 1;
        _repairs.Add(reparation);

        return reparation;
    }
    
    //Actualizar informacion:
    public async Task<Reparation> UpdateAsync(Reparation reparation)
    {
        var index = _repairs.FindIndex(x => x.Id == reparation.Id);
        
        if (index != -1)
            _repairs[index] = reparation;
        return await Task.FromResult(reparation);
    }
    
    // Nota: Con la palabra "async" creamos el método para que sea asíncrono.
    // Obtener toda la informacion almacenada:
    public async Task<List<Reparation>> GetAllAsync()
    {
        return _repairs;
    }
    
    //Borrar información (registro mediante ID):
    public async Task<bool> DeleteAsync(int id)
    {
        _repairs.RemoveAll(x => x.Id == id);
        return true;
    }
    
    // Obtener información mediante un ID: 
    public async Task<Reparation> GetById(int id)
    {
        var reparation = _repairs.FirstOrDefault(x => x.Id == id);
            
        return await Task.FromResult(reparation);
    }
    
    
}