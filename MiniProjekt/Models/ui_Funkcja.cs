//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniProjekt.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ui_Funkcja
    {
        public int uif_Id { get; set; }
        public int uif_IdModulu { get; set; }
        public int uif_Worek { get; set; }
        public int uif_Pozycja { get; set; }
        public Nullable<int> uif_PozycjaOjca { get; set; }
        public Nullable<int> uif_TypOperacji { get; set; }
        public Nullable<int> uif_IdOperacji { get; set; }
        public int uif_Styl { get; set; }
        public string uif_Napis { get; set; }
        public Nullable<int> uif_Podwidok { get; set; }
        public bool uif_Domyslna { get; set; }
        public Nullable<bool> uif_Rozwijaj { get; set; }
        public Nullable<bool> uif_OdRazuMenu { get; set; }
        public string uif_Parametr { get; set; }
    
        public virtual ui_Modul ui_Modul { get; set; }
    }
}
