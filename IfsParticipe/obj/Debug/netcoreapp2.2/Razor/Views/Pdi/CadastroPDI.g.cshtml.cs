#pragma checksum "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a909e066a803977cf87f5aff561f82ca919fd5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdi_CadastroPDI), @"mvc.1.0.view", @"/Views/Pdi/CadastroPDI.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdi/CadastroPDI.cshtml", typeof(AspNetCore.Views_Pdi_CadastroPDI))]
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
#line 2 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
using IfsParticipe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a909e066a803977cf87f5aff561f82ca919fd5f", @"/Views/Pdi/CadastroPDI.cshtml")]
    public class Views_Pdi_CadastroPDI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PDI>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
  
    ViewData["Title"] = "CadastroPDI";

#line default
#line hidden
            BeginContext(91, 446, true);
            WriteLiteral(@"
<main role=""main"">

    <section class=""container"" style=""margin-top: 50px"">
        <div class=""row"">
            <aside class=""col-sm-6"">

                <div id=""code_register_1"">
                    <div class=""card"">
                        <header class=""card-header"">
                            <h4 class=""card-title mt-2"">Novo PDI</h4>
                        </header>
                        <article class=""card-body"">
");
            EndContext();
#line 21 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                             if (TempData["MSG_E"] != null)
                            {

#line default
#line hidden
            BeginContext(629, 75, true);
            WriteLiteral("                                <p id=\"msgerro\" class=\"alert alert-danger\">");
            EndContext();
            BeginContext(705, 27, false);
#line 23 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                                                                      Write(Html.Raw(TempData["MSG_E"]));

#line default
#line hidden
            EndContext();
            BeginContext(732, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 24 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                            }

#line default
#line hidden
            BeginContext(769, 12, true);
            WriteLiteral("          \r\n");
            EndContext();
#line 26 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
              using (Html.BeginForm(null, null, null, FormMethod.Post, false, new { @action = Url.Action("CadastrarPDI", "Pdi")+"#formulario" }))
                            {

                                

#line default
#line hidden
            BeginContext(994, 24, false);
#line 29 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                           Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(1022, 166, true);
            WriteLiteral("                                <div class=\"form-row\">\r\n\r\n                                    <div class=\"col form-group\">\r\n\r\n                                        ");
            EndContext();
            BeginContext(1189, 32, false);
#line 35 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                                   Write(Html.LabelFor(m => m.DataIniVig));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(1264, 91, false);
#line 36 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                                   Write(Html.EditorFor(m => m.DataIniVig, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 179, true);
            WriteLiteral("\r\n                                    </div> <!-- form-group end.// -->\r\n                                    <div class=\"col form-group\">\r\n                                        ");
            EndContext();
            BeginContext(1535, 32, false);
#line 39 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                                   Write(Html.LabelFor(m => m.DataFimVig));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(1610, 91, false);
#line 40 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                                   Write(Html.EditorFor(m => m.DataFimVig, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 232, true);
            WriteLiteral("\r\n                                    </div> <!-- form-group end.// -->\r\n                                </div> <!-- form-row end.// -->\r\n                                <div class=\"form-group\">\r\n                                    ");
            EndContext();
            BeginContext(1934, 30, false);
#line 44 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                               Write(Html.LabelFor(m => m.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(1964, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2003, 103, false);
#line 45 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                               Write(Html.DropDownListFor(m => m.Situacao, Model.SituacaoList, "Selecione", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2106, 231, true);
            WriteLiteral("\r\n                                </div> <!-- form-group end.// -->\r\n                                <div class=\"form-row\">\r\n                                    <div class=\"col form-group\">\r\n                                        ");
            EndContext();
            BeginContext(2338, 35, false);
#line 49 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                                   Write(Html.LabelFor(m => m.DataIniRecDem));

#line default
#line hidden
            EndContext();
            BeginContext(2373, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2416, 94, false);
#line 50 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                                   Write(Html.EditorFor(m => m.DataIniRecDem, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2510, 179, true);
            WriteLiteral("\r\n                                    </div> <!-- form-group end.// -->\r\n                                    <div class=\"col form-group\">\r\n                                        ");
            EndContext();
            BeginContext(2690, 35, false);
#line 53 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                                   Write(Html.LabelFor(m => m.DataFimRecDem));

#line default
#line hidden
            EndContext();
            BeginContext(2725, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2768, 94, false);
#line 54 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                                   Write(Html.EditorFor(m => m.DataFimRecDem, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2862, 138, true);
            WriteLiteral("\r\n                                    </div> <!-- form-group end.// -->\r\n                                </div> <!-- form-row end.// -->\r\n");
            EndContext();
            BeginContext(3002, 242, true);
            WriteLiteral("                                <div class=\"form-group\">\r\n                                    <button type=\"submit\" class=\"btn btn-outline-success btn-block\"> Cadastrar </button>\r\n                                </div> <!-- form-group// -->\r\n");
            EndContext();
#line 61 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
                            }

#line default
#line hidden
            BeginContext(3275, 138, true);
            WriteLiteral("\r\n                        </article> <!-- card-body end .// -->\r\n                        <div class=\"border-top card-body text-center\"> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3413, "\'", 3447, 1);
#line 64 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\CadastroPDI.cshtml"
WriteAttributeValue("", 3420, Url.Action("Index", "Pdi"), 3420, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3448, 220, true);
            WriteLiteral(">Cancelar</a></div>\r\n                    </div> <!-- card.// -->\r\n\r\n                </div> <!-- code-wrap.// -->\r\n            </aside>\r\n        </div>\r\n    </section>\r\n\r\n    <hr class=\"featurette-divider\">\r\n\r\n</main>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PDI> Html { get; private set; }
    }
}
#pragma warning restore 1591
