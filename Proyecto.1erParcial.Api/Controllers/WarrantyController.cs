using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;
using Proyecto._1erParcial.Core.Http;

namespace Proyecto._1erParcial.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class WarrantyController : ControllerBase
{
    
    private readonly IWarrantyRepository _warrantyRepository;
    
    public WarrantyController(IWarrantyRepository warrantyRepository)
    {
        _warrantyRepository = warrantyRepository;
    }
    
    //Get All
    [HttpGet]
    public async Task<ActionResult<Response<List<Warranty>>>> GetAll ()
    {
        var warranty = await _warrantyRepository.GetAllAsync();
        var response = new Response<List<Warranty>>();
        response.Data = warranty;

        return Ok(response);
    }
    
    //Add
    [HttpPost]
    public async Task<ActionResult<Response<Warranty>>> Post([FromBody] Warranty warranty)
    {
        warranty = await _warrantyRepository.SaveAsync(warranty);
        
        var response = new Response<Warranty>();
        response.Data = warranty;

        return Created($"/api/[controller]/{warranty.Id}", response);
    }
    
    //Get by ID
    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<Warranty>>> GetById(int id)
    {
        var warranty = await _warrantyRepository.GetById(id);
        var response = new Response<Warranty>();
        response.Data = warranty;

        return Ok(response);
    }
    
    //Update
    [HttpPut]
    public async Task<ActionResult<Response<Warranty>>> Update([FromBody] Warranty warranty)
    {
        var result = await _warrantyRepository.UpdateAsync(warranty);
        var response = new Response<Warranty> { Data = result };

        return Ok(response);
    }

    //Delete
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete(int id)
    {
        var response = new Response<bool>();
        var result = await _warrantyRepository.DeleteAsync(id);
        response.Data = result;

        return Ok(response);
    }
    
}