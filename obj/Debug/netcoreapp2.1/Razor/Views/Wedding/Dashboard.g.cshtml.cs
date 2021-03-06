#pragma checksum "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b98046f833a75c45c92ae368176400c547f1eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_Dashboard), @"mvc.1.0.view", @"/Views/Wedding/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/Dashboard.cshtml", typeof(AspNetCore.Views_Wedding_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b98046f833a75c45c92ae368176400c547f1eb", @"/Views/Wedding/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 186, true);
            WriteLiteral("<a href=\"Logout\">Logout</a>\n<h1>Welcome to the Wedding Planner!</h1>\n\n        <div id=\"Weddings\">\n                <a class=\"btn btn-primary\" href=\"ShowPlan\">New Wedding</a>\n        <hr>\n");
            EndContext();
            BeginContext(219, 393, true);
            WriteLiteral(@"                <table class=""table"">
                    <thead class=""thead-light"">
                        <tr>
                            <th>Wedding</th>
                            <th>Date</th>
                            <th>Guest</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
                
");
            EndContext();
#line 19 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                     foreach(var info in ViewBag.allWeddings)
                    {
                        var attending = false;


#line default
#line hidden
            BeginContext(744, 73, true);
            WriteLiteral("                        <tr scope=\"row\">\n                            <td>");
            EndContext();
            BeginContext(818, 14, false);
#line 24 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                           Write(info.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(832, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(838, 14, false);
#line 24 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                                               Write(info.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(852, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(891, 9, false);
#line 25 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                           Write(info.Date);

#line default
#line hidden
            EndContext();
            BeginContext(900, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(939, 20, false);
#line 26 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                           Write(info.GuestList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(959, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 27 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                             foreach(var x in info.GuestList)
                            {
                                

#line default
#line hidden
#line 29 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                                 if(x.UserId == ViewBag.UserId)
                                {
                                attending = true;
                                }

#line default
#line hidden
#line 32 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                                    
                            }

#line default
#line hidden
            BeginContext(1272, 33, true);
            WriteLiteral("                            <td>\n");
            EndContext();
#line 35 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                                 if(attending == true)
                                    {

#line default
#line hidden
            BeginContext(1398, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(1438, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bca3350e10404d519dd47d6269a3555e", async() => {
                BeginContext(1491, 123, true);
                WriteLiteral("\n                                            <input type=\"submit\" value=\"UN-RSVP\">\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1452, "/UNRSVP/", 1452, 8, true);
#line 37 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
AddHtmlAttributeValue("", 1460, info.WeddingId, 1460, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1621, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 40 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                                    }
                                else
                                    {

#line default
#line hidden
            BeginContext(1735, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(1775, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2952a99da624b159603d31afb6f32c4", async() => {
                BeginContext(1826, 116, true);
                WriteLiteral("\n                                        <input type=\"submit\" value=\"RSVP\">\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1789, "/RSVP/", 1789, 6, true);
#line 43 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
AddHtmlAttributeValue("", 1795, info.WeddingId, 1795, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1949, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 46 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1988, 51, true);
            WriteLiteral("                                <!-- <a href=\"RSVP/");
            EndContext();
            BeginContext(2040, 14, false);
#line 47 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                                              Write(info.WeddingId);

#line default
#line hidden
            EndContext();
            BeginContext(2054, 55, true);
            WriteLiteral("\">RSVP</a>\n                            <a href=\"UNRSVP/");
            EndContext();
            BeginContext(2110, 14, false);
#line 48 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                                       Write(info.WeddingId);

#line default
#line hidden
            EndContext();
            BeginContext(2124, 82, true);
            WriteLiteral("\">UN-RSVP</a>-->\n                            </td> \n                        </tr>\n");
            EndContext();
#line 51 "/Users/ShadrachTuck/Desktop/codingdojo/C#/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(2228, 68, true);
            WriteLiteral("                    </tbody>\n                </table>\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
