using Anime_API.Models;
using System.Collections.Generic;
using Anime_API.Models;
using System.Collections.Generic;

namespace Anime_API.Services
{
    public interface IAnimeService
    {
        AnimeModel CreateAnime(AnimeModel anime);
        IEnumerable<AnimeModel> GetAllAnimes();
        AnimeModel GetAnimeById(int id);
        int GenerateNewAnimeId();
    }
}
