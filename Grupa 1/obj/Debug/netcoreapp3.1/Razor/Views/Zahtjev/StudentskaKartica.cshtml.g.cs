#pragma checksum "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\StudentskaKartica.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e07d26d2a651576045853c621a712cda0422eb9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zahtjev_StudentskaKartica), @"mvc.1.0.view", @"/Views/Zahtjev/StudentskaKartica.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e07d26d2a651576045853c621a712cda0422eb9d", @"/Views/Zahtjev/StudentskaKartica.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Zahtjev_StudentskaKartica : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px;height: 160px;margin: 15px 0px 0px 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e07d26d2a651576045853c621a712cda0422eb9d4144", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>studentskakarticaview</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e07d26d2a651576045853c621a712cda0422eb9d5424", async() => {
                WriteLiteral(@"
    <div style=""width: 650px;height: 70px;margin: 47px;"">
        <h1 style=""font-size: 50px;font-family: cooper;width: 600px;"">PREGLED KARTICE</h1>
    </div>
    <div class=""border rounded border-primary"" style=""height: 400px;width: 900px;margin: 50px 0px 0px 150px;"">
        <div class=""row"" style=""width: 850px;margin: 30px 0px 0px 30px;"">
            <div class=""col-lg-6"" style=""width: 400px;"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col""><label class=""col-form-label"" style=""margin: 0px 0px 0px 130px;"">STUDENTSKI DOM</label></div>
                    </div>
                    <div class=""row"">
                        <div class=""col""><label class=""col-form-label"" style=""margin: 0px 0px 0px 155px;"">2019/2020</label></div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""row"">
                                <div class=");
                WriteLiteral(@"""col""><label class=""col-form-label"" style=""margin: 0px 0px 0px 70px;"">Soba</label></div>
                            </div>
                            <div class=""row"">
                                <div class=""col""><label class=""col-form-label"" style=""margin: 0px 0px 0px 83px;"">");
#nullable restore
#line 32 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\StudentskaKartica.cshtml"
                                                                                                            Write(ViewBag.Soba);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></div>
                            </div>
                        </div>
                        <div class=""col"">
                            <div class=""row"">
                                <div class=""col""><label class=""col-form-label"" style=""margin: 0px 0px 0px 70px;"">Paviljon</label></div>
                            </div>
                            <div class=""row"">
                                <div class=""col""><label class=""col-form-label"" style=""margin: 0px 0px 0px 90px;"">");
#nullable restore
#line 40 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\StudentskaKartica.cshtml"
                                                                                                            Write(ViewBag.Paviljon);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"" style=""margin: 25px 0px 0px 0px;""><label class=""col-form-label"">Ime</label></div>
                    </div>
                    <div class=""row"">
                        <div class=""col""><label class=""col-form-label text-center border rounded border-secondary"" style=""width: 380px;height: 35px;font-size: 15px;"">");
#nullable restore
#line 48 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\StudentskaKartica.cshtml"
                                                                                                                                                                 Write(ViewBag.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></div>
                    </div>
                    <div class=""row"">
                        <div class=""col""><label class=""col-form-label"">Prezime</label></div>
                    </div>
                    <div class=""row"">
                        <div class=""col""><label class=""col-form-label text-center border rounded border-secondary"" style=""width: 380px;height: 35px;font-size: 15px;"">");
#nullable restore
#line 54 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\StudentskaKartica.cshtml"
                                                                                                                                                                 Write(ViewBag.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"" style=""margin: 0px 0px 0px 0px;"">
                <div class=""container"" style=""width: 260px;"">
                    <div class=""row"">
                        <div class=""col"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e07d26d2a651576045853c621a712cda0422eb9d10412", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3452, "~/images/", 3452, 9, true);
#nullable restore
#line 61 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\StudentskaKartica.cshtml"
AddHtmlAttributeValue("", 3461, ViewBag.Slika, 3461, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                    </div>
                    <div class=""row"">
                        <div class=""col"" style=""height: 38px;""><label class=""col-form-label text-center"" style=""width: 250px;margin: 0px 0px 0px -10px;"">ID</label></div>
                    </div>
                    <div class=""row"">
                        <div class=""col text-center"" style=""height: 38px;""><label class=""col-form-label border rounded border-secondary"" style=""width: 250px;margin: 0px 0px 0px -10px;height: 35px;"">");
#nullable restore
#line 67 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\StudentskaKartica.cshtml"
                                                                                                                                                                                                 Write(ViewBag.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""row"">
                                <div class=""col""><label class=""col-form-label text-center"" style=""width: 95px;"">Fakultet</label></div>
                            </div>
                            <div class=""row"">
                                <div class=""col""><label class=""col-form-label text-center border rounded border-secondary"" style=""width: 95px;"">");
#nullable restore
#line 75 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\StudentskaKartica.cshtml"
                                                                                                                                           Write(ViewBag.Fakultet);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></div>
                            </div>
                        </div>
                        <div class=""col"">
                            <div class=""row"">
                                <div class=""col""><label class=""col-form-label text-center"" style=""width: 95px;"">Kanton</label></div>
                            </div>
                            <div class=""row"">
                                <div class=""col""><label class=""col-form-label text-center border rounded border-secondary"" style=""width: 95px;"">");
#nullable restore
#line 83 "C:\Users\Ehlimana\Desktop\VerifikacijaIValidacijaSoftvera-Vjezbe\Grupa 1\Views\Zahtjev\StudentskaKartica.cshtml"
                                                                                                                                           Write(ViewBag.Kanton);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/bootstrap/js/bootstrap.min.js""></script>
");
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
