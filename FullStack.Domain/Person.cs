using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Domain
{
    public class Person
    {
        public string First { get; set; }
        public string Last { get; set; }

        // Message = person.ToString()
        public override string ToString()
        {
            return $"Hello, I am {First} {Last}!";
        }
    }
}
