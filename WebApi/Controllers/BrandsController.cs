using Business.Abstracts;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //farlı ortamlarda bun kullanabilecek java python php gibi hepsi olabilir orda karşımıza istekleri karşılayan bir kısım çıkıyor web api controller katmanı istekleri ilk karşılayan karşılık veren yer
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
          CreateBrandResponse createBrandResponse=  _brandService.Add(createBrandRequest);
            //return Created("", createBrandResponse);
            return Ok(createBrandResponse);
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_brandService.GetAll());
        }
    }
}
