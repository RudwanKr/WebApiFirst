using Microsoft.EntityFrameworkCore;
using WebApiFirst.Data;
using WebApiFirst.Dtos;
using WebApiFirst.Models;

namespace WebApiFirst.Services
{
    public class VideoGameCharacterService(AppDbContext context) : IVideoGameCharacterService
    {
        public async Task<List<CharacterResponse>> GetCharactersAsync()
        => await context.Characters
            .Select(c => new CharacterResponse
            {
                Id = c.Id,
                Name = c.Name,
                Game = c.Game,
                Role = c.Role
            })
            .ToListAsync();
        public async Task<CharacterResponse> AddCharacterAsync(CreateCharacterRequest character)
        {
            var newCharacter = new Character
            {
                Name = character.Name,
                Game = character.Game,
                Role = character.Role
            };

            context.Characters.Add(newCharacter);

            await context.SaveChangesAsync();

            return new CharacterResponse
            {
                Id = newCharacter.Id,
                Name = newCharacter.Name,
                Game = newCharacter.Game,
                Role = newCharacter.Role
            };
        }

        public Task<bool> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async  Task<CharacterResponse?> GetCharacterByIdAsync(int id)
        {
            return await context.Characters.Where(c => c.Id == id).Select(c => new CharacterResponse
            {
                Name = c.Name,
                Game = c.Game,
                Role = c.Role
            }).FirstOrDefaultAsync();
        }

        public Task<bool> UpdateCharacterAsync(int id, UpdateCharacterRequest character)
        {
            var c = context.Characters.Where(c => c.Id == id).Select(c => new CharacterResponse
            {
                Name = c.Name,
                Game = c.Game,
                Role = c.Role
            });

            context.Characters.Update(new Character
            {
                Name = character.Name,
                Game = character.Game,
                Role = character.Role
            });
        }
    }
}
