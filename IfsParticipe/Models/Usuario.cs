using IfsParticipe.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public char Tipo { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        [Display(Name = "Usuário")]
        public string Login { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MaxLength(10, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        public string Senha { get; set; }

        public DateTime? DataCadastro { get; set; }

    }
}
