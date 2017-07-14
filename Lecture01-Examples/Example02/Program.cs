using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentmagementLibrary;

namespace Example02  
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student()
            {
                name = "Darren",
                phone = "0920800507",
                address = "aaa"
            };
            Console.WriteLine("學生姓名:{0},電話:{1},住址{2}",a.name,a.phone,a.address);
        }
    }
}
