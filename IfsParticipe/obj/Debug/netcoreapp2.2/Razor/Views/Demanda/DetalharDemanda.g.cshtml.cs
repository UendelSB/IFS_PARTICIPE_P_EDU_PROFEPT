#pragma checksum "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed7bc90bbb5da1daf229c3a311f099c7a1fc176c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demanda_DetalharDemanda), @"mvc.1.0.view", @"/Views/Demanda/DetalharDemanda.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Demanda/DetalharDemanda.cshtml", typeof(AspNetCore.Views_Demanda_DetalharDemanda))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7bc90bbb5da1daf229c3a311f099c7a1fc176c", @"/Views/Demanda/DetalharDemanda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00df1ae31e55b786b06c3ce3cbe07b1fe8061a95", @"/Views/_ViewImports.cshtml")]
    public class Views_Demanda_DetalharDemanda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetalheDemandaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 0px; margin-bottom: 0px; height: 73px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
  
    ViewData["Title"] = "DetalharDemanda";
    var msgValidS = TempData["MSG_S"];
    var msgValidE = TempData["MSG_E"];
    bool existComentario = Model.Comentario is null;

#line default
#line hidden
            BeginContext(219, 213, true);
            WriteLiteral("\r\n\r\n<script>\r\n\r\n    function exibirFormComentario() {\r\n\r\n        $(\"#comentTable\").hide();\r\n        $(\"#formComentario\").attr(\'style\', \'display:block !important\');\r\n\r\n    }\r\n\r\n\r\n    $(function () {\r\n\r\n        if (");
            EndContext();
            BeginContext(433, 15, false);
#line 23 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
       Write(existComentario);

#line default
#line hidden
            EndContext();
            BeginContext(448, 223, true);
            WriteLiteral(" == \'false\') {\r\n            $(\"#formComentario\").attr(\'style\', \'display:block !important\');\r\n        }\r\n\r\n    });\r\n\r\n</script>\r\n\r\n<main role=\"main\">\r\n\r\n\r\n    <section class=\"container\" id=\"order\" style=\"margin-top: 50px\">\r\n");
            EndContext();
#line 35 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
         if (msgValidS != null)
        {

#line default
#line hidden
            BeginContext(715, 59, true);
            WriteLiteral("            <p id=\"msgsucesso\" class=\"alert alert-success\">");
            EndContext();
            BeginContext(775, 19, false);
#line 37 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                                                      Write(Html.Raw(msgValidS));

#line default
#line hidden
            EndContext();
            BeginContext(794, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 38 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
        }

#line default
#line hidden
            BeginContext(811, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
         if (msgValidE != null)
        {

#line default
#line hidden
            BeginContext(857, 55, true);
            WriteLiteral("            <p id=\"msgerro\" class=\"alert alert-danger\">");
            EndContext();
            BeginContext(913, 19, false);
#line 42 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                                                  Write(Html.Raw(msgValidE));

#line default
#line hidden
            EndContext();
            BeginContext(932, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 43 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
        }

#line default
#line hidden
            BeginContext(949, 152, true);
            WriteLiteral("\r\n        <div id=\"question-header\" class=\"grid sm:fd-column\">\r\n            <h3 itemprop=\"name\" class=\"fs-headline1 ow-break-word mb8 grid--cell fl1\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1101, "\'", 1179, 1);
#line 46 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
WriteAttributeValue("", 1108, Url.Action("DetalharDemanda", "Demanda",new { id = Model.Demanda.Id }), 1108, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1180, 28, true);
            WriteLiteral(" class=\"question-hyperlink\">");
            EndContext();
            BeginContext(1209, 20, false);
#line 46 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                                                                                                                                                                                              Write(Model.Demanda.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(1229, 69, true);
            WriteLiteral("</a></h3>\r\n        </div>\r\n\r\n        <div class=\"card\">\r\n            ");
            EndContext();
            BeginContext(1298, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed7bc90bbb5da1daf229c3a311f099c7a1fc176c9432", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 50 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Demanda.Id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1342, 1929, true);
            WriteLiteral(@"
            <table class=""table-responsive-sm table-hover shopping-cart-wrap"">

                <tbody>

                    <tr>
                        <td class=""text-center"" style=""padding-bottom: 1em;width:5%;vertical-align:middle"">

                            <div class=""js-voting-container grid jc-center fd-column ai-stretch gs4 fc-black-200"" data-post-id=""40333689"">
                                <button title=""Gostei"" class=""js-vote-up-btn grid--cell s-btn s-btn__unset c-pointer"" data-controller=""s-tooltip"" data-s-tooltip-placement=""right"" aria-pressed=""false"" aria-label=""Up vote"" data-selected-classes=""fc-theme-primary"" aria-describedby=""--stacks-s-tooltip-rnzv4qln""><svg aria-hidden=""true"" class=""m0 svg-icon iconArrowUpLg"" width=""36"" height=""36"" viewBox=""0 0 36 36""><path d=""M2 26h32L18 10 2 26z""></path></svg></button>

                                <div class=""js-vote-count grid--cell fc-black-500 fs-title grid fd-column ai-center"" itemprop=""upvoteCount"" data-value=""0"">0</div>

   ");
            WriteLiteral(@"                             <button title=""Não Gostei"" class=""js-vote-down-btn grid--cell s-btn s-btn__unset c-pointer"" data-controller=""s-tooltip"" data-s-tooltip-placement=""right"" aria-pressed=""false"" aria-label=""Down vote"" data-selected-classes=""fc-theme-primary"" aria-describedby=""--stacks-s-tooltip-e5im5oro""><svg aria-hidden=""true"" class=""m0 svg-icon iconArrowDownLg"" width=""36"" height=""36"" viewBox=""0 0 36 36""><path d=""M2 10h32L18 26 2 10z""></path></svg></button>
                            </div>

                        </td>
                        <td class=""text-left"" width=""70%"" style=""padding-bottom: 1em"">

                            <div class=""card-header"">
                                <dl>
                                    <dd>
                                        <div class=""s-prose js-post-body"" itemprop=""text"">
                                            <p>");
            EndContext();
            BeginContext(3272, 23, false);
#line 73 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                                          Write(Model.Demanda.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(3295, 296, true);
            WriteLiteral(@"</p>
                                        </div>
                                    </dd>
                                </dl>

                                <dl class=""dlist-inline small "">
                                    <dt>Tipo:</dt>
                                    <dd>");
            EndContext();
            BeginContext(3593, 98, false);
#line 80 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                                    Write(Model.Demanda.CategoriaList.Where(p => p.Value == Model.Demanda.Categoria.ToString()).First().Text);

#line default
#line hidden
            EndContext();
            BeginContext(3692, 209, true);
            WriteLiteral(" </dd>\r\n                                </dl>\r\n                                <dl class=\"dlist-inline small\">\r\n                                    <dt>Situação: </dt>\r\n                                    <dd>");
            EndContext();
            BeginContext(3903, 96, false);
#line 84 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                                    Write(Model.Demanda.SituacaoList.Where(p => p.Value == Model.Demanda.Situacao.ToString()).First().Text);

#line default
#line hidden
            EndContext();
            BeginContext(4000, 401, true);
            WriteLiteral(@" </dd>
                                </dl>
                            </div> <!-- box.// -->

                        </td>

                        <td class=""text-center"" width=""12%"" style=""padding-bottom: 1em;vertical-align:bottom"">

                            <dl class=""dlist-inline small"">
                                <dd>
                                    <a title=""Alterar""");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 4401, "\'", 4477, 1);
#line 94 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
WriteAttributeValue("", 4408, Url.Action("AlterarDemanda", "Demanda",new { id = Model.Demanda.Id}), 4408, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4478, 220, true);
            WriteLiteral(" class=\"btn btn-outline-success\" data-toggle=\"tooltip\"><i class=\"fa fa-edit\"></i></a>\r\n                                </dd>\r\n\r\n                                <dd>\r\n                                    <a title=\"Remover\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 4698, "\'", 4774, 1);
#line 98 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
WriteAttributeValue("", 4705, Url.Action("RemoverDemanda", "Demanda",new { id = Model.Demanda.Id}), 4705, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4775, 323, true);
            WriteLiteral(@" class=""btn btn-outline-danger"" data-toggle=""tooltip""><i class=""fa fa-eraser""></i></a>

                                </dd>
                            </dl>
                            <dl class=""dlist-inline small"">
                                <dt>Ult. Atualização: </dt>
                                <dd> ");
            EndContext();
            BeginContext(5100, 61, false);
#line 104 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                                 Write(Model.Demanda.DataAtualizacao.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(5162, 4511, true);
            WriteLiteral(@"</dd>
                            </dl>

                        </td>

                    </tr>

                </tbody>
            </table>
        </div> <!-- card.// -->


        <div id=""code_cart"">
            <div class=""card"">
                <table class=""table-responsive-sm table-hover shopping-cart-wrap"">
                    <thead class=""text-muted"">
                        <tr>
                            <th scope=""col"" width=""15%"" style=""border-bottom: 2px solid #E1E7E3;vertical-align:middle;text-align:right"">Comentários</th>
                            <th scope=""col"" width=""70%"" style=""border-bottom: 2px solid #E1E7E3;vertical-align:middle"">
                                <input type=""button"" value=""Novo"" style=""margin:.7rem!important"" class=""btn btn-outline-success my-2 my-sm-0"" onclick=""exibirFormComentario()"" />
                            </th>
                            <th scope=""col"" width=""12%"" style=""border-bottom: 2px solid #E1E7E3""></th>
                ");
            WriteLiteral(@"        </tr>
                    </thead>
                    <tbody id=""comentTable"">

                        <tr>
                            <td class=""text-left"" width=""15%"" style=""padding-bottom: 1em"">

                                <div class=""js-voting-container grid jc-center fd-column ai-stretch gs4 fc-black-200"" data-post-id=""40333689"">
                                    <button title=""Gostei"" class=""js-vote-up-btn grid--cell s-btn s-btn__unset c-pointer"" data-controller=""s-tooltip"" data-s-tooltip-placement=""right"" aria-pressed=""false"" aria-label=""Up vote"" data-selected-classes=""fc-theme-primary"" aria-describedby=""--stacks-s-tooltip-rnzv4qln""><svg aria-hidden=""true"" class=""m0 svg-icon iconArrowUpLg"" width=""36"" height=""36"" viewBox=""0 0 36 36""><path d=""M2 26h32L18 10 2 26z""></path></svg></button>

                                    <div class=""js-vote-count grid--cell fc-black-500 fs-title grid fd-column ai-center"" itemprop=""upvoteCount"" data-value=""0"">0</div>

                      ");
            WriteLiteral(@"              <button title=""Não Gostei"" class=""js-vote-down-btn grid--cell s-btn s-btn__unset c-pointer"" data-controller=""s-tooltip"" data-s-tooltip-placement=""right"" aria-pressed=""false"" aria-label=""Down vote"" data-selected-classes=""fc-theme-primary"" aria-describedby=""--stacks-s-tooltip-e5im5oro""><svg aria-hidden=""true"" class=""m0 svg-icon iconArrowDownLg"" width=""36"" height=""36"" viewBox=""0 0 36 36""><path d=""M2 10h32L18 26 2 10z""></path></svg></button>
                                </div>

                            </td>
                            <td class=""text-left"" width=""70%"" style=""padding-bottom: 1em"">
                                <div class=""s-prose js-post-body"" itemprop=""text"">
                                    <p>I think what you're trying to do is wrap loooooooooooooong words or URLs so they don't push the size of the table out.  (I've just been trying to do the same thing!)</p>
                                </div>
                            </td>

                           ");
            WriteLiteral(@" <td class=""text-center"" width=""12%"" style=""padding-bottom: 1em;vertical-align:bottom"">

                                <dl class=""dlist-inline small"">
                                    <dd>
                                        <a title=""Alterar"" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                           data-original-title=""Save to Wishlist""><i class=""fa fa-edit""></i></a>
                                    </dd>

                                    <dd>
                                        <a title=""Remover"" href="""" class=""btn btn-outline-danger"" data-toggle=""tooltip""
                                           data-original-title=""Save to Wishlist""><i class=""fa fa-eraser""></i></a>
                                    </dd>
                                </dl>

                                <dl class=""dlist-inline small"">
                                    <dt>Ult. Atualização: </dt>
                                    <dd>01/03/2020</");
            WriteLiteral(@"dd>
                                </dl>

                            </td>


                        </tr>


                    </tbody>
                </table>
            </div> <!-- card.// -->
        </div> <!-- code-wrap.// -->



        <div id=""formComentario"" hidden class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title mb-4"">Novo Comentário</h4>
");
            EndContext();
#line 183 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                 using (Html.BeginForm(null, null, null, FormMethod.Post, false, new { @action = Url.Action("CadastrarComentario", "Demanda") + "#formulario" }))
                {

#line default
#line hidden
            BeginContext(9855, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(9875, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed7bc90bbb5da1daf229c3a311f099c7a1fc176c22792", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 185 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                                    WriteLiteral(Model.Demanda.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 185 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comentario.IdDemanda);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9956, 72, true);
            WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(10028, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed7bc90bbb5da1daf229c3a311f099c7a1fc176c25329", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 187 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comentario.Descricao);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10169, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 190 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                     if (Model.Comentario != null)
                    {

#line default
#line hidden
            BeginContext(10276, 248, true);
            WriteLiteral("                    <div  class=\"validation-summary-errors\" data-valmsg-summary=\"true\">\r\n                        <ul>\r\n                            <li>Campo comentário é obrigatório!</li>\r\n                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 197 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                    }

#line default
#line hidden
            BeginContext(10549, 146, true);
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-outline-success btn-block\">Enviar</button>\r\n                    <p class=\"text-center\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 10695, "\'", 10774, 1);
#line 200 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
WriteAttributeValue("", 10702, Url.Action("DetalharDemanda", "Demanda", new { id = Model.Demanda.Id }), 10702, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10775, 19, true);
            WriteLiteral(">Cancelar</a></p>\r\n");
            EndContext();
#line 201 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Demanda\DetalharDemanda.cshtml"
                }

#line default
#line hidden
            BeginContext(10813, 152, true);
            WriteLiteral("            </div> <!-- card-body.// -->\r\n        </div>\r\n\r\n    </section>\r\n\r\n    <br />\r\n    <br />\r\n    <hr class=\"featurette-divider\">\r\n\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetalheDemandaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
