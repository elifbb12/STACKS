using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELİ_LİNKED_ÇİFTLİ_LİNKED
{
    class Program
    {
        class tekli
        {
            public int data;
            public tekli next;  //tekli linked list

        }
        static void Main(string[] args)
        {
            tekli t = new tekli();
            t.data = 1;
            tekli w = null;
            w = t;
            t.data = 1;
            // t de adres var t adres tutar = (POİNTER)
            //TÜM NESNELER ASLINDA BİR POİNTER
            //4 BYTE
            //garbage collector temizkler.
            tekli q = new tekli();
            q = t;
            Console.WriteLine(q.data);
            q.data = 2;
            Console.ReadLine();

        }
    }
}
