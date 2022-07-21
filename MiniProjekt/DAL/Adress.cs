using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt.DAL
{
    public class Adress
    {
        public sbyte? ID { get; set; }
        public int Host { get; set; }
        public string HostType { get; set; }
        public int Typ { get; set; }
        public int AdresKodPocztowy { get; set; }
        public string AdresPoczta { get; set; }
        public string AdresMiejscowosc { get; set; }
        public string AdresGmina { get; set; }

        public Adress(){}
    }
}