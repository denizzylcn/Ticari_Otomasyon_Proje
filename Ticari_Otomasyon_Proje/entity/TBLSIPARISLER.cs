//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ticari_Otomasyon_Proje.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLSIPARISLER
    {
        public int SıparısID { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<short> Miktar { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
    
        public virtual TBLURUN TBLURUN { get; set; }
    }
}
