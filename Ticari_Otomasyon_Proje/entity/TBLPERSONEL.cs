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
    
    public partial class TBLPERSONEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLPERSONEL()
        {
            this.TBLMUSTERIHAREKET = new HashSet<TBLMUSTERIHAREKET>();
        }
    
        public int PERSONELID { get; set; }
        public string PERSONELAD { get; set; }
        public string PERSONELSOYAD { get; set; }
        public Nullable<byte> PERSONELDEPARTMAN { get; set; }
    
        public virtual TBLDEPARTMAN TBLDEPARTMAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMUSTERIHAREKET> TBLMUSTERIHAREKET { get; set; }
    }
}
