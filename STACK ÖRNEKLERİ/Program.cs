using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK_ÖRNEKLERİ
{
    class Program
    {
        static void Main(string[] args)
        {
            //parantezlerin düzgün kapatılması ile ilgili sorunu çözme
            //  abc{{(w[qww]))}}
            //  {{[][[]]  {} () (())}}
            string s = "12([(77)]456)546";
            string left = "([{";
            string right = ")]}";
            Stack<char> st = new Stack<char>();
            int flag = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int adr = left.IndexOf(s[i]);
                if (adr >= 0)
                {
                    st.Push(right[adr]);
                    continue;
                }
                adr = right.IndexOf(s[i]);
                if(adr>=0)
                {
                    if (st.Count == 0) { flag = 1; break; } //hata vermemesi minimize edilmesi için kullandık.
                    char ch = st.Pop();
                    if (ch != right[adr])
                    {
                        flag = 1; break;
                    }
                }

            }
            Console.WriteLine(flag);
            Console.ReadLine();

        }
    }
}
