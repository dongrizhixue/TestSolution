using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLinqSyntax.LinqSelect.Select5();
        }
    }
    class UserInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
