using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories.Interfaces;

public interface IWarrantyRepository
{
    //Método para evaluar garantía:
    Task<Warranty> SaveAsync(Warranty warranty);
    
    //Método para actualizar las garantías:
    Task<Warranty> UpdateAsync(Warranty warranty);
    
    //Método para retornar una lista de garantías:
    Task<List<Warranty>> GetAllAsync();
    
    //Método para retornar el ID de las garantías que borrará:
    Task<bool> DeleteAsync(int id);
    
    //Método para obtener una garantía por ID:
    Task<Warranty> GetById(int id);
}