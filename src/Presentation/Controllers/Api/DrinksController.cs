using DongPhuong.Application.Requests.Features.Base;
using DongPhuong.Domain.Dtos.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;
using DongPhuong.Presentation.Controllers.Api.Base;
using Microsoft.AspNetCore.Mvc;

namespace DongPhuong.Presentation.Controllers.Api;

    [Route("api/[controller]")]
    public class DrinksController : BaseApiController
    {
        private readonly IDrinksCommandHandler _commandHandler;
        private readonly IDrinksQueryHandler _queryHandler;

        public DrinksController(IDrinksCommandHandler commandHandler, IDrinksQueryHandler queryHandler)
        {
            _commandHandler = commandHandler;
            _queryHandler = queryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _queryHandler.HandleAsync<DrinkGetDto>());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return Ok(await _queryHandler.HandleAsync<DrinkGetDto>(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PostRequest<DrinkDto> request)
        {
            var response = await _commandHandler.HandleAsync(request);
            if (response.Errors.Any())
                return BadRequest(response);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PutRequest<DrinkDto?> request)
        {
            var response = await _commandHandler.HandleAsync(id, request);
            if (response.Errors.Any())
                return BadRequest(response);
            return Ok(response);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await _commandHandler.HandleAsync(id);
            if (response.Errors.Any())
                return NotFound(response);
            return Ok(response);
        }

        [HttpGet("paged")]
        public async Task<IActionResult> GetPaged([FromQuery] int pageNum = 1, [FromQuery] int pageSize = 10, [FromQuery] string? filter = null)
        {
            var drinks = await _queryHandler.HandleGetDrinksPagedAsync(pageNum, pageSize, filter);
            return Ok(drinks);
        }
    }
