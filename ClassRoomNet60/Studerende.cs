using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Studerende
    {
        public string Navn { get; }
        public int Fødsesldagsmåned { get; }
        public int Fødselsdag { get;  }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødsesldagsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }
        public string årstid()
        {
            if (Fødsesldagsmåned == 12 || Fødsesldagsmåned == 1 || Fødsesldagsmåned == 2)
            { return "Vinter"; }

            else if (Fødsesldagsmåned == 3 || Fødsesldagsmåned == 4 || Fødsesldagsmåned == 5)
            { return "Forår"; }

            else if (Fødsesldagsmåned == 6 || Fødsesldagsmåned == 7 || Fødsesldagsmåned == 8)
            { return "Sommer"; }

            else if (Fødsesldagsmåned == 9 || Fødsesldagsmåned == 10 || Fødsesldagsmåned == 11)
            { return "Efterår"; }

            else  return "Måned findes ikke";
        }
    }

}
