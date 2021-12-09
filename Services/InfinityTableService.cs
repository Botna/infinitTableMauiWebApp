using infinityTableWebApp.Models.Library;

namespace infinityTableWebApp.Services
{
    public class InfinityTableService
    {
        public readonly IInfinityTableApi _infTableApi;
        public InfinityTableService(IInfinityTableApi infTableApi)
        {
            _infTableApi = infTableApi;
        }

        public void SetSolidColor(PixelColor color)
        {
            try
            {
                _infTableApi.SetSolidColor(color);
            }
            catch { }
        }

        public async Task<bool> PingAPI()
        {
            try
            {
                await _infTableApi.GetHealth();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
