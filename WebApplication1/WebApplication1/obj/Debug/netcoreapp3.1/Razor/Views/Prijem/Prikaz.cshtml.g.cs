#pragma checksum "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94e3b09410621c0dea0217aa4291f2867f2f4471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prijem_Prikaz), @"mvc.1.0.view", @"/Views/Prijem/Prikaz.cshtml")]
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
#line 1 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e3b09410621c0dea0217aa4291f2867f2f4471", @"/Views/Prijem/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Prijem_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lista_prijemPrikazVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Prijem/Prikaz.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Prijem/Prikaz"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94e3b09410621c0dea0217aa4291f2867f2f44714991", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div id=\"primarno\">\r\n    <div id=\"dugmad\">\r\n        <a id=\"dodaj\" class=\"btn btn-success\" href=\"/Prijem/Unos\">Dodaj</a>\r\n        <a id=\"pdf\" class=\"btn btn-info\" href=\"/Prijem/Prijemi_PDF\">PDF</a>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94e3b09410621c0dea0217aa4291f2867f2f44716345", async() => {
                WriteLiteral("\r\n        <div style=\"position:relative; left:27%; margin:3%;\">\r\n");
#nullable restore
#line 13 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
               if ((Model.datumOD.Day == 1 && Model.datumOD.Month == 1 && Model.datumOD.Year == 1) || (Model.datumDO.Day == 1 && Model.datumDO.Month == 1 && Model.datumDO.Year == 1))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"datetime-local\" name=\"OD\" id=\"OD\" />\r\n                    <input type=\"datetime-local\" name=\"DO\" id=\"DO\" />\r\n");
#nullable restore
#line 17 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"datetime-local\" name=\"OD\" id=\"OD\"");
                BeginWriteAttribute("value", " value=\"", 923, "\"", 977, 1);
#nullable restore
#line 20 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
WriteAttributeValue("", 931, Model.datumOD.ToString("yyyy-MM-ddThh:mm:ss"), 931, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <input type=\"datetime-local\" name=\"DO\" id=\"DO\"");
                BeginWriteAttribute("value", "  value=\"", 1048, "\"", 1103, 1);
#nullable restore
#line 21 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
WriteAttributeValue("", 1057, Model.datumDO.ToString("yyyy-MM-ddThh:mm:ss"), 1057, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 22 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                } 
             

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button type=\"submit\" class=\"btn btn-info\">Traži</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <table class=""table table-striped"">
        <thead>
        <th>Ime i prezime pacijenta</th>
        <th>Datum i vijeme prijema</th>
        <th>Ime i prezime nadležnog ljekara</th>
        <th>HITNO</th>
        <th>Detalji</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 37 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
             foreach (var x in Model.lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                    Write(x.pacijent.Ime+" "+x.pacijent.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                    Write(x.Datum_Vrijeme.Day+"."+x.Datum_Vrijeme.Month + "."+x.Datum_Vrijeme.Year + " "+x.Datum_Vrijeme.Hour+" : "+ x.Datum_Vrijeme.Minute+" h");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                    Write(x.ljekar.Ime+" "+x.ljekar.Prezime+" - "+x.ljekar.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                      
                        if (x.Hitni_Prijem)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><b>DA</b></td>\r\n");
#nullable restore
#line 47 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>NE</td>\r\n");
#nullable restore
#line 51 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <a class=\"btn btn-warning\"");
            BeginWriteAttribute("id", " id=\"", 2350, "\"", 2372, 2);
            WriteAttributeValue("", 2355, "nalaz_", 2355, 6, true);
#nullable restore
#line 54 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
WriteAttributeValue("", 2361, x.PrijemID, 2361, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Nalaz</a>\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2488, "\"", 2526, 2);
            WriteAttributeValue("", 2495, "/Prijem/Izmijeni?id=", 2495, 20, true);
#nullable restore
#line 57 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
WriteAttributeValue("", 2515, x.PrijemID, 2515, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Izmijeni</a><a class=\"btn btn-danger\" style=\"color:white;\"");
            BeginWriteAttribute("id", " id=\"", 2586, "\"", 2609, 2);
            WriteAttributeValue("", 2591, "ukloni_", 2591, 7, true);
#nullable restore
#line 57 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
WriteAttributeValue("", 2598, x.PrijemID, 2598, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Otkaži</a>\r\n                        <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 2719, "\"", 2742, 2);
            WriteAttributeValue("", 2724, "poruka_", 2724, 7, true);
#nullable restore
#line 58 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
WriteAttributeValue("", 2731, x.PrijemID, 2731, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 2755, "\"", 2791, 2);
            WriteAttributeValue("", 2762, "/Prijem/Otkazi?id=", 2762, 18, true);
#nullable restore
#line 58 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
WriteAttributeValue("", 2780, x.PrijemID, 2780, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 2841, "\"", 2860, 2);
            WriteAttributeValue("", 2846, "no_", 2846, 3, true);
#nullable restore
#line 58 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
WriteAttributeValue("", 2849, x.PrijemID, 2849, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                    </td>\r\n                    <script>\r\n                        $(\"#nalaz_");
#nullable restore
#line 61 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                             Write(x.PrijemID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                            $.get(\"/Nalaz/Prikaz?id=");
#nullable restore
#line 62 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                                               Write(x.PrijemID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", function (event) {
                                $(""#box"").html(event);
                                $(""#box"").show();
                                document.getElementById(""box"").style.border = ""3px solid black"";
                            });
                        });

                         $(""#poruka_");
#nullable restore
#line 69 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                               Write(x.PrijemID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 71 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                                  Write(x.PrijemID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 73 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                                      Write(x.PrijemID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 76 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                              Write(x.PrijemID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 77 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
                                      Write(x.PrijemID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n\r\n                    </script>\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prikaz.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div id=\"box\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lista_prijemPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
