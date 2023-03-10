using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories.Interfaces;

public interface IReparationRepository
{
    //Método para evaluar reparaciones:
    Task<Reparation> SaveAsync(Reparation reparation);
    
    //Método para actualizar las reparaciones:
    Task<Reparation> UpdateAsync(Reparation reparation);
    
    //Método para retornar una lista de reparaciones:
    Task<List<Reparation>> GetAllAsync();
    
    //Método para retornar el ID de las reparaciones que borrará:
    Task<bool> DeleteAsync(int id);
    
    //Método para obtener una reparacion por ID:
    Task<Reparation> GetById(int id);
}