using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentmagementLibrary;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            Console.Write("請輸入學生姓名:");
            a.name = Console.ReadLine();
            Console.Write("請輸入學生電話:");
            a.phone = Console.ReadLine();
            Console.Write("請輸入學生地址:");
            a.address = Console.ReadLine();

            Console.WriteLine("學生姓名:{0},電話:{1},住址{2}", a.name, a.phone, a.address);
        }
    }
}
