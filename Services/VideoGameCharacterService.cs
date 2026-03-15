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
                Name = c.Name,
                Game = c.Game,
                Role = c.Role
            })
            .ToListAsync();
        public Task<CharacterResponse> AddCharacterAsync(CharacterResponse character)
        {
            throw new NotImplementedException();
        }

        public Task<CharacterResponse> DeleteCharacterAsync(int id)
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

        public Task<CharacterResponse> UpdateCharacterAsync(int id, CharacterResponse character)
        {
            throw new NotImplementedException();
        }
    }
}
