using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public class Squad
    {
        public string SquadName { get; set; } = "Super hero squad";
        public string HomeTown { get; set; } = "Metro City";
        public int Formed { get; set; } = 2016;

        public string SecretBase { get; set; } = "Super tower";

        public bool Active { get; set; } = true;

        public Squad() { }
    }
}
