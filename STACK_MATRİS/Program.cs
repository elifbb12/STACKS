using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK_MATRİS
{
    class Program
    {
        static void Main(string[] args)
        {
            //GÖRÜNTÜ İŞLEME
            string directoryname1 = @"c:\xampp";
            Stack<string> st = new Stack<string>();
            st.Push(directoryname1);
            DirectoryInfo di = new DirectoryInfo(directoryname1);
            while (st.Count>0)
            {
                directoryname1 = st.Pop();
                di = new DirectoryInfo(directoryname1);
                foreach(DirectoryInfo dinf in di.GetDirectories())
                {
                    st.Push(dinf.FullName);
                }
                foreach(FileInfo fi in di.GetFiles())
                {
                    Console.WriteLine(fi.FullName);
                }
            }
            Console.ReadLine();
        }
    }
}
