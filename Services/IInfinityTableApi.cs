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

        [Post("/table/solidColor?hue={color.Hue}&saturation={color.Saturation}&value={color.Value}")]
        Task SetSolidColor(PixelColor color);
    }
}
