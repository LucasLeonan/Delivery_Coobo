using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Delivery_Coobo.Models
{
    public class Categorias
    {
        public Categorias()
        {
            Projeto = new List<Projetos>();
        }

        public int CategoriasID { get; set; }

        [StringLength(120)]
        public string Nome_Categoria { get; set; }
        public string Descricao { get; set; }

        public virtual Categorias Categoria { get; set; }
        public ICollection<Projetos> Projeto { get; set; }
    }
}