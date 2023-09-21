using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //ATTRIBUTE
    //Bu class bir controller demek bu yapı
    public class CarsController : ControllerBase
    {
        //Bğımlılıklar somu sınıflar üzerinden kuruulmaz.Newleyerek dependency chain oluşturulmaz.
        //Bağımlılıklar soyutlar üzerinden oluşur.field ve ctor kullanarak.
        //Hiçbir katmanda diğer bir katmanın somut sınıfını görmemeliyiz.
        //Console uı hariç referans ver

        //LOOSLY COUPLED 
        //CarMnager a olan bağımlılığını azalttık.Soyuta zayıf bağımlı hale geldi.
        
        
        ICarService _carService; //Bufieldların defaultu private dir
         
        public CarsController(ICarService carService)
        {
            _carService = carService;   
        }

        [HttpGet("getall")]
        
        public IActionResult Get() 
        {
            Thread.Sleep(1000);
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result); //ok-200 döndürmek
            }
            return BadRequest(result); //baqrequest-400 döndürmek

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id) 
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycolor")]
        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }

        [HttpGet("getbybrand")]
        public IActionResult GetCarsByBranID(int id)
        {
            var result =_carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
                return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Post(Car car)
        {
            var result = _carService.Add(car);
             if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result );
        }

       

    }


}
