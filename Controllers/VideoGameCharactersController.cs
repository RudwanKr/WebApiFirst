using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiFirst.Dtos;
using WebApiFirst.Models;
using WebApiFirst.Services;

namespace WebApiFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController(IVideoGameCharacterService service) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<CharacterResponse>>> GetCharacters()
         => Ok(await service.GetCharactersAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterResponse>> GetCharacterById(int id)
        {
            var character = await service.GetCharacterByIdAsync(id);
            return character is null ? NotFound($"Character with id {id} not found") : Ok(character);
        }

        [HttpPost]
        public async Task<ActionResult<CharacterResponse>> AddCharacter(CreateCharacterRequest character)
        {
            var createdCharacter = await service.AddCharacterAsync(character);
            return CreatedAtAction(nameof(GetCharacterById), new { id = createdCharacter.Id }, createdCharacter);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<CharacterResponse>> UpdateCharacter(int id,UpdateCharacterRequest character) {
            var updated = service.UpdateCharacterAsync(id,character);
            return await updated? NoContent() : NotFound($"Character with this {id} id is not found ");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterResponse>> DeleteCharacter(int id)
        {
            var deleted = service.DeleteCharacterAsync(id);
            return await deleted ? NoContent() : NotFound($"Character with this {id} id is not found ");
        }
    }
}
