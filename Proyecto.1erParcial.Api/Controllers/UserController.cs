using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;
using Proyecto._1erParcial.Core.Http;

namespace Proyecto._1erParcial.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UserController : ControllerBase
{
    
    private readonly IUserRepository _userRepository;
    
    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    //Get All
    [HttpGet]
    public async Task<ActionResult<Response<List<User>>>> GetAll ()
    {
        var user = await _userRepository.GetAllAsync();
        var response = new Response<List<User>>();
        response.Data = user;

        return Ok(response);
    }
    
    //Add
    [HttpPost]
    public async Task<ActionResult<Response<User>>> Post([FromBody] User user)
    {
        user = await _userRepository.SaveAsync(user);
        
        var response = new Response<User>();
        response.Data = user;

        return Created($"/api/[controller]/{user.Id}", response);
    }
    
    //Get by ID
    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<User>>> GetById(int id)
    {
        var user = await _userRepository.GetById(id);
        var response = new Response<User>();
        response.Data = user;

        return Ok(response);
    }
    
    //Update
    [HttpPut]
    public async Task<ActionResult<Response<User>>> Update([FromBody] User user)
    {
        var result = await _userRepository.UpdateAsync(user);
        var response = new Response<User> { Data = result };

        return Ok(response);
    }

    //Delete
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete(int id)
    {
        var response = new Response<bool>();
        var result = await _userRepository.DeleteAsync(id);
        response.Data = result;

        return Ok(response);
    }
    
}