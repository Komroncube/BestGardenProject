using BestGarden.Application.DTOs.Catalogs;
using BestGarden.Application.UseCases.Catalogs.Commands.CreateCatalog;
using BestGarden.Application.UseCases.Catalogs.Queries.GetCatalogDetail;
using BestGarden.Application.UseCases.Catalogs.Queries.GetCatalogList;
using BestGarden.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BestGarden.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class CatalogsController : ControllerBase
{
    private readonly IMediator _mediator;

    public CatalogsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<CatalogsController>
    [HttpGet]
    public async ValueTask<IActionResult> Get()
    {
        IEnumerable<CatalogListDTO> catalogList = await _mediator.Send(new GetCatalogListQuery());
        return Ok(catalogList);
    }

    // GET api/<CatalogsController>/5
    [HttpGet("{id}")]
    public async ValueTask<CatalogDetailDTO> Get(int id)
    {
        return await _mediator.Send(new GetCatalogDetailQuery { Id = id });
    }

    // POST api/<CatalogsController>
    [HttpPost]
    public async ValueTask<Catalog> Post([FromForm] CatalogCreateDTO catalogCreateDto)
    {
        return await _mediator.Send(new CreateCatalogCommand { CatalogCreateDto = catalogCreateDto });
    }

    //keyinchalik qilinadi
    // PUT api/<CatalogsController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<CatalogsController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}
