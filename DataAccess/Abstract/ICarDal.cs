using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal :IEntityRepository<Car>
        //Core taşıdığımızdan dolayı IEntityRepository hata veriyor.
        //Core a referans vermemiz gerekiyor.
    {
        List<CarDetailDto> GetDetails();       
    }
}
