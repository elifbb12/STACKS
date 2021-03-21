using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACKLAR_2_ÇİFTLİ_LİNKED_LİST
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
            //BAŞTAN VE SONDAN OKUNDUĞUNDA AYNI PALİNDROMİK KELİMELER.STACKLA ÇÖZ.
            string s = "12321";
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                push((byte)s[i]);
                s1 = s[i] + s1;
            }
            if (s == s1) Console.WriteLine("evet");
            else Console.WriteLine("değil");
            int pal = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (pop() == (byte)s[i])
                {
                    pal = 1;
                    break;
                }

            }
            if (pal==0)
                Console.WriteLine(("evet"));
            else
                Console.WriteLine("değil");
            Console.ReadLine();
            //İNTERRUPT VE METOTLARDA KULLANILIR.
            //CALL İPTAL EDİLİRSE HİÇ BİR METOT ÇALIŞMAZ.
            //STACKLAR YAZILIMLARDA DA KULLANILIR.
            //COMPİLER DA STACK KULLANILIR.
            //POSTFİX İŞLEMLERİ HESAPLAMA MANTIĞINDA KULLANILIR.
            //STACKLAR DİZİLERLE KODLANIR.
            //STACK POİNTER (sp)OLARAK İFADE EDİLİR.
            //CPU NUN REGİSTERLERİNDE DE VARDIR.
            //STACK IN PUSH VE POP METOTLARI VARDI.
            //FİLO-LİFO MANTIĞI
            //KUYRUK MANTIĞININ TERSİDİR.
            //BAŞTAN VE SONDAN OKUNDUĞUNDA AYNI PALİNDROMİK KELİMELER.
        }
    }
}
