#pragma checksum "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a0c728025d906edcf85e965292d82c1fa513cc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demanda_Index), @"mvc.1.0.view", @"/Views/Demanda/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Demanda/Index.cshtml", typeof(AspNetCore.Views_Demanda_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\_ViewImports.cshtml"
using IfsParticipe.Models;

#line default
#line hidden
#line 1 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
using IfsParticipe.Libraries;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a0c728025d906edcf85e965292d82c1fa513cc7", @"/Views/Demanda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00df1ae31e55b786b06c3ce3cbe07b1fe8061a95", @"/Views/_ViewImports.cshtml")]
    public class Views_Demanda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Demanda>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
  

    LoginUsuario _loginUsuario = (LoginUsuario)HttpContextAccessor.HttpContext.RequestServices.GetService(typeof(LoginUsuario));
    Usuario usuario = _loginUsuario.GetUsuario();


#line default
#line hidden
            BeginContext(309, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var msgValidS = TempData["MSG_S"];
    var msgValidE = TempData["MSG_E"];

#line default
#line hidden
            BeginContext(461, 103, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<main role=\"main\">\r\n\r\n\r\n    <section class=\"container\" id=\"order\" style=\"margin-top: 50px\">\r\n\r\n");
            EndContext();
#line 27 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
         if (msgValidS != null)
        {

#line default
#line hidden
            BeginContext(608, 59, true);
            WriteLiteral("            <p id=\"msgsucesso\" class=\"alert alert-success\">");
            EndContext();
            BeginContext(668, 19, false);
#line 29 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                                                      Write(Html.Raw(msgValidS));

#line default
#line hidden
            EndContext();
            BeginContext(687, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 30 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(704, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
         if (msgValidE != null)
        {

#line default
#line hidden
            BeginContext(750, 55, true);
            WriteLiteral("            <p id=\"msgerro\" class=\"alert alert-danger\">");
            EndContext();
            BeginContext(806, 19, false);
#line 34 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                                                  Write(Html.Raw(msgValidE));

#line default
#line hidden
            EndContext();
            BeginContext(825, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 35 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(842, 90, true);
            WriteLiteral("\r\n        <h2 class=\"title-doc\">\r\n            Demandas da Comunidade - PDI IFS VIGENTE\r\n\r\n");
            EndContext();
#line 40 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
            BeginContext(998, 269, false);
#line 42 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
            Write(String.Format("{0} {1} {2}", Model.FirstOrDefault().Pdi.DataIniVig == null ? "-" : Model.FirstOrDefault().Pdi.DataIniVig.Value.ToString("yyyy"), " a ", Model.FirstOrDefault().Pdi.DataFimVig == null ? " - " : Model.FirstOrDefault().Pdi.DataFimVig.Value.ToString("yyyy")));

#line default
#line hidden
            EndContext();
#line 42 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                                                                                                                                                                                                                                                                                                
            }

#line default
#line hidden
            BeginContext(1285, 56, true);
            WriteLiteral("\r\n        </h2>\r\n\r\n\r\n        <h4 class=\"subtitle-doc\">\r\n");
            EndContext();
#line 49 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
             if (usuario.Tipo != 'C')
            {

#line default
#line hidden
            BeginContext(1395, 102, true);
            WriteLiteral("                <input type=\"button\" value=\"Nova Demanda\" class=\"btn btn-outline-success my-2 my-sm-0\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1497, "\"", 1560, 3);
            WriteAttributeValue("", 1507, "location.href=\'", 1507, 15, true);
#line 51 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
WriteAttributeValue("", 1522, Url.Action("NovaDemanda", "Demanda"), 1522, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 1559, "\'", 1559, 1, true);
            EndWriteAttribute();
            BeginContext(1561, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 52 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1581, 220, true);
            WriteLiteral("            </h4>\r\n        <br />\r\n        <div id=\"code_cart\">\r\n\r\n\r\n\r\n\r\n            <div class=\"card\">\r\n                <table class=\"table-responsive-sm table-hover shopping-cart-wrap\">\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 64 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                         if (Model != null)
                        {
                            

#line default
#line hidden
#line 66 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                             foreach (var dem in Model)
                            {

#line default
#line hidden
            BeginContext(1961, 405, true);
            WriteLiteral(@"                                <tr style=""border: 1px solid rgba(0,0,0,.125)"">
                                    <td class=""text-center"" style=""padding-bottom: 1em;width:17%;vertical-align:middle"">

                                        <div class=""js-voting-container grid jc-center fd-column ai-stretch gs4 fc-black-200"" data-post-id=""40333689"">

                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2366, "\'", 2433, 1);
#line 73 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
WriteAttributeValue("", 2373, Url.Action("DetalharDemanda", "Demanda",new { id = dem.Id}), 2373, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2434, 85, true);
            WriteLiteral(" class=\"question-hyperlink\" style=\"font-size:1.61538462rem !important;color:#007bff\">");
            EndContext();
            BeginContext(2520, 12, false);
#line 73 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                                                                                                                                                                                                  Write(dem.CountAva);

#line default
#line hidden
            EndContext();
            BeginContext(2532, 384, true);
            WriteLiteral(@"</a>
                                            <dl class=""dlist-inline small"">
                                                <dt>Votos </dt>
                                            </dl>

                                            <br />
                                            <dl class=""dlist-inline small"">
                                                <dd><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2916, "\'", 2983, 1);
#line 80 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
WriteAttributeValue("", 2923, Url.Action("DetalharDemanda", "Demanda",new { id = dem.Id}), 2923, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2984, 32, true);
            WriteLiteral("><i class=\"far fa-comment\"></i> ");
            EndContext();
            BeginContext(3017, 15, false);
#line 80 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                                                                                                                                                     Write(dem.CountComent);

#line default
#line hidden
            EndContext();
            BeginContext(3032, 330, true);
            WriteLiteral(@" <span class=""sr-only"">(current)</span></a></dd>
                                            </dl>



                                        </div>

                                    </td>
                                    <td class=""text-left"" style=""padding-bottom: 1em"">
                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3362, "\'", 3429, 1);
#line 89 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
WriteAttributeValue("", 3369, Url.Action("DetalharDemanda", "Demanda",new { id = dem.Id}), 3369, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3430, 51, true);
            WriteLiteral(" class=\"question-hyperlink\" style=\"color:#007bff\"> ");
            EndContext();
            BeginContext(3482, 10, false);
#line 89 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                                                                                                                                                            Write(dem.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(3492, 219, true);
            WriteLiteral("</a>\r\n                                        <dl class=\"dlist-inline small\" style=\"margin-top:5px\">\r\n                                            <dt>Tipo Demanda: </dt>\r\n                                            <dd>");
            EndContext();
            BeginContext(3713, 78, false);
#line 92 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                                            Write(dem.CategoriaList.Where(p => p.Value == dem.Categoria.ToString()).First().Text);

#line default
#line hidden
            EndContext();
            BeginContext(3792, 247, true);
            WriteLiteral(" </dd>\r\n                                        </dl>\r\n                                        <dl class=\"dlist-inline small\">\r\n                                            <dt>Situação Atual: </dt>\r\n                                            <dd>");
            EndContext();
            BeginContext(4041, 76, false);
#line 96 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                                            Write(dem.SituacaoList.Where(p => p.Value == dem.Situacao.ToString()).First().Text);

#line default
#line hidden
            EndContext();
            BeginContext(4118, 253, true);
            WriteLiteral(" </dd>\r\n                                        </dl>\r\n                                        <dl class=\"dlist-inline small\">\r\n                                            <dt>Ultima Atualização: </dt>\r\n                                            <dd>  ");
            EndContext();
            BeginContext(4373, 51, false);
#line 100 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                                              Write(dem.DataAtualizacao.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(4425, 136, true);
            WriteLiteral("</dd>\r\n                                        </dl>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 104 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"

                            }

#line default
#line hidden
#line 105 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\Index.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(4621, 231, true);
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div> <!-- card.// -->\r\n        </div> <!-- code-wrap.// -->\r\n    </section>\r\n    <br />\r\n    <br />\r\n    <hr class=\"featurette-divider\">\r\n\r\n\r\n\r\n\r\n\r\n</main>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Demanda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
