using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message):this(success) 
            //Eğer iki parametre girilirse hem bu parametre hemde tek parametreli olanda çalışır.Success bilgisi ona gider.
            //İki parametreli constructor tek parametreliyi kapsıyor.
        {
            Message = message;
            

        }
        public Result(bool success) //Sadece başarı durumu döndüğümüz durum
        {
             
            Success = success;

        }

        public bool Success  { get; }

        public string Message { get; } 
    }
}
