using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt.DAL
{
    public class Email
    {
        public sbyte? Am_Id { get; set; }
        public int Am_IdAdres { get; set; }
        public string Am_Email { get; set; }
        public int Am_Rodzaj { get; set; }
        public int Am_Podstawowy { get; set; }

        public Email(){}
    }
}
