using Anime_API.Models;
using Anime_API.Repositories;
using System;
using System.Collections.Generic;

namespace Anime_API.Repositories
{
    public class AnimeRepositories
    {
        public class AnimeRepository : IAnimeRepository
        {
            
            private List<AnimeModel> _animes;  // Simulación de una fuente de datos en memoria

            public AnimeRepository()
            {
                _animes = new List<AnimeModel>();
            }

            public AnimeModel Create(AnimeModel anime)
            {
                anime.Id_AnimeModel = _animes.Count + 1;
                _animes.Add(anime);
                return anime;
            }

            public IEnumerable<AnimeModel> GetAll()
            {
                return _animes;
            }

            public AnimeModel GetById(int id)
            {
                return _animes.FirstOrDefault(a => a.Id_AnimeModel == id);
            }
        }
    }
}
