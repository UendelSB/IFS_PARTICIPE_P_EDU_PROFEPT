#pragma checksum "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c4f6dabbfc4237d25673e6f4e4f64c83d6a94a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03c4f6dabbfc4237d25673e6f4e4f64c83d6a94a", @"/Views/Pdi/Index.cshtml")]
    public class Views_Pdi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 318, true);
            WriteLiteral(@"


<main role=""main"">


    <section class=""container"" id=""order"" style=""margin-top: 50px"">

        <h2 class=""title-doc"">Plano de Desenvolvimento Institucional - PDI </h2>


        <h4 class=""subtitle-doc"">

            <input type=""button"" value=""Novo PDI"" class=""btn btn-outline-success my-2 my-sm-0""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 361, "\"", 420, 3);
            WriteAttributeValue("", 371, "location.href=\'", 371, 15, true);
#line 18 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
WriteAttributeValue("", 386, Url.Action("CadastroPDI", "Pdi"), 386, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 419, "\'", 419, 1, true);
            EndWriteAttribute();
            BeginContext(421, 54, true);
            WriteLiteral(" />\r\n\r\n        </h4>\r\n        <div id=\"code_cart\">\r\n\r\n");
            EndContext();
#line 23 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
             if (TempData["MSG_S"] != null)
            {

#line default
#line hidden
            BeginContext(535, 63, true);
            WriteLiteral("                <p id=\"msgsucesso\" class=\"alert alert-success\">");
            EndContext();
            BeginContext(599, 27, false);
#line 25 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
                                                          Write(Html.Raw(TempData["MSG_S"]));

#line default
#line hidden
            EndContext();
            BeginContext(626, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 26 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(647, 354, true);
            WriteLiteral(@"
            <div class=""card"">

                <table class=""table-responsive-sm table-hover shopping-cart-wrap"">

                    <tbody>

                        <tr>
                            <td style=""width:10%""></td>
                            <td class=""text-left"" style=""padding-bottom: 1em;width:80%;vertical-align:middle"">

");
            EndContext();
            BeginContext(1152, 1234, true);
            WriteLiteral(@"
                                <dl class=""dlist-inline "" style=""margin-top:7px"">
                                    <dd><h2>PDI IFS 2020-2024</h2></dd>
                                </dl>


                                <dl class=""dlist-inline small"">
                                    <dt>Vigência: </dt>
                                    <dd>01/10/2020 a 01/10/2024</dd>
                                </dl>

                                <dl class=""dlist-inline small"">
                                    <dt>Situação: </dt>
                                    <dd>Fechado para Novas Demandas</dd>
                                </dl>

                                <dl class=""dlist-inline small"">
                                    <dt>Período Rec. Demandas:</dt>
                                    <dd>01/11/2020 a 01/12/2020</dd>
                                </dl>

                            </td>

                            <td class=""text-center"" style=""padding-bott");
            WriteLiteral("om: 1em;width:20%;vertical-align:middle\">\r\n\r\n                                <dl class=\"dlist-inline small\">\r\n                                    <dd>\r\n                                        <a title=\"Alterar\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2386, "\'", 2425, 1);
#line 66 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Pdi\Index.cshtml"
WriteAttributeValue("", 2393, Url.Action("AlterarPDI", "Pdi"), 2393, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2426, 877, true);
            WriteLiteral(@" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                           data-original-title=""Save to Wishlist""><i class=""fa fa-edit""></i></a>
                                    </dd>

                                    <dd>
                                        <a title=""Remover"" href="""" class=""btn btn-outline-danger"" data-toggle=""tooltip""
                                           data-original-title=""Save to Wishlist""><i class=""fa fa-eraser""></i></a>
                                    </dd>
                                </dl>

                            </td>

                        </tr>

                    </tbody>
                </table>
            </div> <!-- card.// -->
        </div> <!-- code-wrap.// -->
    </section>
    <br />
    <br />
    <hr class=""featurette-divider"">





</main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
