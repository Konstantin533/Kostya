using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public class Squad 
    {
        public string SquadName { get; set; } 

        public string HomeTown { get; set; } 
        public int Formed { get; set; } 

        public string SecretBase { get; set; } 

        public bool Active { get; set; } = true;

        public Member[] Members { get; set; }

        public Squad() { }
    }
}
