using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories.Interfaces;

public class InMemoryWarrantyRepository : IWarrantyRepository
{
    
    //Nota: El guión bajo en las variables indica que la variable es privada.
    private readonly List<Warranty> _warranties;

    public InMemoryWarrantyRepository()
    {
        _warranties = new List<Warranty>();
    }
    
    //Guardar Información:
    public async Task<Warranty> SaveAsync(Warranty warranty)
    {
        warranty.Id = _warranties.Count + 1;
        _warranties.Add(warranty);

        return warranty;
    }
    
    //Actualizar informacion:
    public async Task<Warranty> UpdateAsync(Warranty warranty)
    {
        var index = _warranties.FindIndex(x => x.Id == warranty.Id);
        
        if (index != -1)
            _warranties[index] = warranty;
        return await Task.FromResult(warranty);
    }
    
    // Nota: Con la palabra "async" creamos el método para que sea asíncrono.
    // Obtener toda la informacion almacenada:
    public async Task<List<Warranty>> GetAllAsync()
    {
        return _warranties;
    }
    
    //Borrar información (registro mediante ID):
    public async Task<bool> DeleteAsync(int id)
    {
        _warranties.RemoveAll(x => x.Id == id);
        return true;
    }
    
    // Obtener información mediante un ID: 
    public async Task<Warranty> GetById(int id)
    {
        var warranty = _warranties.FirstOrDefault(x => x.Id == id);
            
        return await Task.FromResult(warranty);
    }
    
}