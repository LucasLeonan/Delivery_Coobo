using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delivery_Coobo.Models
{
    public class Projetos
    {
        public Projetos()
        {
            Cotacao = new List<Cotacoes>();
        }

        public enum Tipo_Projeto
        {
            Sourcing, Leilão, Spend_Analysis
        }

        public int ProjeTosID {get; set;}
        public string Titulo {get; set;}
        public Tipo_Projeto Tipo {get;set;}
        public int Cod_Proj {get;set;}
        public string Descricao {get;set;}

        public int CategoriasID {get;set;}
        public int EmpresasID {get;set;}
    
    public ICollection<Cotacoes> Cotacao {get;set;}
   }
}