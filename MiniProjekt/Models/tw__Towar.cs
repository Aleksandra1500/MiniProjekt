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
    
    public partial class tw__Towar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tw__Towar()
        {
            this.sl_ModelTowar = new HashSet<sl_ModelTowar>();
            this.tw__Towar1 = new HashSet<tw__Towar>();
        }
    
        public int tw_Id { get; set; }
        public bool tw_Zablokowany { get; set; }
        public int tw_Rodzaj { get; set; }
        public string tw_Symbol { get; set; }
        public string tw_Nazwa { get; set; }
        public string tw_Opis { get; set; }
        public Nullable<int> tw_IdVatSp { get; set; }
        public Nullable<int> tw_IdVatZak { get; set; }
        public bool tw_JakPrzySp { get; set; }
        public string tw_JednMiary { get; set; }
        public string tw_PKWiU { get; set; }
        public string tw_SWW { get; set; }
        public Nullable<int> tw_IdRabat { get; set; }
        public Nullable<int> tw_IdOpakowanie { get; set; }
        public bool tw_PrzezWartosc { get; set; }
        public Nullable<int> tw_IdPodstDostawca { get; set; }
        public string tw_DostSymbol { get; set; }
        public Nullable<int> tw_CzasDostawy { get; set; }
        public string tw_UrzNazwa { get; set; }
        public Nullable<int> tw_PLU { get; set; }
        public string tw_PodstKodKresk { get; set; }
        public Nullable<int> tw_IdTypKodu { get; set; }
        public bool tw_CenaOtwarta { get; set; }
        public Nullable<bool> tw_WagaEtykiet { get; set; }
        public bool tw_KontrolaTW { get; set; }
        public Nullable<decimal> tw_StanMin { get; set; }
        public string tw_JednStanMin { get; set; }
        public Nullable<int> tw_DniWaznosc { get; set; }
        public Nullable<int> tw_IdGrupa { get; set; }
        public string tw_WWW { get; set; }
        public bool tw_SklepInternet { get; set; }
        public string tw_Pole1 { get; set; }
        public string tw_Pole2 { get; set; }
        public string tw_Pole3 { get; set; }
        public string tw_Pole4 { get; set; }
        public string tw_Pole5 { get; set; }
        public string tw_Pole6 { get; set; }
        public string tw_Pole7 { get; set; }
        public string tw_Pole8 { get; set; }
        public string tw_Uwagi { get; set; }
        public byte[] tw_Logo { get; set; }
        public bool tw_Usuniety { get; set; }
        public Nullable<decimal> tw_Objetosc { get; set; }
        public Nullable<decimal> tw_Masa { get; set; }
        public string tw_Charakter { get; set; }
        public string tw_JednMiaryZak { get; set; }
        public bool tw_JMZakInna { get; set; }
        public string tw_KodTowaru { get; set; }
        public Nullable<int> tw_IdKrajuPochodzenia { get; set; }
        public Nullable<int> tw_IdUJM { get; set; }
        public string tw_JednMiarySprz { get; set; }
        public bool tw_JMSprzInna { get; set; }
        public bool tw_SerwisAukcyjny { get; set; }
        public Nullable<int> tw_IdProducenta { get; set; }
        public bool tw_SprzedazMobilna { get; set; }
        public Nullable<bool> tw_IsFundPromocji { get; set; }
        public Nullable<int> tw_IdFundPromocji { get; set; }
        public Nullable<int> tw_DomyslnaKategoria { get; set; }
        public Nullable<decimal> tw_Wysokosc { get; set; }
        public Nullable<decimal> tw_Szerokosc { get; set; }
        public Nullable<decimal> tw_Glebokosc { get; set; }
        public Nullable<decimal> tw_StanMaks { get; set; }
        public bool tw_Akcyza { get; set; }
        public bool tw_AkcyzaZaznacz { get; set; }
        public Nullable<decimal> tw_AkcyzaKwota { get; set; }
        public bool tw_ObrotMarza { get; set; }
        public bool tw_OdwrotneObciazenie { get; set; }
        public int tw_ProgKwotowyOO { get; set; }
        public bool tw_DodawalnyDoZW { get; set; }
        public string tw_isbn { get; set; }
        public string tw_bloz_7 { get; set; }
        public string tw_bloz_12 { get; set; }
        public string tw_KodUProducenta { get; set; }
        public string tw_Komunikat { get; set; }
        public Nullable<System.DateTime> tw_KomunikatOd { get; set; }
        public int tw_KomunikatDokumenty { get; set; }
        public bool tw_MechanizmPodzielonejPlatnosci { get; set; }
        public int tw_GrupaJpkVat { get; set; }
        public bool tw_OplCukrowaPodlega { get; set; }
        public Nullable<decimal> tw_OplCukrowaObj { get; set; }
        public Nullable<decimal> tw_OplCukrowaZawartoscCukru { get; set; }
        public bool tw_OplCukrowaInneSlodzace { get; set; }
        public bool tw_OplCukrowaSok { get; set; }
        public Nullable<decimal> tw_OplCukrowaKwota { get; set; }
        public bool tw_OplCukrowaKofeinaPodlega { get; set; }
        public Nullable<decimal> tw_OplCukrowaKofeinaKwota { get; set; }
        public bool tw_OplCukrowaNapojWeglElektr { get; set; }
        public Nullable<decimal> tw_OplCukrowaKwotaPowyzej { get; set; }
        public Nullable<decimal> tw_MasaNetto { get; set; }
        public Nullable<int> tw_IdKoduWyrobuAkcyzowego { get; set; }
        public string tw_AkcyzaMarkaWyrobow { get; set; }
        public string tw_AkcyzaWielkoscProducenta { get; set; }
        public Nullable<int> tw_ZnakiAkcyzy { get; set; }
        public Nullable<System.DateTime> tw_DataZmianyVatSprzedazy { get; set; }
        public bool tw_WegielPodlegaOswiadczeniu { get; set; }
        public string tw_WegielOpisPochodzenia { get; set; }
    
        public virtual sl_GrupaTw sl_GrupaTw { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sl_ModelTowar> sl_ModelTowar { get; set; }
        public virtual sl_Rabat sl_Rabat { get; set; }
        public virtual sl_StawkaVAT sl_StawkaVAT { get; set; }
        public virtual sl_StawkaVAT sl_StawkaVAT1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tw__Towar> tw__Towar1 { get; set; }
        public virtual tw__Towar tw__Towar2 { get; set; }
    }
}
