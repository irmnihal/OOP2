using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        // başvuran bilgilerini değerlendirme

        public void BasvuruYap(IKrediManager krediManager)
        {
            //  KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            krediManager.Hesapla();
        }
    }
}
    

