#pragma checksum "/home/rigonatto/Documentos/SIEC/MVCMovie/MvcMovie/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6a5ed9e79b88e7bbe85abc32f6fb4239baef0ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/rigonatto/Documentos/SIEC/MVCMovie/MvcMovie/Views/_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rigonatto/Documentos/SIEC/MVCMovie/MvcMovie/Views/_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a5ed9e79b88e7bbe85abc32f6fb4239baef0ac", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/rigonatto/Documentos/SIEC/MVCMovie/MvcMovie/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Generador de Codigo QR</h1>
    <img alt=""Archivo:Escudo Armada Argentina (fidedigno).svg "" class=""n3VNCb"" src=""https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Escudo_Armada_Argentina_%28fidedigno%29.svg/1200px-Escudo_Armada_Argentina_%28fidedigno%29.svg.png"" jsname=""HiaYvf"" jsaction=""load:XAeZkd;"" data-iml=""11009.699999998702"" style=""width: 363.106px; height: 456px; margin: 0px;"">
</div>
");
#nullable restore
#line 9 "/home/rigonatto/Documentos/SIEC/MVCMovie/MvcMovie/Views/Home/Index.cshtml"
 if (ViewBag.QRCodeImage != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 567, "\"", 661, 1);
#nullable restore
#line 11 "/home/rigonatto/Documentos/SIEC/MVCMovie/MvcMovie/Views/Home/Index.cshtml"
WriteAttributeValue("", 573, String.Format("data:image/png;base64,{0}", Convert.ToBase64String(ViewBag.QRCodeImage)), 573, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" />\r\n");
#nullable restore
#line 12 "/home/rigonatto/Documentos/SIEC/MVCMovie/MvcMovie/Views/Home/Index.cshtml"

        }

#line default
#line hidden
#nullable disable
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