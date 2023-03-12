using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public class Mems : Squad
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SecretIdentity { get; set; }
        public string[] Powers { get; set; }
        public Mems() { }
        public Mems(string name, int age, string secretIdentity, string[] powers)
        {
            Name = name;
            Age = age;
            SecretIdentity = secretIdentity;
            Powers = powers;
        }
    }
}
