using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;
using Proyecto._1erParcial.Core.Http;

namespace Proyecto._1erParcial.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ApparatusController : ControllerBase
{
    
    private readonly IApparatusRepository _apparatusRepository;

    public ApparatusController(IApparatusRepository apparatusRepository)
    {
        _apparatusRepository = apparatusRepository;
    }
    
    //Get All
    [HttpGet]
    public async Task<ActionResult<Response<List<Apparatus>>>> GetAll ()
    {
        var apparatus = await _apparatusRepository.GetAllAsync();
        var response = new Response<List<Apparatus>>();
        response.Data = apparatus;

        return Ok(response);
    }
    
    //Add
    [HttpPost]
    public async Task<ActionResult<Response<Apparatus>>> Post([FromBody] Apparatus apparatus)
    {
        apparatus = await _apparatusRepository.SaveAsync(apparatus);
        
        var response = new Response<Apparatus>();
        response.Data = apparatus;

        return Created($"/api/[controller]/{apparatus.Id}", response);
    }
    
    //Get by ID
    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<Apparatus>>> GetById(int id)
    {
        var apparatus = await _apparatusRepository.GetById(id);
        var response = new Response<Apparatus>();
        response.Data = apparatus;

        return Ok(response);
    }
    
    //Update
    [HttpPut]
    public async Task<ActionResult<Response<Apparatus>>> Update([FromBody] Apparatus apparatus)
    {
        var result = await _apparatusRepository.UpdateAsync(apparatus);
        var response = new Response<Apparatus> { Data = result };

        return Ok(response);
    }

    //Delete
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete(int id)
    {
        var response = new Response<bool>();
        var result = await _apparatusRepository.DeleteAsync(id);
        response.Data = result;

        return Ok(response);
    }
    
}