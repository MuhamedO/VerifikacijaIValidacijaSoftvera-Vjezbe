#pragma checksum "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\PregledPodataka.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e20fa6ca410e86a4e22e9c09334bec49994ee976"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zahtjev_PregledPodataka), @"mvc.1.0.view", @"/Views/Zahtjev/PregledPodataka.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\_ViewImports.cshtml"
using StudentskiDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\_ViewImports.cshtml"
using StudentskiDom.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e20fa6ca410e86a4e22e9c09334bec49994ee976", @"/Views/Zahtjev/PregledPodataka.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Zahtjev_PregledPodataka : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e20fa6ca410e86a4e22e9c09334bec49994ee9763938", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>ViewCreating</title>
    <link rel=""stylesheet"" href=""assets/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""assets/css/styles.css"">
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e20fa6ca410e86a4e22e9c09334bec49994ee9765209", async() => {
                WriteLiteral(@"
    <h1 style=""margin-top: 50px;"">Pregled podataka</h1>
    <div style=""margin-top: 50px;"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <h5 class=""text-right"">Username:</h5>
                </div>
                <div class=""col-md-6"">
                    <h5 class=""text-left"">");
#nullable restore
#line 25 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\PregledPodataka.cshtml"
                                     Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                </div>
            </div>
        </div>
    </div>
    <div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <h5 class=""text-right"">Password:</h5>
                </div>
                <div class=""col-md-6"">
                    <h5 class=""text-left"">");
#nullable restore
#line 37 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\PregledPodataka.cshtml"
                                     Write(ViewBag.Password);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div><button");
                BeginWriteAttribute("onclick", " onclick=\"", 1326, "\"", 1413, 5);
                WriteAttributeValue("", 1336, "window.location.href=\'", 1336, 22, true);
#nullable restore
#line 41 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\PregledPodataka.cshtml"
WriteAttributeValue("", 1358, Url.Action("PregledUpis","Zahtjev"), 1358, 36, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1394, "?id=\'", 1394, 5, true);
                WriteAttributeValue(" ", 1399, "+", 1400, 2, true);
#nullable restore
#line 41 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\PregledPodataka.cshtml"
WriteAttributeValue(" ", 1401, ViewBag.Id, 1402, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" type=\"button\" style=\"margin-top: 50px;\">Nazad</button>\r\n    <div></div>\r\n    <script src=\"assets/js/jquery.min.js\"></script>\r\n    <script src=\"assets/bootstrap/js/bootstrap.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
