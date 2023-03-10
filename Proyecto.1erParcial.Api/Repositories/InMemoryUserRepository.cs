using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;

namespace Proyecto._1erParcial.Api.Repositories;

public class InMemoryUserRepository : IUserRepository
{
    
    //Nota: El guión bajo en las variables indica que la variable es privada.
    private readonly List<User> _users;

    public InMemoryUserRepository()
    {
        _users = new List<User>();
    }
    
    //Guardar Información:
    public async Task<User> SaveAsync(User user)
    {
        user.Id = _users.Count + 1;
        _users.Add(user);

        return user;
    }
    
    //Actualizar informacion:
    public async Task<User> UpdateAsync(User user)
    {
        var index = _users.FindIndex(x => x.Id == user.Id);
        
        if (index != -1)
            _users[index] = user;
        return await Task.FromResult(user);
    }
    
    // Nota: Con la palabra "async" creamos el método para que sea asíncrono.
    // Obtener toda la informacion almacenada:
    public async Task<List<User>> GetAllAsync()
    {
        return _users;
    }
    
    //Borrar información (registro mediante ID):
    public async Task<bool> DeleteAsync(int id)
    {
        _users.RemoveAll(x => x.Id == id);
        return true;
    }
    
    // Obtener información mediante un ID: 
    public async Task<User> GetById(int id)
    {
        var user = _users.FirstOrDefault(x => x.Id == id);
            
        return await Task.FromResult(user);
    }
    
}