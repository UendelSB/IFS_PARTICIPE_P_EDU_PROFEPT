using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Libraries.Lang;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IfsParticipe.Models
{
    public class PDI
    {

        public int Id { get; set; }
        public int IdUsuario { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E005")]
        [Display(Name = "Situação")]
        public int? Situacao { get; set; }

        [NotMapped]
        public List<SelectListItem> SituacaoList { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [Display(Name = "Início vigência")]
        public DateTime? DataIniVig { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [Display(Name = "Fim vigência")]
        public DateTime? DataFimVig { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Início Rec. Demandas")]
        public DateTime? DataIniRecDem { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fim Rec. Demandas")]
        public DateTime? DataFimRecDem { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

    }

}
