#pragma checksum "/home/hector/platzi/platzi-asp-net-core/Views/School/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b882bf9b5b6190c4193daae3f898b476c5052e22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_Index), @"mvc.1.0.view", @"/Views/School/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/School/Index.cshtml", typeof(AspNetCore.Views_School_Index))]
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
#line 1 "/home/hector/platzi/platzi-asp-net-core/Views/_ViewImports.cshtml"
using platzi_asp_net_core;

#line default
#line hidden
#line 2 "/home/hector/platzi/platzi-asp-net-core/Views/_ViewImports.cshtml"
using platzi_asp_net_core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b882bf9b5b6190c4193daae3f898b476c5052e22", @"/Views/School/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa5759f893e3c062982c7ef96ef27fe37864c36", @"/Views/_ViewImports.cshtml")]
    public class Views_School_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<School>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 24, true);
            WriteLiteral("\n<!-- Codigo CSHARP -->\n");
            EndContext();
#line 4 "/home/hector/platzi/platzi-asp-net-core/Views/School/Index.cshtml"
  
    ViewData["Title"] = "School information";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(112, 51, true);
            WriteLiteral("\n<div class=\"text-center\">\n  <h1 class=\"display-4\">");
            EndContext();
            BeginContext(164, 17, false);
#line 10 "/home/hector/platzi/platzi-asp-net-core/Views/School/Index.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(181, 18, true);
            WriteLiteral("</h1>\n  <h2>Name: ");
            EndContext();
            BeginContext(200, 10, false);
#line 11 "/home/hector/platzi/platzi-asp-net-core/Views/School/Index.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(210, 24, true);
            WriteLiteral("</h2>\n  <h3>TypeSchool: ");
            EndContext();
            BeginContext(235, 16, false);
#line 12 "/home/hector/platzi/platzi-asp-net-core/Views/School/Index.cshtml"
             Write(Model.TypeSchool);

#line default
#line hidden
            EndContext();
            BeginContext(251, 34, true);
            WriteLiteral("</h3>\n  <address>\n    <p>Address: ");
            EndContext();
            BeginContext(286, 13, false);
#line 14 "/home/hector/platzi/platzi-asp-net-core/Views/School/Index.cshtml"
           Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(299, 21, true);
            WriteLiteral("</p>\n    <p>Country: ");
            EndContext();
            BeginContext(321, 13, false);
#line 15 "/home/hector/platzi/platzi-asp-net-core/Views/School/Index.cshtml"
           Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(334, 18, true);
            WriteLiteral("</p>\n    <p>City: ");
            EndContext();
            BeginContext(353, 10, false);
#line 16 "/home/hector/platzi/platzi-asp-net-core/Views/School/Index.cshtml"
        Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(363, 48, true);
            WriteLiteral("</p>\n  </address>\n  <p><strong>foundation year: ");
            EndContext();
            BeginContext(412, 20, false);
#line 18 "/home/hector/platzi/platzi-asp-net-core/Views/School/Index.cshtml"
                         Write(Model.foundationYear);

#line default
#line hidden
            EndContext();
            BeginContext(432, 20, true);
            WriteLiteral("</strong> </p>\n  <p>");
            EndContext();
            BeginContext(453, 20, false);
#line 19 "/home/hector/platzi/platzi-asp-net-core/Views/School/Index.cshtml"
Write(ViewBag.dynamicThing);

#line default
#line hidden
            EndContext();
            BeginContext(473, 12, true);
            WriteLiteral("</p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<School> Html { get; private set; }
    }
}
#pragma warning restore 1591
