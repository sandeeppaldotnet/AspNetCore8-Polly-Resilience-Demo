
using System.Threading.Tasks;

namespace PollyDemoApi.Services
{
    public interface IWeatherService
    {
        Task<string> GetWeatherAsync();
    }
}