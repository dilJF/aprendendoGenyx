//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aprendendoGenyx.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class modulo
    {
        public modulo()
        {
            this.funcionalidade = new HashSet<funcionalidade>();
        }
    
        public int modulo_id { get; set; }
        public string nome { get; set; }
    
        public virtual ICollection<funcionalidade> funcionalidade { get; set; }
    }
}
