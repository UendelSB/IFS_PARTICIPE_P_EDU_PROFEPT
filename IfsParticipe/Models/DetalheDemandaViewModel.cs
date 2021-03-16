using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Models
{
    public class DetalheDemandaViewModel
    {

        [NotMapped]
        public Demanda Demanda { get; set; }

        [NotMapped]
        public Avaliacao Avaliacao { get; set; }

        [NotMapped]
        public Comentario Comentario { get; set; }

        [NotMapped]
        public List<Comentario> ComentarioList { get; set; }


        [NotMapped]
        public List<Avaliacao> AvaliacaoList { get; set; }



    }
}
