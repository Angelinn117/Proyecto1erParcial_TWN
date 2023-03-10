using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories;

public class InMemoryApparatusRepository : IApparatusRepository
{
    
    //Nota: El guión bajo en las variables indica que la variable es privada.
    private readonly List<Apparatus> _apparatus;

    public InMemoryApparatusRepository()
    {
        _apparatus = new List<Apparatus>();
    }
    
    //Guardar Información:
    public async Task<Apparatus> SaveAsync(Apparatus apparatus)
    {
        apparatus.Id = _apparatus.Count + 1;
        _apparatus.Add(apparatus);

        return apparatus;
    }
    
    //Actualizar informacion:
    public async Task<Apparatus> UpdateAsync(Apparatus apparatus)
    {
        var index = _apparatus.FindIndex(x => x.Id == apparatus.Id);
        
        if (index != -1)
            _apparatus[index] = apparatus;
        return await Task.FromResult(apparatus);
    }
    
    // Nota: Con la palabra "async" creamos el método para que sea asíncrono.
    // Obtener toda la informacion almacenada:
    public async Task<List<Apparatus>> GetAllAsync()
    {
        return _apparatus;
    }
    
    //Borrar información (registro mediante ID):
    public async Task<bool> DeleteAsync(int id)
    {
        _apparatus.RemoveAll(x => x.Id == id);
        return true;
    }
    
    // Obtener información mediante un ID: 
    public async Task<Apparatus> GetById(int id)
    {
        var apparatus = _apparatus.FirstOrDefault(x => x.Id == id);
            
        return await Task.FromResult(apparatus);
    }
    
}