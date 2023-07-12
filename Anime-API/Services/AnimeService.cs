using Anime_API.Models;
using Anime_API.Repositories;

namespace Anime_API.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly IAnimeRepository _animeRepository;
        private int _currentAnimeId = 1;

        public AnimeService(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }

        public AnimeModel CreateAnime(AnimeModel anime)
        {
            anime.Id_AnimeModel = GenerateNewAnimeId();
            anime.StartDate = DateTime.Now;
            anime.Status = "Ongoing";

            return _animeRepository.Create(anime);
        }

        public IEnumerable<AnimeModel> GetAllAnimes()
        {
            return _animeRepository.GetAll();
        }

        public AnimeModel GetAnimeById(int id)
        {
            return _animeRepository.GetById(id);
        }

        public int GenerateNewAnimeId()
        {
            int newId = _currentAnimeId;
            _currentAnimeId++;
            return newId;
        }
    }
}
