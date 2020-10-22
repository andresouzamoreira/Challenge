using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace Challenge.Controllers
{
    [Route("Curtidas")]
    [ApiController]
    public class CurtidasController : ControllerBase
    {
        private readonly IMemoryCache _cache;
        public CurtidasController(IMemoryCache cache)
        {
            _cache = cache;
        }

        [HttpGet("memorycache")]        
        [Route("")]
        public List<Curtida> Index()
        {
            var cacheEntry = _cache.GetOrCreate("CacheKeyTodos", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(30);
                entry.SetPriority(CacheItemPriority.High);

                return Curtida.Todos();
            });

            return cacheEntry;           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCurtida"></param>
        /// <param name="Curtida"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("idCurtida")]
        public bool AtualizaCurtidas(int idCurtida, [FromBody] Curtida Curtida)
        {
            var cacheEntry = _cache.GetOrCreate("CacheKeyCurtidas", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(30);
                entry.SetPriority(CacheItemPriority.High);

                var objCurtida = new Curtida();
                return objCurtida.AtualizaCurtidas(Curtida);
            });

            return true;
        }

    }
}
