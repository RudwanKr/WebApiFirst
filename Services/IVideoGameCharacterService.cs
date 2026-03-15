using WebApiFirst.Models;

namespace WebApiFirst.Services
{
    public interface IVideoGameCharacterService
    {
        Task<List<Character>> GetCharactersAsync();
        Task<Character?> GetCharacterByIdAsync(int id);
        Task<List<Character>> AddCharacterAsync(Character character);
        Task<List<Character>> UpdateCharacterAsync(int id, Character character);
        Task<List<Character>> DeleteCharacterAsync(int id);
    }
}
