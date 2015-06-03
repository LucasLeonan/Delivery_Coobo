using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Delivery_Coobo.Models
{
    public class Projetos
    {
        public Projetos()
        {
            Cotacao = new List<Cotacoes>();
            Categoria = new List<Categorias>();
        }
      
        public enum Tipo_Projeto
        {
            Sourcing, Leilão, Spend_Analysis
        }

        public int ProjetosID {get; set;}
        [DataType(DataType.Text)]
        [Display(Name = "Nome Categoria")]
        public int CategoriasID { get; set; }
        
        public int EmpresasID { get; set; }

        public string Titulo {get; set;}
        public Tipo_Projeto Tipo {get;set;}
        public string Cod_Proj {get;set;}
        public string Descricao {get;set;}


        public virtual Empresas Empresa { get; set; }
        public ICollection<Cotacoes> Cotacao {get;set;}
        public ICollection<Categorias> Categoria { get; set; }
   }
}