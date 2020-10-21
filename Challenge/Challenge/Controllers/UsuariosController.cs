using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace Challenge.Controllers
{
    [Route("Curtidas")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IMemoryCache _cache;
        public UsuariosController(IMemoryCache cache)
        {
            _cache = cache;
        }

        [HttpGet("memorycache")]
        [HttpGet]
        [Route("")]
        public List<Usuario> Index()
        {
            var cacheEntry = _cache.GetOrCreate("MeuCacheKey", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(30);
                entry.SetPriority(CacheItemPriority.High);

                return Usuario.Todos();
            });

            return cacheEntry;           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("idUsuario")]
        public bool AtualizaUsuarios(int idUsuario, [FromBody] Usuario usuario)
        {
            var cacheEntry = _cache.GetOrCreate("MeuCacheKey2", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(30);
                entry.SetPriority(CacheItemPriority.High);

                var objUsuario = new Usuario();
                return objUsuario.AtualizaUsuarios(usuario);
            });

            return true;
        }

    }
}
