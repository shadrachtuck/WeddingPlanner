#pragma checksum "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/ShowWedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d889901c5e94ea1dc70cf8f63b8414371069dec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_ShowWedding), @"mvc.1.0.view", @"/Views/Wedding/ShowWedding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/ShowWedding.cshtml", typeof(AspNetCore.Views_Wedding_ShowWedding))]
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
#line 1 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d889901c5e94ea1dc70cf8f63b8414371069dec", @"/Views/Wedding/ShowWedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_ShowWedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64de0c562e594d929010f68a32e285d5", async() => {
                BeginContext(39, 180, true);
                WriteLiteral("\n  <meta charset=\"UTF-8\">\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n  <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n  <title>Wedding</title>\n");
                EndContext();
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
            EndContext();
            BeginContext(226, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(227, 364, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011ad2ecd12746fd9bcbe3bc31e74809", async() => {
                BeginContext(233, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(251, 16, true);
                WriteLiteral("  <div>\n    <h1>");
                EndContext();
                BeginContext(268, 15, false);
#line 12 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/ShowWedding.cshtml"
   Write(Model.WedderOne);

#line default
#line hidden
                EndContext();
                BeginContext(283, 5, true);
                WriteLiteral(" and ");
                EndContext();
                BeginContext(289, 15, false);
#line 12 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/ShowWedding.cshtml"
                        Write(Model.WedderTwo);

#line default
#line hidden
                EndContext();
                BeginContext(304, 86, true);
                WriteLiteral(" </h1><a href=\"/Dashboard\">Dashboard</a> | <a href=\"/Logout\">Logout</a>\n    <h3>Date: ");
                EndContext();
                BeginContext(391, 35, false);
#line 13 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/ShowWedding.cshtml"
         Write(Model.Date.ToString("MMM dd, yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(426, 26, true);
                WriteLiteral("</h3>\n    <h3>Guests</h3>\n");
                EndContext();
#line 15 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/ShowWedding.cshtml"
     foreach(var guest in ViewBag.AllGuests.GuestList)
    {

#line default
#line hidden
                BeginContext(513, 9, true);
                WriteLiteral("      <p>");
                EndContext();
                BeginContext(523, 20, false);
#line 17 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/ShowWedding.cshtml"
    Write(guest.User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(543, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(545, 19, false);
#line 17 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/ShowWedding.cshtml"
                          Write(guest.User.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(564, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 18 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/ShowWedding.cshtml"
    }

#line default
#line hidden
                BeginContext(575, 9, true);
                WriteLiteral("  </div>\n");
                EndContext();
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
            EndContext();
            BeginContext(591, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591