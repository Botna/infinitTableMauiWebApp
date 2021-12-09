using System.Threading.Tasks;
using Refit;

namespace infinityTableWebApp.Services
{
    public interface IInfinityTableApi
    {
        [Get("/health/ping")]
        Task GetHealth();

        [Get("/table/solidColor?color={color}")]
        Task SetSolidColor(string color);
    }
}
