using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        //renkler ile ilgili neyi servis etmek istiyorsak onu buraya yazarız.

        List<Color> GettAll();
        Color GetById(int colorId);
    }
}
