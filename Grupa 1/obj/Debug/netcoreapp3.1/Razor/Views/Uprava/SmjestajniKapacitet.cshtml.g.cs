#pragma checksum "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ed94a7f0b0033196d2b899f302ec23c09f6be2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uprava_SmjestajniKapacitet), @"mvc.1.0.view", @"/Views/Uprava/SmjestajniKapacitet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ed94a7f0b0033196d2b899f302ec23c09f6be2", @"/Views/Uprava/SmjestajniKapacitet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Uprava_SmjestajniKapacitet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ed94a7f0b0033196d2b899f302ec23c09f6be24081", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ed94a7f0b0033196d2b899f302ec23c09f6be25352", async() => {
                WriteLiteral("\r\n    <h1 style=\"margin-top: 50px;\">Smještajni kapacitet</h1>\r\n    <h4 style=\"margin-top: 50px;\">Odaberite paviljon i sobu:</h4>\r\n");
#nullable restore
#line 15 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
     using (Html.BeginForm("DajKpacitet", "Uprava", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <select name=\"dlPaviljon\" style=\"width: 300px;margin-top: 20px;\">\r\n            <optgroup label=\"Izaberite paviljon\">\r\n");
#nullable restore
#line 19 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                 foreach (var paviljon in ViewBag.paviljoni)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ed94a7f0b0033196d2b899f302ec23c09f6be26519", async() => {
#nullable restore
#line 21 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                                                     Write(paviljon.Naziv);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                       WriteLiteral(paviljon.PaviljonId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </optgroup>\r\n        </select>\r\n");
                WriteLiteral("        <select name=\"dlSoba\" style=\"width: 300px;margin-top: 20px;\">\r\n            <optgroup label=\"Izaberite sobu\">\r\n");
#nullable restore
#line 28 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                 foreach (var sobe in ViewBag.sobe)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ed94a7f0b0033196d2b899f302ec23c09f6be29250", async() => {
#nullable restore
#line 30 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                                             Write(sobe.BrojSobe);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                       WriteLiteral(sobe.SobaId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </optgroup>\r\n        </select>\r\n");
                WriteLiteral("        <button class=\"btn btn-primary border rounded\" type=\"submit\" style=\"padding: 6px;margin: 15px;padding-left: 23;font-size: 20px;\">Osvježi</button>\r\n");
#nullable restore
#line 36 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div class=""table-responsive"" style=""margin-top: 50px;"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Ime i prezime</th>
                    <th>Paviljon</th>
                    <th>Soba</th>
                    <th>Kanton</th>
                    <th>Fakultet</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 49 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                 foreach (var student in ViewBag.studentiSoba)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                       Write(student.LicniPodaci.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 52 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                                                Write(student.LicniPodaci.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                       Write(student.Soba.Paviljon.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                       Write(student.Soba.BrojSobe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                       Write(student.PrebivalisteInfo.Kanton);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                       Write(student.SkolovanjeInfo.Fakultet);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n                <td align=\"left\"><button");
                BeginWriteAttribute("onclick", " onclick=\"", 2448, "\"", 2532, 3);
                WriteAttributeValue("", 2458, "window.location.href=\'", 2458, 22, true);
#nullable restore
#line 63 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Uprava\SmjestajniKapacitet.cshtml"
WriteAttributeValue("", 2480, Url.Action("Uprava", "Uprava", new { ViewBag.id }), 2480, 51, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2531, "\'", 2531, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-primary border rounded"" type=""button"" style=""padding: 6px;margin: 15px;padding-left: 23;font-size: 20px; width: 200px;"">Gotovo</button></td>
                <td></td>
            </tr>
            </tbody>
        </table>
    </div>
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/bootstrap/js/bootstrap.min.js""></script>
");
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
