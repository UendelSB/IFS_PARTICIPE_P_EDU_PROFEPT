using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using IfsParticipe.Libraries.Lang;

namespace IfsParticipe.Models
{
    public class Contato
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem),ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4,ErrorMessageResourceType = typeof(Mensagem),ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(10, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E004")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Texto { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public DateTime DataIniVig { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public DateTime DataFimVig { get; set; }

    }
}
