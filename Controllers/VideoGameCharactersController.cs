using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiFirst.Models;
using WebApiFirst.Services;

namespace WebApiFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController(IVideoGameCharacterService service) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharacters()
         => Ok(await service.GetCharactersAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> CetCharacterById(int id)
        {
            var character = await service.GetCharacterByIdAsync(id);
            return character is null ? NotFound($"Character with id {id} not found") : Ok(character);
        }
    }
}
