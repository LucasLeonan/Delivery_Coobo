using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Delivery_Coobo.Models
{
    public class Cotacoes
    {
        public enum Tipo_Cotacao
        {
          RFQ, Negociação, Leilão, Cotação_Final
        }
        public Cotacoes()
        {
            Empresa = new List<Empresas>();
        }

        public int CotacoesID { get; set; }
        public int ProjetosID { get; set; }

        public Tipo_Cotacao Etapa { get; set; }
        public float Valor_Cotado { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFIm { get; set; }

        public virtual Projetos Projeto { get; set; }
        public virtual ICollection<Empresas> Empresa { get; set; }
    }
}