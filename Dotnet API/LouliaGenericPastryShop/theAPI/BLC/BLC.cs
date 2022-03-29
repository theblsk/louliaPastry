using System;
using theAPI.DALC;
using theAPI.Models;

namespace theAPI.BLC
{
	public class BLC
	{
		private DALC.DALC _DALC;

		public IConfiguration _config;


		public BLC(IConfiguration config)
        {
			_config = config;
			_DALC = new DALC.DALC(_config);

        }
		public async Task<List<MenuItem>> GetCookies() =>
		   await _DALC.GetChosen("Cookie");
		public async Task<List<MenuItem>> GetEclaire() =>
			await _DALC.GetChosen("Eclaire");
		public async Task<List<MenuItem>> GetIcecream() =>
			await _DALC.GetChosen("Icecream");
		public async Task<List<MenuItem>> GetBrownie() =>
			await _DALC.GetChosen("Brownie");
		public async Task<List<MenuItem>> GetSpecialBites() =>
			await _DALC.GetChosen("SpecialBites");

	}
}

