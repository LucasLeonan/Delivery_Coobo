using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Delivery_Coobo.Models
{
    public class Empresas
    {
         public Empresas()
        {
            Projeto = new List<Projetos>();
        }

        public int EmpresasID { get; set; }


        [StringLength(80)]
        public string Nome_Empresa { get; set; }
        [StringLength(80)]
        public string Nome_Contato { get; set; }
        [StringLength(50)]
        public string Email {get;set;}
        public string Telefone { get; set;}
        [Range(0, int.MaxValue, ErrorMessage = "Inserir apenas múmeros")]
        public string CNPJ { get; set; }
        
        public string Descricao { get; set; }


        public virtual ICollection<Projetos> Projeto { get; set;}
        
        }
}