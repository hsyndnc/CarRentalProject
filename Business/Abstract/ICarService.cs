using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //Bir iş sınıfı başka sınıfları new lemez 
    //Dependecy Injection kullan

    
    public interface ICarService
    {
        public List<Car> GetAll();
    }
}
