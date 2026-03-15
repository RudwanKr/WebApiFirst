using WebApiFirst.Dtos;
using WebApiFirst.Models;

namespace WebApiFirst.Services
{
    public interface IVideoGameCharacterService
    {
        Task<List<CharacterResponse>> GetCharactersAsync();
        Task<CharacterResponse?> GetCharacterByIdAsync(int id);
        Task<CharacterResponse> AddCharacterAsync(CreateCharacterRequest character);
        Task<bool> UpdateCharacterAsync(int id, UpdateCharacterRequest character);
        Task<bool> DeleteCharacterAsync(int id);
    }
}
