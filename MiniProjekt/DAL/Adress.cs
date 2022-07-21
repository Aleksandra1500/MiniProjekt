using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt.DAL
{
    public class Adress
    {
        public int ID { get; set; }
        public int Host { get; set; }
        public string HostType { get; set; }
        public int Typ { get; set; }
        public int AdresKodPocztowy { get; set; }
        public string AdresZagranicznyKodPocztowy { get; set; }
        public string AdresPoczta { get; set; }
        public string AdresMiejscowosc { get; set; }
        public string AdresGmina { get; set; }
        public string AdresPowiat { get; set; }
        public int AdresWojewodztwo { get; set; }
        public string AdresKraj { get; set; }
        public string AdresKodKraju { get; set; }
        public string AdresUlica { get; set; }
        public string AdresNrDomu { get; set; }
        public string AdresNrLokalu { get; set; }
        public string AdresNietypowaLokalizacja { get; set; }
        public string AdresTelefon { get; set; }
        public string AdresFaks { get; set; }
        public string IdentyfikacjaAdresuGLN { get; set; }
        public byte[] Stamp { get; set; }

        public Adress(){}
    }
}