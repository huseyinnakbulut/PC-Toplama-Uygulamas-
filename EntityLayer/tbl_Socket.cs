//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Socket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Socket()
        {
            this.tbl_CPU = new HashSet<tbl_CPU>();
            this.tbl_MotherBoard = new HashSet<tbl_MotherBoard>();
        }
    
        public int Soket_Id { get; set; }
        public string Soket_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CPU> tbl_CPU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MotherBoard> tbl_MotherBoard { get; set; }
    }
}