using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult :Result
    {
        public SuccessResult(String message): base(true, message) 
        { 
        
        }
        public SuccessResult() : base(true) 
        {
            //ProductManager de parametresiz şekilde newlendiğinde buraya geliyor burdan true değeri base e yani result sınıfındaki
            //ctora dönüyor ve değeri işliyor.
        }
    }
}
