using IfsParticipe.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Models
{
    public class Comentario
    {

        public int Id { get; set; }

        public int IdUsuario { get; set; }

        public int IdDemanda { get; set; }

        [ForeignKey("IdDemanda")]
        public virtual Demanda DemandaPDI { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }

        [NotMapped]
        public int CountAva { get; set; }

        [NotMapped]
        public List<Avaliacao> Avaliacoes { get; set; }



    }
}
