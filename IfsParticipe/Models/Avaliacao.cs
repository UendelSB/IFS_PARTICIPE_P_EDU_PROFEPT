using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Models
{
    public class Avaliacao
    {

        public int Id { get; set; }

        public int IdUsuario { get; set; }

        public int Nota { get; set; }

        public int? IdDemanda { get; set; }

        [ForeignKey("IdDemanda")]
        public virtual Demanda DemandaPDI { get; set; }

        public int? IdComentario { get; set; }

        [ForeignKey("IdComentario")]
        public virtual Comentario ComentarioPDI { get; set; }

        public char Tipo { get; set; }

        public DateTime DataAtualizacao { get; set; }

    }
}
