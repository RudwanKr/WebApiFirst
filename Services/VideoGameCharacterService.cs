using WebApiFirst.Models;

namespace WebApiFirst.Services
{
    public class VideoGameCharacterService : IVideoGameCharacterService
    {
        static List<Character> characters = new List<Character>
        {
            new Character { Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Hero" },
            new Character { Id = 2, Name = "Link", Game = "The Legend of Zelda", Role = "Protagonist" },
            new Character { Id = 3, Name = "Master Chief", Game = "Halo", Role = "Villain" }
        };

        public async Task<List<Character>> GetCharactersAsync()
                => await Task.FromResult(characters);
        public Task<List<Character>> AddCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }

        public Task<List<Character>> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async  Task<Character?> GetCharacterByIdAsync(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);
            return await Task.FromResult(character);  
        }

        public Task<List<Character>> UpdateCharacterAsync(int id, Character character)
        {
            throw new NotImplementedException();
        }
    }
}
