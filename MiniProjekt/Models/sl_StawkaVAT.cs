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
    
    public partial class sl_StawkaVAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sl_StawkaVAT()
        {
            this.tw__Towar = new HashSet<tw__Towar>();
            this.tw__Towar1 = new HashSet<tw__Towar>();
        }
    
        public int vat_Id { get; set; }
        public string vat_Nazwa { get; set; }
        public decimal vat_Stawka { get; set; }
        public string vat_Symbol { get; set; }
        public bool vat_CzySystemowa { get; set; }
        public bool vat_CzyWidoczna { get; set; }
        public int vat_Pozycja { get; set; }
        public int vat_PozSprzedaz { get; set; }
        public int vat_PozZakup { get; set; }
        public int vat_PozRR { get; set; }
        public int vat_PozDomyslna { get; set; }
        public int vat_Rodzaj { get; set; }
        public bool vat_StawkaZagraniczna { get; set; }
        public Nullable<bool> vat_StawkaZagranicznaPdst { get; set; }
        public Nullable<int> vat_IdPanstwo { get; set; }
        public Nullable<bool> vat_UePanstwo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tw__Towar> tw__Towar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tw__Towar> tw__Towar1 { get; set; }
    }
}