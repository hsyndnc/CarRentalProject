using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    
    public class IColorManager : IColorService
    {
        IColorDal _colorDal;

        public IColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Color GetById(int colorId)
        {
            //iş kodları
            return _colorDal.Get(c=>c.ColorId == colorId);  
            
        }

        public List<Color> GettAll()
        {
            return _colorDal.GetAll();

        }
    }
}
