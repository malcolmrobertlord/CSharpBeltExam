#pragma checksum "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3771b452bf72d2ff8b2d75acbaea995733d6a54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/_ViewImports.cshtml"
using CSharpBeltExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/_ViewImports.cshtml"
using CSharpBeltExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3771b452bf72d2ff8b2d75acbaea995733d6a54", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9bec0ea678113b23e6b156a33f8298a14811622", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Welcome ");
#nullable restore
#line 1 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
       Write(ViewBag.loggedIn.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<table class=\"table table-striped\">\n    <tr>\n        <th>Meet Up</th>\n        <th>Date and Time</th>\n        <th>Duration</th>\n        <th>Event Coordinator</th>\n        <th>No. of Participants</th>\n        <th>Action</th>\n    </tr>\n");
#nullable restore
#line 12 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
     foreach(Meeting m in ViewBag.AllMeetings)
    if(m.Date > DateTime.Now)
    {
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 398, "\"", 426, 2);
            WriteAttributeValue("", 405, "/meeting/", 405, 9, true);
#nullable restore
#line 17 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 414, m.MeetingId, 414, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
                                           Write(m.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n            <td>");
#nullable restore
#line 18 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
           Write(m.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 19 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
           Write(m.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
                       Write(m.TimeType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 20 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
           Write(m.Coordinator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 21 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
           Write(m.InvitesMade.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n");
#nullable restore
#line 23 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
                 if(m.Coordinator.UserId == ViewBag.loggedIn.UserId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 729, "\"", 764, 2);
            WriteAttributeValue("", 736, "/meeting/delete/", 736, 16, true);
#nullable restore
#line 25 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 752, m.MeetingId, 752, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\n");
#nullable restore
#line 26 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
                } else {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
                     if(!m.InvitesMade.Exists(a => a.UserId == ViewBag.loggedIn.UserId))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3771b452bf72d2ff8b2d75acbaea995733d6a547617", async() => {
                WriteLiteral("\n                            <input type=\"hidden\" name=\"navigation\" value=\"dashboard\">\n                            <input type=\"submit\" value=\"Join\" class=\"btn btn-success\">\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 974, "/meeting/join/", 974, 14, true);
#nullable restore
#line 29 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
AddHtmlAttributeValue("", 988, m.MeetingId, 988, 12, false);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
#nullable restore
#line 33 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
                    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3771b452bf72d2ff8b2d75acbaea995733d6a5410027", async() => {
                WriteLiteral("\n                            <input type=\"hidden\" name=\"navigation\" value=\"dashboard\">\n                            <input type=\"submit\" value=\"Leave\" class=\"btn btn-info\">\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1289, "/meeting/unjoin/", 1289, 16, true);
#nullable restore
#line 34 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
AddHtmlAttributeValue("", 1305, m.MeetingId, 1305, 12, false);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
#nullable restore
#line 38 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n        </tr>\n");
#nullable restore
#line 42 "/Users/malcolmrlord/Desktop/CodingDojo/BeltExams/CSharpBeltExam/Views/Home/Dashboard.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<a href=\"/meeting/add\" class=\"btn btn-info\">Add New Activity</a>");
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
