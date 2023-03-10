using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using Proyecto._1erParcial.Api.Repositories.Interfaces;
using Proyecto._1erParcial.Core.Entities;
using Proyecto._1erParcial.Core.Http;

namespace Proyecto._1erParcial.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CustomerController : ControllerBase
{
    
    private readonly ICustomerRepository _customerRepository;

    public CustomerController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    //Get All
    [HttpGet]
    public async Task<ActionResult<Response<List<Customer>>>> GetAll ()
    {
        var customer = await _customerRepository.GetAllAsync();
        var response = new Response<List<Customer>>();
        response.Data = customer;

        return Ok(response);
    }
    
    //Add
    [HttpPost]
    public async Task<ActionResult<Response<Customer>>> Post([FromBody] Customer customer)
    {
        customer = await _customerRepository.SaveAsync(customer);
        
        var response = new Response<Customer>();
        response.Data = customer;

        return Created($"/api/[controller]/{customer.Id}", response);
    }
    
    //Get by ID
    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<Customer>>> GetById(int id)
    {
        var customer = await _customerRepository.GetById(id);
        var response = new Response<Customer>();
        response.Data = customer;

        return Ok(response);
    }
    
    //Update
    [HttpPut]
    public async Task<ActionResult<Response<Customer>>> Update([FromBody] Customer customer)
    {
        var result = await _customerRepository.UpdateAsync(customer);
        var response = new Response<Customer> { Data = result };

        return Ok(response);
    }

    //Delete
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete(int id)
    {
        var response = new Response<bool>();
        var result = await _customerRepository.DeleteAsync(id);
        response.Data = result;

        return Ok(response);
    }
    
}