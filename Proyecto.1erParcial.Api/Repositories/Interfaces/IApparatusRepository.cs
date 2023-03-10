using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories.Interfaces;

public interface IApparatusRepository
{
    
    //Método para evaluar aparatos:
    Task<Apparatus> SaveAsync(Apparatus apparatus);
    
    //Método para actualizar los aparatos:
    Task<Apparatus> UpdateAsync(Apparatus apparatus);
    
    //Método para retornar una lista de aparatos:
    Task<List<Apparatus>> GetAllAsync();
    
    //Método para retornar el ID de los aparatos que borrará:
    Task<bool> DeleteAsync(int id);
    
    //Método para obtener un aparato por ID:
    Task<Apparatus> GetById(int id);
    
}