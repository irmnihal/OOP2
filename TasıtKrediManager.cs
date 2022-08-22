using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // kredimagaerdeki hesaplaya sahip oluyor
    internal class TasıtKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
