#pragma checksum "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1fce000bb4945ff1a9c77c6a654efd2d2ef6ad7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job__JobFilter), @"mvc.1.0.view", @"/Views/Job/_JobFilter.cshtml")]
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
#line 1 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\_ViewImports.cshtml"
using JobHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\_ViewImports.cshtml"
using JobHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\_ViewImports.cshtml"
using JobsCatalog.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1fce000bb4945ff1a9c77c6a654efd2d2ef6ad7", @"/Views/Job/_JobFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3482ba852f30749ccce95d4ad9e53d8f89fbd851", @"/Views/_ViewImports.cshtml")]
    public class Views_Job__JobFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Job>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JobDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
   
 Layout = null;
 

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div id=\"job-searchitems\">\r\n \t<ul class=\"post-job-bx browse-job-grid row\">\r\n");
#nullable restore
#line 7 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
          foreach(var x in Model)
 		{

#line default
#line hidden
#nullable disable
            WriteLiteral(" \t\t<li class=\"col-lg-6 col-md-12\">\r\n \t\t\t<div class=\"post-bx\">\r\n \t\t\t\t<div class=\"d-flex m-b30\">\r\n \t\t\t\t\t<div class=\"job-post-info\">\r\n \t\t\t\t\t\t<h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1fce000bb4945ff1a9c77c6a654efd2d2ef6ad74261", async() => {
                WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                                                                                                                     Write(x.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                                                          WriteLiteral(x.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                                                                                  WriteLiteral(x.Title.Replace(" ","-"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n \t\t\t\t\t\t<ul>\r\n \t\t\t\t\t\t\t<li><i class=\"fa fa-map-marker\"></i> ");
#nullable restore
#line 15 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                                                             Write(x.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n \t\t\t\t\t\t\t<li><i class=\"fa fa-bookmark-o\"></i> ");
#nullable restore
#line 16 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                                                             Write(x.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n \t\t\t\t\t\t\t<li><i class=\"fa fa-clock-o\"></i> ");
#nullable restore
#line 17 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                                                          Write(x.PostedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n \t\t\t\t\t\t</ul>\r\n \t\t\t\t\t</div>\r\n \t\t\t\t</div>\r\n \t\t\t\t<div class=\"dez-post-tags clear\">\r\n \t\t\t\t\t<div class=\"post-tags\">\r\n");
#nullable restore
#line 23 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                      foreach (var item in x.Tags.Split(',').ToArray())
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<a href=\"javascript:void(0);\">");
#nullable restore
#line 25 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                                                 Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 26 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"

						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \t\t\t\t\t</div>\r\n \t\t\t\t</div>\r\n \t\t\t\t<br>\r\n \t\t\t\t<div class=\"d-flex\">\r\n \t\t\t\t\t<div class=\"job-time mr-auto\">\r\n \t\t\t\t\t\t<a href=\"javascript:void(0);\"><span>");
#nullable restore
#line 34 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                                                        Write(x.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n \t\t\t\t\t</div>\r\n \t\t\t\t\t<div class=\"salary-bx\">\r\n \t\t\t\t\t\t<span>");
#nullable restore
#line 37 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                          Write(x.MinSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 37 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
                                         Write(x.MaxSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n \t\t\t\t\t</div>\r\n \t\t\t\t</div>\r\n \t\t\t\t<label class=\"like-btn\">\r\n \t\t\t\t\t<input type=\"checkbox\">\r\n \t\t\t\t\t<span class=\"checkmark\"></span>\r\n \t\t\t\t</label>\r\n \t\t\t</div>\r\n \t\t</li>\r\n");
#nullable restore
#line 46 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\_JobFilter.cshtml"
 		}

#line default
#line hidden
#nullable disable
            WriteLiteral(" \t</ul>\r\n </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Job>> Html { get; private set; }
    }
}
#pragma warning restore 1591