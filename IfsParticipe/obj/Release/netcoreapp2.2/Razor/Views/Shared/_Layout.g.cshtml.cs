#pragma checksum "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a526a620375904e258cb6a029005460cab97fa69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Shared\_Layout.cshtml"
using IfsParticipe.Libraries;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a526a620375904e258cb6a029005460cab97fa69", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00df1ae31e55b786b06c3ce3cbe07b1fe8061a95", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/StyletIfsParticipe.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/resources/logoifs.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Shared\_Layout.cshtml"
   

    LoginUsuario _loginUsuario = (LoginUsuario)HttpContextAccessor.HttpContext.RequestServices.GetService(typeof(LoginUsuario));
    Usuario usuario = _loginUsuario.GetUsuario();


#line default
#line hidden
            BeginContext(310, 40, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(350, 1179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a526a620375904e258cb6a029005460cab97fa696713", async() => {
                BeginContext(356, 102, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(459, 13, false);
#line 18 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(472, 977, true);
                WriteLiteral(@"</title>

    <meta name=""description"" content=""IFS Participe - Planejamento e Gerenciamento de Demandas Escolares"">
    <meta name=""author"" content=""Uendel Batista"">
    <link rel=""stylesheet"" href=""/resources/lib/bootstrap-4.2.1-dist/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""/resources/lib/caroussel/carousel.css"" />

    <link rel=""stylesheet"" href=""/resources/lib/bootstrap-ecommerce-uikit/css/ui.css"" />
    <link rel=""stylesheet"" href=""/resources/lib/bootstrap-ecommerce-uikit/css/responsive.css"" media=""only screen and (max-width: 1200px)"" />
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.6.3/css/all.css"" integrity=""sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/""
          crossorigin=""anonymous"">

    <link rel=""stylesheet"" type=""text/css"" href=""/resources/lib/votacao_files/stacks.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/resources/lib/votacao_files/primary.css"">
    ");
                EndContext();
                BeginContext(1449, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a526a620375904e258cb6a029005460cab97fa698603", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1520, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1529, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1531, 3753, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a526a620375904e258cb6a029005460cab97fa6910823", async() => {
                BeginContext(1537, 222, true);
                WriteLiteral("\r\n    \r\n   \r\n  \r\n    <header>\r\n        <nav class=\"navbar navbar-expand-lg navbar-light fixed-top\" style=\"background-color:#a2e700\">\r\n\r\n\r\n            <a class=\"navbar-brand\" style=\"color:white;font-size:xx-large\" href=\"/\">");
                EndContext();
                BeginContext(1759, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a526a620375904e258cb6a029005460cab97fa6911453", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1830, 413, true);
                WriteLiteral(@"Participe!</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                    aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
");
                EndContext();
#line 49 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Shared\_Layout.cshtml"
                 if (usuario != null)
                {

#line default
#line hidden
                BeginContext(2301, 487, true);
                WriteLiteral(@"                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/""><i class=""fas fa-list""></i> Demandas <span class=""sr-only"">(current)</span></a>
                    </li>

                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/Pdi/Index""><i class=""fas fa-file-archive""></i> PDI <span class=""sr-only"">(current)</span></a>
                    </li>

");
                EndContext();
                BeginContext(3072, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(3903, 167, true);
                WriteLiteral("                </ul>\r\n                    <div class=\"list\">\r\n                        <div style=\"text-align:end\">\r\n\r\n                            <span class=\"bold\"> ");
                EndContext();
                BeginContext(4071, 13, false);
#line 84 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Shared\_Layout.cshtml"
                                           Write(usuario.Login);

#line default
#line hidden
                EndContext();
                BeginContext(4084, 301, true);
                WriteLiteral(@" </span>

                        </div>
                        <div class=""form-row "" style=""float:right"">

                            <span> <a class=""nav-link"" href=""/Home/Logout""><i class=""fas fa-user-alt""></i> Sair</a></span>

                        </div>
                    </div>
");
                EndContext();
#line 93 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Shared\_Layout.cshtml"


                }

#line default
#line hidden
                BeginContext(4408, 74, true);
                WriteLiteral("\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    <div>\r\n\r\n        ");
                EndContext();
                BeginContext(4483, 12, false);
#line 102 "C:\DESENV_PESSOAL\PRODUTO_EDUCACIONAL\PRODUTO_EDUCACIONAL_PROFEPT\IfsParticipe\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4495, 67, true);
                WriteLiteral("\r\n    </div>\r\n    <!-- FOOTER -->\r\n    <footer class=\"container\">\r\n");
                EndContext();
                BeginContext(4698, 579, true);
                WriteLiteral(@"    </footer>
    <!-- Bootstrap core JavaScript
           ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <!-- Just to make our placeholder images work. Don't actually copy the next line! -->
    <script src=""/resources/lib/holder/holder.min.js""></script>
    <script src=""/resources/lib/jquery3.3.1/jquery-3.3.1.min.js""></script>
    <script src=""/resources/lib/popper1.14.6/popper.min.js""></script>
    <script src=""/resources/lib/bootstrap-4.2.1-dist/js/bootstrap.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5284, 200, true);
            WriteLiteral("\r\n</html>\r\n\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        $(\'#msgsucesso\').delay(10000).fadeOut();\r\n        $(\'#msgerro\').delay(10000).fadeOut();\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
