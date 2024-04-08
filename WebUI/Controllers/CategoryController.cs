using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebUI.Dtos.CategoryDtos;

namespace WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7011/api/Category");
            if (responseMessage.IsSuccessStatusCode)
            { 
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> CreateCategory(CreateCategoryDto createcategorydto)
        {
            
            var client = _httpClientFactory.CreateClient();
            createcategorydto.CategoryStatus = true;
            var jsonData = JsonConvert.SerializeObject(createcategorydto);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7011/api/Category",content);
            if (responseMessage.IsSuccessStatusCode == true)
            {
                return RedirectToAction("Index");
            }
            else { return View(); }
        }
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7011/api/Category/{id}");
            if(responseMessage.IsSuccessStatusCode) {
                return RedirectToAction("Index");
            }
            else { return View(); }
        }
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7011/api/Category/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCategoryDto>(jsonData);
                return View(values);
            }

            else { return View(); }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            updateCategoryDto.CategoryStatus = true;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCategoryDto);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("https://localhost:7011/api/Category", content);
            if(responseMessage.IsSuccessStatusCode) {  return RedirectToAction("Index"); }
            else { return View(); }
        }
    }
}
