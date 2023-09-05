using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public interface IEntity
    {
        //IEntityRepository de generic yapıyı kısıtlandırdığımızda
        //T nin IEntity olması gerektiği şartı vardı.
        //IEntityRepository buraya aldığımızda IEntity nin hata verdiğini görürüz
        //Bu yüzden IEntity de taşırız Core katmanına
        //Zaten her projede olacağı için bu Core katmanı IEntitynin de burda olması gerekir.
        //Core katmanı diğer katmanlara bağımlı olmaz referans almaz.



    }
}
