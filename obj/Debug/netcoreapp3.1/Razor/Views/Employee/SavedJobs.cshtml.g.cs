#pragma checksum "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Employee\SavedJobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac27e199ae3a59ff5b528902a401060c2762b4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_SavedJobs), @"mvc.1.0.view", @"/Views/Employee/SavedJobs.cshtml")]
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
#line 1 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\_ViewImports.cshtml"
using JobHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\_ViewImports.cshtml"
using JobHub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac27e199ae3a59ff5b528902a401060c2762b4d", @"/Views/Employee/SavedJobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f86f1abe93baddbc70bbdb19dcadb6a3a92a2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_SavedJobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SavedJobView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_EmployeeSidebar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""page-content bg-white"">
		<!-- contact area -->
        <div class=""content-block"">
			<!-- Browse Jobs -->
			<div class=""section-full bg-white browse-job p-t50 p-b20"">
				<div class=""container"">
					<div class=""row"">
						<div class=""col-xl-3 col-lg-4 m-b30"">
							<div class=""sticky-top"">
								<div class=""candidate-info"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bac27e199ae3a59ff5b528902a401060c2762b4d3924", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

								</div>
							</div>
						</div>
                         <div class=""col-xl-9 col-lg-8 m-b30"">
							<div class=""job-bx save-job table-job-bx clearfix"">
								<div class=""job-bx-title clearfix"">
									<h5 class=""font-weight-700 pull-left text-uppercase"">");
#nullable restore
#line 20 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Employee\SavedJobs.cshtml"
                                                                                    Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" job saved</h5>\r\n\t\t\t\t\t\t\t\t\t<div class=\"float-right\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"select-title\">Sort by freshness</span>\r\n\t\t\t\t\t\t\t\t\t\t<select>\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac27e199ae3a59ff5b528902a401060c2762b4d5826", async() => {
                WriteLiteral("Last 2 Months");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac27e199ae3a59ff5b528902a401060c2762b4d6813", async() => {
                WriteLiteral("Last Months");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac27e199ae3a59ff5b528902a401060c2762b4d7798", async() => {
                WriteLiteral("Last Weeks");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac27e199ae3a59ff5b528902a401060c2762b4d8782", async() => {
                WriteLiteral("Last 3 Days");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</select>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<table>\r\n\t\t\t\t\t\t\t\t\t<thead>\r\n\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t<th></th>\r\n\t\t\t\t\t\t\t\t\t\t\t<th>Job Title</th>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<th>Saved Date</th>\r\n\t\t\t\t\t\t\t\t\t\t\t<th></th>\r\n\t\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t\t</thead>\r\n\t\t\t\t\t\t\t\t\t<tbody>\r\n");
#nullable restore
#line 42 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Employee\SavedJobs.cshtml"
                                         foreach(var x in Model)
										{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"job-post-company\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"javascript:void(0);\"><span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("alt", " alt=\"", 1507, "\"", 1513, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"images/logo/icon2.png\"/>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</span></a>\r\n\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"job-name\"><a href=\"job-detail.html\">");
#nullable restore
#line 51 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Employee\SavedJobs.cshtml"
                                                                                      Write(x.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"date\">");
#nullable restore
#line 53 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Employee\SavedJobs.cshtml"
                                                        Write(x.SavedOn.ToString("dd MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
											<td class=""job-links"">
												<a href=""javascript:void(0);"" data-toggle=""modal"" data-target=""#exampleModalLong"">
												<i class=""fa fa-eye""></i></a>
												<a href=""javascript:void(0);""><i class=""ti-trash""></i></a>
											</td>
										</tr>
");
#nullable restore
#line 60 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Employee\SavedJobs.cshtml"
										}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

									</tbody>
								</table>
								<div class=""pagination-bx float-right"">
									<ul class=""pagination"">
										<li class=""previous""><a href=""javascript:void(0);""><i class=""ti-arrow-left""></i> Prev</a></li>
										<li class=""active""><a href=""javascript:void(0);"">1</a></li>
										<li><a href=""javascript:void(0);"">2</a></li>
										<li><a href=""javascript:void(0);"">3</a></li>
										<li class=""next""><a href=""javascript:void(0);"">Next <i class=""ti-arrow-right""></i></a></li>
									</ul>
								</div>
							</div>
							<!-- Modal -->

							<!-- Modal End -->
						</div>
					</div>
				</div>
			</div>
        </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SavedJobView>> Html { get; private set; }
    }
}
#pragma warning restore 1591