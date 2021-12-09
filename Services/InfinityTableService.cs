using System;
using System.Net.Http;

namespace infinityTableWebApp.Services
{
    public class InfinityTableService
    {
        public readonly IInfinityTableApi _infTableApi;
        public InfinityTableService(IInfinityTableApi infTableApi)
        {
            _infTableApi = infTableApi;
        }

        public void SetSolidColor(string color)
        {
            _infTableApi.SetSolidColor(color);  
        }
    }
}
