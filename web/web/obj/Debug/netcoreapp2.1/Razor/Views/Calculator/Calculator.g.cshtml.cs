#pragma checksum "/Users/madina/Projects/web/web/Views/Calculator/Calculator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e66e5d4a789f8b91ef04d00427cc06f504a2a1a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Calculator), @"mvc.1.0.view", @"/Views/Calculator/Calculator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Calculator.cshtml", typeof(AspNetCore.Views_Calculator_Calculator))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66e5d4a789f8b91ef04d00427cc06f504a2a1a1", @"/Views/Calculator/Calculator.cshtml")]
    public class Views_Calculator_Calculator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/madina/Projects/web/web/Views/Calculator/Calculator.cshtml"
  
    ViewData["Title"] = "PlusTen";

#line default
#line hidden
            BeginContext(43, 28, true);
            WriteLiteral("\r\n<h2 class=\"subtitle is-2\">");
            EndContext();
            BeginContext(72, 18, false);
#line 5 "/Users/madina/Projects/web/web/Views/Calculator/Calculator.cshtml"
                     Write(ViewData["number"]);

#line default
#line hidden
            EndContext();
            BeginContext(90, 8, true);
            WriteLiteral(" + 10 = ");
            EndContext();
            BeginContext(99, 18, false);
#line 5 "/Users/madina/Projects/web/web/Views/Calculator/Calculator.cshtml"
                                                Write(ViewData["result"]);

#line default
#line hidden
            EndContext();
            BeginContext(117, 5, true);
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
