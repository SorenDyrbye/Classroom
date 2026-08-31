using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Studerende
    {
        public string Navn { get;  }
        public int Fødsesldagsmåned { get; }
        public int Fødselsdag { get; }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødsesldagsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }
    }

}
