using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;

namespace IfsParticipe.Libraries.Filtro
{
    //todos os tipos de filtro
    //public class UsuarioAutorizacaoAttribute : Attribute, IAuthorizationFilter, IResourceFilter, IActionFilter, IResourceFilter, IActionFilter, IExceptionFilter, IResultFilter)

    public class UsuarioAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        private string _funcoesPermissao;

        public UsuarioAutorizacaoAttribute(string funcoesPermissao)
        {
            _funcoesPermissao = funcoesPermissao;
        }

        LoginUsuario _loginUsuario;

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            _loginUsuario = (LoginUsuario) context.HttpContext.RequestServices.GetService(typeof(LoginUsuario));
            Usuario usuario = _loginUsuario.GetUsuario();
            if(usuario == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Login" }));
            }else if (!_funcoesPermissao.Contains(usuario.Tipo))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "AcessoNegado" }));
            }


        }
    }
}
