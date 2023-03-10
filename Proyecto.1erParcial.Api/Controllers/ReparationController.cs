using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;
using Proyecto._1erParcial.Core.Http;

namespace Proyecto._1erParcial.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ReparationController : ControllerBase
{
    
    private readonly IReparationRepository _reparationRepository;
    
    public ReparationController(IReparationRepository reparationRepository)
    {
        _reparationRepository = reparationRepository;
    }
    
    //Get All
    [HttpGet]
    public async Task<ActionResult<Response<List<Reparation>>>> GetAll ()
    {
        var reparation = await _reparationRepository.GetAllAsync();
        var response = new Response<List<Reparation>>();
        response.Data = reparation;

        return Ok(response);
    }
    
    //Add
    [HttpPost]
    public async Task<ActionResult<Response<Reparation>>> Post([FromBody] Reparation reparation)
    {
        reparation = await _reparationRepository.SaveAsync(reparation);
        
        var response = new Response<Reparation>();
        response.Data = reparation;

        return Created($"/api/[controller]/{reparation.Id}", response);
    }
    
    //Get by ID
    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<Reparation>>> GetById(int id)
    {
        var reparation = await _reparationRepository.GetById(id);
        var response = new Response<Reparation>();
        response.Data = reparation;

        return Ok(response);
    }
    
    //Update
    [HttpPut]
    public async Task<ActionResult<Response<Reparation>>> Update([FromBody] Reparation reparation)
    {
        var result = await _reparationRepository.UpdateAsync(reparation);
        var response = new Response<Reparation> { Data = result };

        return Ok(response);
    }

    //Delete
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete(int id)
    {
        var response = new Response<bool>();
        var result = await _reparationRepository.DeleteAsync(id);
        response.Data = result;

        return Ok(response);
    }
    
}