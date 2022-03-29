using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using theAPI.Models;
using theAPI.BLC;
using theAPI.DALC;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace theAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        public IConfiguration _config;

        private BLC.BLC _BLC;


        public MenuController(IConfiguration config)
        {
            _config = config;
            _BLC = new BLC.BLC(_config);
        }

        [HttpGet]
        [Route("cookie")]
        public async Task<List<MenuItem>> GetCookies()
        {
            return await _BLC.GetCookies();
        }
        [HttpGet]
        [Route("eclaire")]
        public async Task<List<MenuItem>> GetEclaire()
        {
            return await _BLC.GetEclaire();
        }
        [HttpGet]
        [Route("icecream")]
        public async Task<List<MenuItem>> GetIcecream()
        {
            return await _BLC.GetIcecream();
        }
        [HttpGet]
        [Route("brownie")]
        public async Task<List<MenuItem>> GetBrownie()
        {
            return await _BLC.GetBrownie();
        }
        [HttpGet]
        [Route("specialbites")]
        public async Task<List<MenuItem>> GetSpecialBites()
        {
            return await _BLC.GetSpecialBites();
        }
  


    }
}

