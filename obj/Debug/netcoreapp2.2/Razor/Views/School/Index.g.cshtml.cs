#pragma checksum "c:\Users\Hector\platzi\platzi-asp-net-core\Views\School\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c07380e9f562a1752e1ffc6b5c092b6ca031b23c"
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
#line 1 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\_ViewImports.cshtml"
using platzi_asp_net_core;

#line default
#line hidden
#line 2 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\_ViewImports.cshtml"
using platzi_asp_net_core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c07380e9f562a1752e1ffc6b5c092b6ca031b23c", @"/Views/School/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9c994c8a9f955e5ac98e742f2356b1925f342d", @"/Views/_ViewImports.cshtml")]
    public class Views_School_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<School>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 26, true);
            WriteLiteral("\r\n<!-- Codigo CSHARP -->\r\n");
            EndContext();
#line 4 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\School\Index.cshtml"
  
    ViewData["Title"] = "School information";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(119, 53, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n  <h1 class=\"display-4\">");
            EndContext();
            BeginContext(173, 17, false);
#line 10 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\School\Index.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(190, 19, true);
            WriteLiteral("</h1>\r\n  <h2>Name: ");
            EndContext();
            BeginContext(210, 10, false);
#line 11 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\School\Index.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(220, 25, true);
            WriteLiteral("</h2>\r\n  <h3>TypeSchool: ");
            EndContext();
            BeginContext(246, 16, false);
#line 12 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\School\Index.cshtml"
             Write(Model.TypeSchool);

#line default
#line hidden
            EndContext();
            BeginContext(262, 36, true);
            WriteLiteral("</h3>\r\n  <address>\r\n    <p>Address: ");
            EndContext();
            BeginContext(299, 13, false);
#line 14 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\School\Index.cshtml"
           Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(312, 22, true);
            WriteLiteral("</p>\r\n    <p>Country: ");
            EndContext();
            BeginContext(335, 13, false);
#line 15 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\School\Index.cshtml"
           Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(348, 19, true);
            WriteLiteral("</p>\r\n    <p>City: ");
            EndContext();
            BeginContext(368, 10, false);
#line 16 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\School\Index.cshtml"
        Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(378, 50, true);
            WriteLiteral("</p>\r\n  </address>\r\n  <p><strong>foundation year: ");
            EndContext();
            BeginContext(429, 20, false);
#line 18 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\School\Index.cshtml"
                         Write(Model.foundationYear);

#line default
#line hidden
            EndContext();
            BeginContext(449, 21, true);
            WriteLiteral("</strong> </p>\r\n  <p>");
            EndContext();
            BeginContext(471, 20, false);
#line 19 "c:\Users\Hector\platzi\platzi-asp-net-core\Views\School\Index.cshtml"
Write(ViewBag.dynamicThing);

#line default
#line hidden
            EndContext();
            BeginContext(491, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
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
