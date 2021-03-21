using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK_PUSH_VE_POP_KOMUTLARI
{

    

    class Program
    {


      static int[] stack = new int[100];
      static int sp = -1; //stackta hiç eleman yok demektir.
        static void push(int data)
        {
            sp++;
            stack[sp] = data;

        }
        static int pop()
        {
            int data = stack[sp];
            sp--;
            return data; //return stack [sp--];
        }
     

      static void Main(string[] args)
      {

            push(10);
            push(20);
            Console.WriteLine(pop());
            Console.WriteLine(pop());
            Console.ReadLine();
            //PUSH=İTMEK / STACK'A VERİ EKLENİR.
            //POP İLE STACKTAN VERİ ALIRIZ.
            //VERİ YAPISINI OLUŞTURULARIM.
            //STACKLAR 2 ŞEKİLDE OLUŞUR.(DİZİLER VEYA LİNKED LİSTLERLE)
            //KULLANICIDAN STRİNG İFADE ALALIM.
            //{} [] () İÇ İÇE KULLANILABİLİR.
            

      }
    }
}
