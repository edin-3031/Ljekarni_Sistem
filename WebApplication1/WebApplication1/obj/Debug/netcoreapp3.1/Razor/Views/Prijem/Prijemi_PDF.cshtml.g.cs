#pragma checksum "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f650bb3ea95c515b832728e4d5b3ac5830aea761"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prijem_Prijemi_PDF), @"mvc.1.0.view", @"/Views/Prijem/Prijemi_PDF.cshtml")]
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
#line 1 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f650bb3ea95c515b832728e4d5b3ac5830aea761", @"/Views/Prijem/Prijemi_PDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Prijem_Prijemi_PDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lista_pdfVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
  
    Layout = null;
    DateTime datum = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #hader_podloga {
        position: relative;
        height: 10%;
        width: 100%;
        background-color: rgb(11, 105, 154);
        border-radius: 20px;
    }

    #naslov {
        position: relative;
        text-align: center;
        color: white;
        font-size: 500%;
        top: 24px;
    }

    #opis_tekst {
        word-wrap: break-word;
    }

    table {
        text-align: center;
    }

    td {
        padding: 0.5%;
        border: 1px solid black;
        border-top: 0px;
        border-left: 2px solid black;
        border-right: 2px solid black;
        border-bottom: 2px solid black;
    }
    th {
        border-bottom: 2px solid black;
    }
    table {
        width: 100%;
    }
    #ikona{
        height:20px;
        width:20px;
    }
</style>
<div id=""glavni"">
    <div id=""hader_podloga"">
        <p id=""naslov"">LJEKARNI SISTEM </p>
    </div>
    <hr />
    <div style=""float:left; display:inline;"">");
#nullable restore
#line 56 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                                        Write(datum.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 56 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                                                    Write(datum.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 56 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                                                                  Write(datum.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@".</div>
    <h3 style=""text-align:center;"">PRIJEMI</h3>
    <hr />
    <div id=""podaci"">
        <table class=""table"">
            <thead>
            <th>
                Datum prijema
            </th>
            <th>
                Pacijent
            </th>
            <th>
                Ljekar
            </th>
            <th>
                Hitno
            </th>
            <th>
                Datum nalaza
            </th>
            <th>
                Opis nalaza
            </th>
            </thead>
            <tbody>
");
#nullable restore
#line 82 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                 foreach (var x in Model.lista)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 86 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                       Write(x.datumPrijema);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 89 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                       Write(x.pacijent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 92 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                       Write(x.ljekar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 94 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                          
                            if (x.hitno)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><b>DA</b></td>\r\n");
#nullable restore
#line 98 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>NE</td>\r\n");
#nullable restore
#line 102 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                          
                            if (x.datumNalaza != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
#nullable restore
#line 108 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                               Write(x.datumNalaza);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 110 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>N/A</td>\r\n");
#nullable restore
#line 114 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                          
                            if (x.opis != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td id=\"opis_tekst\">\r\n                                    ");
#nullable restore
#line 120 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                               Write(x.opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 122 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>N/A</td>\r\n");
#nullable restore
#line 126 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 129 "C:\Users\Edin\Desktop\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Prijem\Prijemi_PDF.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lista_pdfVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
