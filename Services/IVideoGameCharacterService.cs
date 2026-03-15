using WebApiFirst.Dtos;
using WebApiFirst.Models;

namespace WebApiFirst.Services
{
    public interface IVideoGameCharacterService
    {
        Task<List<CharacterResponse>> GetCharactersAsync();
        Task<CharacterResponse?> GetCharacterByIdAsync(int id);
        Task<CharacterResponse> AddCharacterAsync(CharacterResponse character);
        Task<CharacterResponse> UpdateCharacterAsync(int id, CharacterResponse character);
        Task<CharacterResponse> DeleteCharacterAsync(int id);
    }
}
