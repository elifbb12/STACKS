using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK
{
    class Program
    {
        static void a3()
        {
            Console.WriteLine("a3");
        }
        static void a2()
        {
            Console.WriteLine("a2");
            a3();
            //bu adreste saklanacak.
        }
        static void a1()
        {
            Console.WriteLine("a1");
            a2();
            //bu adreste saklanacak.
        }
        static void Main(string[] args)
        {

            a1();
            Console.WriteLine("hoşgeldin");
            Console.ReadLine();




            //VERİ YAPISIDIR.
            //SON GELEN İLK ÇIKAR (LİFO)
            //İLK GELEN SON ÇIKAR(FİLO)
            //STACKLAR OLMADIĞI ZAMAN SADECE DÖRT İŞLEM YAPILIR.PARANTEZ KULLANILMAZ.
            //İÇERSİNDE BİRDEN FAZLA VERİ BARINDIRIR.ÇOKLU YAPIDIR.
            //DİZİLER GİBİDİRLER.
            //BU VERİLERE ULAŞMAK İÇİN BAZI KURALLAR KOYUYORUZ.(FİLO-LİFO)
            //KUYRUK BİR VERİ YAPISIDIR.(İLK GELEN İLK ÇIKAR.)
            //STACK OWERFLOW=TAŞMA
            //INTERRUPTLARDA KULLANILIR.
            //INTERRRUUPT OLMAZSA VİRTUAL MEMORY,SWAP,ROUND ROBİN GİDER
            //STACK OLMAZSA METOTLARI ÇAĞIRAMAYIZ.
            //STACKLAR METOTLARI ÇALIŞTIRAN MEKANİZMADIR.
            //STACKLAR YOKSA METOT YAZILMAZ.
            //STACKLARI PROGRAGRAMLAMA DİLLERİNDE KULLANIRIZ.PARANTEZLİ MATEMATİK İŞLMELERİNDE KULLANILIR.


        }
    }
}
