using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;
using Proyecto._1erParcial.Core.Http;

namespace Proyecto._1erParcial.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CustomerAddressController : ControllerBase
{
    
    private readonly ICustomerAddressRepository _customerAddressRepository;
    
    public CustomerAddressController(ICustomerAddressRepository customerAddressRepository)
    {
        _customerAddressRepository = customerAddressRepository;
    }
    
    //Get All
    [HttpGet]
    public async Task<ActionResult<Response<List<CustomerAddress>>>> GetAll ()
    {
        var customerAddress = await _customerAddressRepository.GetAllAsync();
        var response = new Response<List<CustomerAddress>>();
        response.Data = customerAddress;

        return Ok(response);
    }
    
    //Add
    [HttpPost]
    public async Task<ActionResult<Response<CustomerAddress>>> Post([FromBody] CustomerAddress customerAddress)
    {
        customerAddress = await _customerAddressRepository.SaveAsync(customerAddress);
        var response = new Response<CustomerAddress>();
        response.Data = customerAddress;

        return Created($"/api/[controller]/{customerAddress.Id}", response);
    }
    
    //Get by ID
    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<CustomerAddress>>> GetById(int id)
    {
        var customerAddress = await _customerAddressRepository.GetById(id);
        var response = new Response<CustomerAddress>();
        response.Data = customerAddress;

        return Ok(response);
    }
    
    //Update
    [HttpPut]
    public async Task<ActionResult<Response<CustomerAddress>>> Update([FromBody] CustomerAddress customerAddress)
    {
        var result = await _customerAddressRepository.UpdateAsync(customerAddress);
        var response = new Response<CustomerAddress> { Data = result };

        return Ok(response);
    }

    //Delete
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete(int id)
    {
        var response = new Response<bool>();
        var result = await _customerAddressRepository.DeleteAsync(id);
        response.Data = result;

        return Ok(response);
    }
    
}