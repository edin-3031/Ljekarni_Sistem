#pragma checksum "D:\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Pacijent\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f85600eb3d01cc41c68f615863f0ce926d1c87a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacijent_Unos), @"mvc.1.0.view", @"/Views/Pacijent/Unos.cshtml")]
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
#line 1 "D:\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f85600eb3d01cc41c68f615863f0ce926d1c87a2", @"/Views/Pacijent/Unos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacijent_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Pacijent\Unos.cshtml"
  
    List<Spol> spol = (List<Spol>)ViewData["spol"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .err {
        border: 3px solid red;
        background-color: rgb(255, 122, 122);
        box-shadow: 0px 0px 10px 2px red;
    }
</style>

    <table>
        <tr>
            <td>
                <label>Ime</label>
            </td>
            <td>
                <input id=""ime"" type=""text"" name=""ime"" />
            </td>
        </tr>
        <tr>
            <td>
                <label>Prezime</label>
            </td>
            <td>
                <input id=""prezime"" type=""text"" name=""prezime"" />
            </td>
        </tr>
        <tr>
            <td>
                <label>Datum rođenja</label>
            </td>
            <td>
                <input id=""datum"" type=""date"" name=""datum_rodjenja"" />
            </td>
        </tr>
        <tr>
            <td>
                <label>Spol</label>
            </td>
            <td>
                <select id=""spol"" name=""spol"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f85600eb3d01cc41c68f615863f0ce926d1c87a24931", async() => {
                WriteLiteral("---Odaberite---");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f85600eb3d01cc41c68f615863f0ce926d1c87a26119", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Pacijent\Unos.cshtml"
                     foreach(var x in spol)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f85600eb3d01cc41c68f615863f0ce926d1c87a27401", async() => {
#nullable restore
#line 47 "D:\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Pacijent\Unos.cshtml"
                                             Write(x.Naziv);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "D:\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Pacijent\Unos.cshtml"
                           WriteLiteral(x.SpolID);

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
#line 48 "D:\Ljekarni_Sistem\WebApplication1\WebApplication1\Views\Pacijent\Unos.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </td>
        </tr>
        <tr>
            <td>
                <label>Adresa</label>
            </td>
            <td>
                <input id=""adresa"" type=""text"" name=""adresa"" />
            </td>
        </tr>
        <tr>
            <td>
                <label>Broj telefona</label>
            </td>
            <td>
                <input id=""telefon"" type=""tel"" name=""telefon"" />
            </td>
        </tr>
    </table>
    <button class=""btn btn-primary"" onclick=""valid()"">Snimi</button>
    <script>
        function valid() {
            var ime = document.getElementById(""ime"").value;
            var prezime = document.getElementById(""prezime"").value;
            var datum = document.getElementById(""datum"").value;
            var spol = document.getElementById(""spol"").value;
            var adresa = document.getElementById(""adresa"").value;
            var telefon = document.getElementById(""telefon"").value;

            var prv");
            WriteLiteral(@"i = drugi = treci = cetvrti = false;

            if (ime == """" || ime == null) {
                document.getElementById(""ime"").classList.add(""err"");
                prvi = false;
            }
            else {
                document.getElementById(""ime"").classList.remove(""err"");
                prvi = true;
            }

            if (prezime == """" || prezime == null) {
                document.getElementById(""prezime"").classList.add(""err"");
                drugi = false;
            }
            else {
                document.getElementById(""prezime"").classList.remove(""err"");
                drugi = true;
            }

            if (datum == """" || datum == null) {
                document.getElementById(""datum"").classList.add(""err"");
                treci = false;
            }
            else {
                document.getElementById(""datum"").classList.remove(""err"");
                treci = true;
            }

            if (spol == 0) {
                documen");
            WriteLiteral(@"t.getElementById(""spol"").classList.add(""err"");
                cetvrti = false;
            }
            else {
                document.getElementById(""spol"").classList.remove(""err"");
                cetvrti = true;
            }
            if (prvi && drugi && treci && cetvrti) {
                window.location.href = ""/Pacijent/UnosSnimi?ime="" + ime + ""&&prezime="" + prezime +""&&datum_rodjenja=""+datum+""&&spol=""+spol+""&&adresa=""+adresa+""&&telefon=""+telefon;
            }
        }
    </script>");
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
