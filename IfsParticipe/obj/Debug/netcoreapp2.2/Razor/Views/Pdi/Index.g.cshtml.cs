#pragma checksum "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "905ade2b00a49dfce13078070afa3baea91e568f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdi_Index), @"mvc.1.0.view", @"/Views/Pdi/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdi/Index.cshtml", typeof(AspNetCore.Views_Pdi_Index))]
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
#line 1 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
using IfsParticipe.Libraries;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905ade2b00a49dfce13078070afa3baea91e568f", @"/Views/Pdi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00df1ae31e55b786b06c3ce3cbe07b1fe8061a95", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PDI>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
  

    LoginUsuario _loginUsuario = (LoginUsuario)HttpContextAccessor.HttpContext.RequestServices.GetService(typeof(LoginUsuario));
    Usuario usuario = _loginUsuario.GetUsuario();


#line default
#line hidden
            BeginContext(309, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var msgValidS = TempData["MSG_S"];
    var msgValidE = TempData["MSG_E"];

#line default
#line hidden
            BeginContext(450, 101, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<main role=\"main\">\r\n\r\n    <section class=\"container\" id=\"order\" style=\"margin-top: 50px\">\r\n");
            EndContext();
#line 26 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
         if (msgValidS != null)
        {

#line default
#line hidden
            BeginContext(595, 59, true);
            WriteLiteral("            <p id=\"msgsucesso\" class=\"alert alert-success\">");
            EndContext();
            BeginContext(655, 19, false);
#line 28 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                                                      Write(Html.Raw(msgValidS));

#line default
#line hidden
            EndContext();
            BeginContext(674, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 29 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(691, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
         if (msgValidE != null)
        {

#line default
#line hidden
            BeginContext(737, 55, true);
            WriteLiteral("            <p id=\"msgerro\" class=\"alert alert-danger\">");
            EndContext();
            BeginContext(793, 19, false);
#line 33 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                                                  Write(Html.Raw(msgValidE));

#line default
#line hidden
            EndContext();
            BeginContext(812, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 34 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(829, 127, true);
            WriteLiteral("\r\n\r\n        <h2 class=\"title-doc\">Plano de Desenvolvimento Institucional - PDI </h2>\r\n\r\n\r\n        <h4 class=\"subtitle-doc\">\r\n\r\n");
            EndContext();
#line 42 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
             if (usuario.Tipo == 'C') {

#line default
#line hidden
            BeginContext(997, 94, true);
            WriteLiteral("            <input type=\"button\" value=\"Novo PDI\" class=\"btn btn-outline-success my-2 my-sm-0\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1091, "\"", 1150, 3);
            WriteAttributeValue("", 1101, "location.href=\'", 1101, 15, true);
#line 43 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
WriteAttributeValue("", 1116, Url.Action("CadastroPDI", "Pdi"), 1116, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 1149, "\'", 1149, 1, true);
            EndWriteAttribute();
            BeginContext(1151, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 44 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1171, 202, true);
            WriteLiteral("\r\n        </h4>\r\n        <div id=\"code_cart\">\r\n\r\n\r\n\r\n            <div class=\"card\">\r\n\r\n                <table class=\"table-responsive-sm table-hover shopping-cart-wrap\">\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 56 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                         foreach (var itemPdi in Model)
                        {

#line default
#line hidden
            BeginContext(1457, 213, true);
            WriteLiteral("                            <tr>\r\n                                <td style=\"width:10%\"></td>\r\n                                <td class=\"text-left\" style=\"padding-bottom: 1em;width:80%;vertical-align:middle\">\r\n\r\n");
            EndContext();
            BeginContext(1825, 241, true);
            WriteLiteral("\r\n                                    <dl class=\"dlist-inline \" style=\"margin-top:7px\">\r\n                                        <dd>\r\n                                            <h2>\r\n                                                PDI IFS ");
            EndContext();
            BeginContext(2068, 193, false);
#line 67 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                                                    Write(String.Format("{0} {1} {2}", itemPdi.DataIniVig == null ? "-" : itemPdi.DataIniVig.Value.ToString("yyyy"), " - ", itemPdi.DataFimVig == null ? " a " : itemPdi.DataFimVig.Value.ToString("yyyy")));

#line default
#line hidden
            EndContext();
            BeginContext(2262, 367, true);
            WriteLiteral(@"
                                            </h2>
                                        </dd>
                                    </dl>


                                    <dl class=""dlist-inline small"">
                                        <dt>Vigência: </dt>
                                        <dd>
                                            ");
            EndContext();
            BeginContext(2631, 203, false);
#line 76 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                                        Write(String.Format("{0} {1} {2}", itemPdi.DataIniVig == null ? "-" : itemPdi.DataIniVig.Value.ToString("dd/MM/yyyy"), " - ", itemPdi.DataFimVig == null ? "-" : itemPdi.DataFimVig.Value.ToString("dd/MM/yyyy")));

#line default
#line hidden
            EndContext();
            BeginContext(2835, 268, true);
            WriteLiteral(@"
                                        </dd>
                                    </dl>

                                    <dl class=""dlist-inline small"">
                                        <dt>Situação: </dt>
                                        <dd>");
            EndContext();
            BeginContext(3105, 84, false);
#line 82 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                                        Write(itemPdi.SituacaoList.Where(p => p.Value == itemPdi.Situacao.ToString()).First().Text);

#line default
#line hidden
            EndContext();
            BeginContext(3190, 287, true);
            WriteLiteral(@" </dd>
                                    </dl>

                                    <dl class=""dlist-inline small"">
                                        <dt>Período Rec. Demandas:</dt>
                                        <dd>

                                            ");
            EndContext();
            BeginContext(3479, 286, false);
#line 89 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                                        Write(String.Format("{0} {1} {2}", itemPdi.DataIniRecDem == null ? "-" : itemPdi.DataIniRecDem.Value.ToString("dd/MM/yyyy"), itemPdi.DataIniRecDem == null && itemPdi.DataFimRecDem == null ? "-" : " a ", itemPdi.DataFimRecDem == null ? "-" : itemPdi.DataFimRecDem.Value.ToString("dd/MM/yyyy")));

#line default
#line hidden
            EndContext();
            BeginContext(3766, 323, true);
            WriteLiteral(@"

                                        </dd>
                                    </dl>

                                    <dl class=""dlist-inline small"">
                                        <dt>Ult. Atualização:</dt>
                                        <dd>
                                            ");
            EndContext();
            BeginContext(4091, 55, false);
#line 97 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                                        Write(itemPdi.DataAtualizacao.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(4147, 253, true);
            WriteLiteral("\r\n                                        </dd>\r\n                                    </dl>\r\n\r\n                                </td>\r\n\r\n                                <td class=\"text-center\" style=\"padding-bottom: 1em;width:20%;vertical-align:middle\">\r\n");
            EndContext();
#line 104 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                                     if (usuario.Tipo == 'C')
                                    {

#line default
#line hidden
            BeginContext(4502, 189, true);
            WriteLiteral("                                        <dl class=\"dlist-inline small\">\r\n                                            <dd>\r\n                                                <a title=\"Alterar\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 4691, "\'", 4755, 1);
#line 108 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
WriteAttributeValue("", 4698, Url.Action("AlterarPDI", "Pdi", new { id = itemPdi.Id }), 4698, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4756, 256, true);
            WriteLiteral(@" class=""btn btn-outline-success"" data-toggle=""tooltip""><i class=""fa fa-edit""></i></a>
                                            </dd>

                                            <dd>
                                                <a title=""Remover""");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 5012, "\'", 5076, 1);
#line 112 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
WriteAttributeValue("", 5019, Url.Action("RemoverPDI", "Pdi", new { id = itemPdi.Id }), 5019, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5077, 186, true);
            WriteLiteral(" class=\"btn btn-outline-danger\" data-toggle=\"tooltip\"><i class=\"fa fa-eraser\"></i></a>\r\n                                            </dd>\r\n                                        </dl>\r\n");
            EndContext();
#line 115 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5302, 82, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 120 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5411, 229, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div> <!-- card.// -->\r\n        </div> <!-- code-wrap.// -->\r\n    </section>\r\n    <br />\r\n    <br />\r\n    <hr class=\"featurette-divider\">\r\n\r\n\r\n\r\n\r\n\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PDI>> Html { get; private set; }
    }
}
#pragma warning restore 1591
