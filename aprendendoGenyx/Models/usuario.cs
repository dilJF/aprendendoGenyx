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
    
    public partial class usuario
    {
        public int usuario_id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public int grupo_id { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string imagem { get; set; }
        public byte[] data_criado { get; set; }
        public System.DateTime ultimo_acesso { get; set; }
        public int qtd_acessos { get; set; }
        public byte ativo { get; set; }
        public byte deleted { get; set; }
    
        public virtual grupo grupo { get; set; }
    }
}
