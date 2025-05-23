using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım__Inheritance_1
{
    internal class Program
    {
        class Hayvan
        {
            public string Ad { get; set; }

            public Hayvan(string ad)
            {
                Ad = ad;
            }

            public virtual void SesCikar()
            {
                Console.WriteLine($"{Ad} bir ses çıkarıyor.");
            }
        }

        // Derived (türetilmiş) sınıf
        class Kedi : Hayvan
        {
            public Kedi(string ad) : base(ad) { }

            // override ile temel sınıfın davranışını değiştiriyoruz
            public override void SesCikar()
            {
                Console.WriteLine($"{Ad} miyavlıyor.");
            }
        }
        static void Main(string[] args)
        {
            Hayvan h1 = new Hayvan("Hayvan");
            h1.SesCikar();

            Kedi kedi1 = new Kedi("Tekir");
            kedi1.SesCikar();
        }
    }
}
