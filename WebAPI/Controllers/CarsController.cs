using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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

        [HttpGet]
        public List<Car> Get() 
        {
            
            var result = _carService.GetAll();
            return result.Data;


        }
    
    }
}
