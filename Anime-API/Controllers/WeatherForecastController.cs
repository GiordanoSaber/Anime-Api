using Anime_API.Models;
using Anime_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Anime_API.Controllers
{
    [ApiController]
    [Route("api/animes")]
    public class AnimeController : ControllerBase
    {
        private readonly IAnimeService _animeService;

        public AnimeController(IAnimeService animeService)
        {
            _animeService = animeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AnimeModel>> GetAllAnimes()
        {
            var animes = _animeService.GetAllAnimes();
            return Ok(animes);
        }

        [HttpGet("{id}")]
        public ActionResult<AnimeModel> GetAnimeById(int id)
        {
            var anime = _animeService.GetAnimeById(id);
            if (anime == null)
            {
                return NotFound();
            }
            return Ok(anime);
        }

        [HttpPost]
        public ActionResult<AnimeModel> CreateAnime(AnimeModel anime)
        {
            // Agrega aquí la lógica de validación y asignación de valores adicionales
            anime.Id_AnimeModel = _animeService.GenerateNewAnimeId();
            anime.StartDate = DateTime.Now;
            anime.Status = "Ongoing";

            var createdAnime = _animeService.CreateAnime(anime);
            return CreatedAtAction(nameof(GetAnimeById), new { id = createdAnime.Id_AnimeModel }, createdAnime);
        }
    }
}
