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
    
    public partial class funcionalidade_permissao
    {
        public int funcionalidade_permissao_id { get; set; }
        public int grupo_id { get; set; }
        public int funcionalidade_id { get; set; }
        public int permissao_id { get; set; }
        public byte deleted { get; set; }
    
        public virtual funcionalidade funcionalidade { get; set; }
        public virtual permissao permissao { get; set; }
        public virtual grupo grupo { get; set; }
    }
}