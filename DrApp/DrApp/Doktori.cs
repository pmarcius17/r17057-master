
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
    
public partial class Doktori
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Doktori()
    {

        this.Pacijenti = new HashSet<Pacijenti>();

        this.Recepti = new HashSet<Recepti>();

    }


    public int doktorId { get; set; }

    public string ime { get; set; }

    public string prezime { get; set; }

    public string adresa { get; set; }

    public string email { get; set; }

    public string korisnicko_ime { get; set; }

    public string lozinka { get; set; }

    public Nullable<int> lijekId { get; set; }

    public string ponovljena_lozinka { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Pacijenti> Pacijenti { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Recepti> Recepti { get; set; }

}

}
