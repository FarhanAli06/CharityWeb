using System.Linq;
using System.Threading.Tasks;
using DAL.IService;
using Model.Models;

namespace DAL.Service
{
    public class HomeDALService
    {
        //private readonly IHomeDALService _homeDALService;

        //private readonly ApplicationDbContext _context;
        //public HomeDALService(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        #region Home
        public async Task<WeatherForecast> CallApiMethodAsync()
        {
           // var result = _context.Users.ToList();
            return null;
        }
        #endregion 
    }
}
