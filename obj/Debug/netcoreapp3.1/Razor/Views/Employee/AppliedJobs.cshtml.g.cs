#pragma checksum "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Employee\AppliedJobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7c23fb8eff509f538c62f957b1650ebcd268954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_AppliedJobs), @"mvc.1.0.view", @"/Views/Employee/AppliedJobs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c23fb8eff509f538c62f957b1650ebcd268954", @"/Views/Employee/AppliedJobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f86f1abe93baddbc70bbdb19dcadb6a3a92a2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_AppliedJobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7c23fb8eff509f538c62f957b1650ebcd2689543923", async() => {
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
							<div class=""job-bx-title clearfix"">
								<h5 class=""font-weight-700 pull-left text-uppercase"">2269 Jobs Found</h5>
								<div class=""float-right"">
									<span class=""select-title"">Sort by freshness</span>
									<select>
										");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7c23fb8eff509f538c62f957b1650ebcd2689545387", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7c23fb8eff509f538c62f957b1650ebcd2689546372", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7c23fb8eff509f538c62f957b1650ebcd2689547355", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7c23fb8eff509f538c62f957b1650ebcd2689548337", async() => {
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
            WriteLiteral(@"
									</select>
								</div>
							</div>
							<ul class=""post-job-bx browse-job"">
								<li>
									<div class=""post-bx"">
										<div class=""job-post-info m-a0"">
											<h4><a href=""job-detail.html"">PHP Web Developer</a></h4>
											<ul>
												<li><a href=""company-profile.html"">company-name</a></li>
												<li><i class=""fa fa-map-marker""></i> Sacramento, California</li>
												<li><i class=""fa fa-money""></i> 25,000</li>
											</ul>
											<div class=""job-time m-t15 m-b10"">
												<a href=""javascript:void(0);""><span>PHP</span></a>
												<a href=""javascript:void(0);""><span>Angular</span></a>
												<a href=""javascript:void(0);""><span>Bootstrap</span></a>
												<a href=""javascript:void(0);""><span>Wordpress</span></a>
											</div>
											<div class=""posted-info clearfix"">
												<p class=""m-tb0 text-primary float-left""><span class=""text-black m-r10"">Posted:</span> 2 day ago</p>
												<a href=""jobs-my-");
            WriteLiteral(@"resume.html"" class=""site-button button-sm float-right"">Apply Job</a>
											</div>
										</div>
									</div>
								</li>
								<li>
									<div class=""post-bx"">
										<div class=""job-post-info m-a0"">
											<h4><a href=""job-detail.html"">Software Developer</a></h4>
											<ul>
												<li><a href=""company-profile.html"">company-name</a></li>
												<li><i class=""fa fa-map-marker""></i> Sacramento, California</li>
												<li><i class=""fa fa-money""></i> 25,000</li>
											</ul>
											<div class=""job-time m-t15 m-b10"">
												<a href=""javascript:void(0);""><span>PHP</span></a>
												<a href=""javascript:void(0);""><span>Angular</span></a>
												<a href=""javascript:void(0);""><span>Bootstrap</span></a>
												<a href=""javascript:void(0);""><span>Wordpress</span></a>
											</div>
											<div class=""posted-info clearfix"">
												<p class=""m-tb0 text-primary float-left""><span class=""text-black m-r10"">Posted:</span> 2");
            WriteLiteral(@" day ago</p>
												<a href=""jobs-my-resume.html"" class=""site-button button-sm float-right"">Apply Job</a>
											</div>
										</div>
									</div>
								</li>
								<li>
									<div class=""post-bx"">
										<div class=""job-post-info m-a0"">
											<h4><a href=""job-detail.html"">Branch Credit Manager</a></h4>
											<ul>
												<li><a href=""company-profile.html"">company-name</a></li>
												<li><i class=""fa fa-map-marker""></i> Sacramento, California</li>
												<li><i class=""fa fa-money""></i> 25,000</li>
											</ul>
											<div class=""job-time m-t15 m-b10"">
												<a href=""javascript:void(0);""><span>PHP</span></a>
												<a href=""javascript:void(0);""><span>Angular</span></a>
												<a href=""javascript:void(0);""><span>Bootstrap</span></a>
												<a href=""javascript:void(0);""><span>Wordpress</span></a>
											</div>
											<div class=""posted-info clearfix"">
												<p class=""m-tb0 text-primary float-left""><");
            WriteLiteral(@"span class=""text-black m-r10"">Posted:</span> 2 day ago</p>
												<a href=""jobs-my-resume.html"" class=""site-button button-sm float-right"">Apply Job</a>
											</div>
										</div>
									</div>
								</li>
							</ul>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591