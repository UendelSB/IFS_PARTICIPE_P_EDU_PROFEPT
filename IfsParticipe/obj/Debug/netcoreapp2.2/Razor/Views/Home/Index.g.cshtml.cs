#pragma checksum "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b8f08b92f21abe63b0dfdd3483147c7c0a8f789"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8f08b92f21abe63b0dfdd3483147c7c0a8f789", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(68, 475, true);
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""/resources/lib/votacao_files/stacks.css"">
<link rel=""stylesheet"" type=""text/css"" href=""/resources/lib/votacao_files/primary.css"">

<main role=""main"">


    <section class=""container"" id=""order"" style=""margin-top: 50px"">

        <h2 class=""title-doc"">Demandas da Comunidade </h2>


        <h4 class=""subtitle-doc"">

            <input type=""button"" value=""Nova Demanda"" class=""btn btn-outline-success my-2 my-sm-0""");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 543, "\"", 604, 3);
            WriteAttributeValue("", 554, "location.href=\'", 554, 15, true);
#line 20 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Home\Index.cshtml"
WriteAttributeValue("", 569, Url.Action("NovaDemanda", "Home"), 569, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 603, "\'", 603, 1, true);
            EndWriteAttribute();
            BeginContext(605, 534, true);
            WriteLiteral(@" />
   
        </h4>
        <div id=""code_cart"">
            <div class=""card"">
                <table class=""table-responsive-sm table-hover shopping-cart-wrap"">

                    <tbody>

                        <tr>
                            <td class=""text-center"" style=""padding-bottom: 1em;width:17%;vertical-align:bottom"">

                                <div class=""js-voting-container grid jc-center fd-column ai-stretch gs4 fc-black-200"" data-post-id=""40333689"">

                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1139, "\'", 1184, 1);
#line 34 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Home\Index.cshtml"
WriteAttributeValue("", 1146, Url.Action("DetalharDemanda", "Home"), 1146, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1185, 440, true);
            WriteLiteral(@" class=""question-hyperlink"" style=""font-size:1.61538462rem !important"">0</a>
                                    <dl class=""dlist-inline small"">
                                        <dt>Votos </dt>
                                    </dl>

                                </div>

                            </td>
                            <td class=""text-left"" style=""padding-bottom: 1em"">
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1625, "\'", 1670, 1);
#line 43 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Home\Index.cshtml"
WriteAttributeValue("", 1632, Url.Action("DetalharDemanda", "Home"), 1632, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1671, 954, true);
            WriteLiteral(@" class=""question-hyperlink"">DISPONIBILIZAR DEMANDAS DO PDI DE FORMA ACESSIVEL E TRANSPARENTE</a>
                                <dl class=""dlist-inline small"">
                                    <dt>Tipo Demanda: </dt>
                                    <dd>Infraestrutura</dd>
                                </dl>
                                <dl class=""dlist-inline small"">
                                    <dt>Ultima Atualização: </dt>
                                    <dd>01/03/2020</dd>
                                </dl>

                            </td>
                        </tr>


                        <tr>
                            <td class=""text-center"" style=""padding-bottom: 1em;width:17%;vertical-align:bottom"">

                                <div class=""js-voting-container grid jc-center fd-column ai-stretch gs4 fc-black-200"" data-post-id=""40333689"">

                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2625, "\'", 2670, 1);
#line 62 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Home\Index.cshtml"
WriteAttributeValue("", 2632, Url.Action("DetalharDemanda", "Home"), 2632, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2671, 440, true);
            WriteLiteral(@" class=""question-hyperlink"" style=""font-size:1.61538462rem !important"">0</a>
                                    <dl class=""dlist-inline small"">
                                        <dt>Votos </dt>
                                    </dl>

                                </div>

                            </td>
                            <td class=""text-left"" style=""padding-bottom: 1em"">
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3111, "\'", 3156, 1);
#line 71 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Home\Index.cshtml"
WriteAttributeValue("", 3118, Url.Action("DetalharDemanda", "Home"), 3118, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3157, 954, true);
            WriteLiteral(@" class=""question-hyperlink"">DISPONIBILIZAR DEMANDAS DO PDI DE FORMA ACESSIVEL E TRANSPARENTE</a>
                                <dl class=""dlist-inline small"">
                                    <dt>Tipo Demanda: </dt>
                                    <dd>Infraestrutura</dd>
                                </dl>
                                <dl class=""dlist-inline small"">
                                    <dt>Ultima Atualização: </dt>
                                    <dd>01/03/2020</dd>
                                </dl>

                            </td>
                        </tr>


                        <tr>
                            <td class=""text-center"" style=""padding-bottom: 1em;width:17%;vertical-align:bottom"">

                                <div class=""js-voting-container grid jc-center fd-column ai-stretch gs4 fc-black-200"" data-post-id=""40333689"">

                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 4111, "\'", 4156, 1);
#line 90 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Home\Index.cshtml"
WriteAttributeValue("", 4118, Url.Action("DetalharDemanda", "Home"), 4118, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4157, 440, true);
            WriteLiteral(@" class=""question-hyperlink"" style=""font-size:1.61538462rem !important"">0</a>
                                    <dl class=""dlist-inline small"">
                                        <dt>Votos </dt>
                                    </dl>

                                </div>

                            </td>
                            <td class=""text-left"" style=""padding-bottom: 1em"">
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 4597, "\'", 4642, 1);
#line 99 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Home\Index.cshtml"
WriteAttributeValue("", 4604, Url.Action("DetalharDemanda", "Home"), 4604, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4643, 816, true);
            WriteLiteral(@" class=""question-hyperlink"">DISPONIBILIZAR DEMANDAS DO PDI DE FORMA ACESSIVEL E TRANSPARENTE</a>
                                <dl class=""dlist-inline small"">
                                    <dt>Tipo Demanda: </dt>
                                    <dd>Infraestrutura</dd>
                                </dl>
                                <dl class=""dlist-inline small"">
                                    <dt>Ultima Atualização: </dt>
                                    <dd>01/03/2020</dd>
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
