
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DrApp
{

using System;
    using System.Collections.Generic;
    
public partial class Uputnice
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Uputnice()
    {

        this.Pacijenti = new HashSet<Pacijenti>();

    }


    public int uputnicaId { get; set; }

    public System.DateTime datum { get; set; }

    public string opis { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Pacijenti> Pacijenti { get; set; }

}

}
