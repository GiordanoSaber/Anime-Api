
using Anime_API.Models;
using System.Collections.Generic;


namespace Anime_API.Repositories
{
    public interface IAnimeRepository
    {
        AnimeModel Create(AnimeModel anime);
        IEnumerable<AnimeModel> GetAll();
        AnimeModel GetById(int id);
    }
}
