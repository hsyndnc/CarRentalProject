using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Vereceğimiz mesajlar sabit olacağı için nesne oluşturmamıza gerek yok.
        //İçindekiler de static olmak zorunda
        //kalıtım yapamaz

        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string CarListed = "Araçlar listelendi";

    }
}
