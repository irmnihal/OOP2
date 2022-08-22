using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // kredimagaerdeki hesaplaya sahip oluyor
    internal class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("konut kredisi ödeme planı hesaplandı");
        }
    }
}
