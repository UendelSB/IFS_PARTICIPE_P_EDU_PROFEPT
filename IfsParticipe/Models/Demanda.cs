using IfsParticipe.Libraries.Lang;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Models
{
    public class Demanda
    {

        public int Id { get; set; }
        public int IdUsuario { get; set; }

        public int IdPDI { get; set; }

        [ForeignKey("IdPDI")]
        public virtual PDI Pdi { get; set; }

        private string _Titulo;
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MaxLength(60, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        public string Titulo {
            get
            {
                if (string.IsNullOrEmpty(_Titulo))
                {
                    return _Titulo;
                }
                return _Titulo.ToUpper();
            }
            set
            {
                _Titulo = value;
            }

        }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MaxLength(500, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        public string Descricao { get; set; }

        public int? Situacao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E005")]
        public int? Categoria { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }

        [NotMapped]
        public List<SelectListItem> SituacaoList { get; set; }

        [NotMapped]
        public List<SelectListItem> CategoriaList { get; set; }

        [NotMapped]
        public int CountAva { get; set; }

        [NotMapped]
        public int CountComent { get; set; }

        [NotMapped]
        public List<Avaliacao> Avaliacoes { get; set; }

    }
}
