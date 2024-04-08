using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.AboutDtos;

namespace WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultSliderComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7011/api/About");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResaultAboutDto>>(jsonData);
            return View(values);
        }
    }
}
