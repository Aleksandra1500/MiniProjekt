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
    
    public partial class sl_ModelTowar
    {
        public int mtw_Id { get; set; }
        public int mtw_IdModel { get; set; }
        public int mtw_IdTowar { get; set; }
    
        public virtual tw__Towar tw__Towar { get; set; }
    }
}
