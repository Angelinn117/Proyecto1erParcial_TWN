using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories.Interfaces;

public interface IUserRepository
{
    //Método para evaluar usuarios:
    Task<User> SaveAsync(User user);
    
    //Método para actualizar los usuarios:
    Task<User> UpdateAsync(User user);
    
    //Método para retornar una lista de usuarios:
    Task<List<User>> GetAllAsync();
    
    //Método para retornar el ID de los usuarios que borrará:
    Task<bool> DeleteAsync(int id);
    
    //Método para obtener un usuario por ID:
    Task<User> GetById(int id);
    
}