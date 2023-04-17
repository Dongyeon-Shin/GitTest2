using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest2
{
    internal class Parsnip : IGiveable
    {
        public void Give()
        {
            Console.WriteLine("파스닙을 선물합니다.");
        }
    }
}
