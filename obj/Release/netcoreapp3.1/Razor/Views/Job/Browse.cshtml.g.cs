#pragma checksum "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Job\Browse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fd713628ce21daf2caaf1701292fe6a9dbdf608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Browse), @"mvc.1.0.view", @"/Views/Job/Browse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fd713628ce21daf2caaf1701292fe6a9dbdf608", @"/Views/Job/Browse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f86f1abe93baddbc70bbdb19dcadb6a3a92a2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Browse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dezPlaceAni"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br>
<br>
<br>
<br>
<div class=""page-content bg-white"">
        <!-- inner page banner -->

        <!-- inner page banner END -->
		<!-- Filters Search -->
		<div class=""section-full browse-job-find"">
			<div class=""container"">
				<div class=""find-job-bx"">
					");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf6083966", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t<div class=\"col-lg-6 col-md-6\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label>Job Title, Keywords, or Phrase</label>\r\n\t\t\t\t\t\t\t\t\t<div class=\"input-group\">\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 546, "\"", 560, 0);
                EndWriteAttribute();
                WriteLiteral(@">
										<div class=""input-group-append"">
										  <span class=""input-group-text""><i class=""fa fa-search""></i></span>
										</div>
									</div>
								</div>
							</div>

							<div class=""col-lg-4 col-md-4"">
								<div class=""form-group"">
									<select>
										");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf6085008", async() => {
                    WriteLiteral("Select Sector");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf6086049", async() => {
                    WriteLiteral("Construction");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf6087089", async() => {
                    WriteLiteral("Corodinator");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf6088128", async() => {
                    WriteLiteral("Employer");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf6089164", async() => {
                    WriteLiteral("Financial Career");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60810208", async() => {
                    WriteLiteral("Information Technology");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60811259", async() => {
                    WriteLiteral("Marketing");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60812297", async() => {
                    WriteLiteral("Quality check");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60813339", async() => {
                    WriteLiteral("Real Estate");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60814379", async() => {
                    WriteLiteral("Sales");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60815413", async() => {
                    WriteLiteral("Supporting");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60816452", async() => {
                    WriteLiteral("Teaching");
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
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</select>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-lg-2 col-md-2\">\r\n\t\t\t\t\t\t\t\t<button type=\"submit\" class=\"site-button btn-block\">Find Job</button>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
		<!-- Filters Search END -->
        <!-- contact area -->
        <div class=""content-block"">
			<!-- Browse Jobs -->
			<div class=""section-full browse-job p-b50"">
				<div class=""container"">
					<div class=""row"">
						<div class=""col-xl-3 col-lg-4 col-md-5 m-b30"">
							<aside id=""accordion1"" class=""sticky-top sidebar-filter bg-white"">
								<h6 class=""title""><i class=""fa fa-sliders m-r5""></i> Refined By <a href=""javascript:void(0);"" class=""font-12 float-right"">Reset All</a></h6>
								<div class=""panel"">
									<div class=""acod-head"">
										<h6 class=""acod-title"">
											<a data-toggle=""collapse"" href=""#companies"">
												Companies
											</a>
										</h6>
									</div>
									<div id=""companies"" class=""acod-body collapse"">
										<div class=""acod-content"">
											<div class=""custom-control custom-checkbox"">
												<input class=""custom-control-input"" id=""companies1"" type=""radio"" name=""checkbox-companies"">");
            WriteLiteral(@"
												<label class=""custom-control-label"" for=""companies1"">Job Mirror Consultancy <span>(50)</span> </label>
											</div>
											<div class=""custom-control custom-checkbox"">
												<input class=""custom-control-input"" id=""companies2"" type=""radio"" name=""checkbox-companies"">
												<label class=""custom-control-label"" for=""companies2"">Engineering Group <span>(80)</span> </label>
											</div>
											<div class=""custom-control custom-checkbox"">
												<input class=""custom-control-input"" id=""companies3"" type=""radio"" name=""checkbox-companies"">
												<label class=""custom-control-label"" for=""companies3"">Electric Co. <span>(235)</span> </label>
											</div>
											<div class=""custom-control custom-checkbox"">
												<input class=""custom-control-input"" id=""companies4"" type=""radio"" name=""checkbox-companies"">
												<label class=""custom-control-label"" for=""companies4"">Telecom industry <span>(568)</span></label>
											</div>
											<div ");
            WriteLiteral(@"class=""custom-control custom-checkbox"">
												<input class=""custom-control-input"" id=""companies5"" type=""radio"" name=""checkbox-companies"">
												<label class=""custom-control-label"" for=""companies5"">Safety/ Health <span>(798)</span></label>
											</div>
										</div>
									</div>
								</div>
								<div class=""panel"">
									<div class=""acod-head"">
										<h6 class=""acod-title"">
											<a data-toggle=""collapse"" href=""#experience"" class=""collapsed"">
												Experience
											</a>
										</h6>
									</div>
									<div id=""experience"" class=""acod-body collapse"">
										<div class=""acod-content"">
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""one-years"" type=""radio"" name=""radio-years"">
												<label class=""custom-control-label"" for=""one-years"">0-1 Years <span>(120)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""c");
            WriteLiteral(@"ustom-control-input"" id=""two-years"" type=""radio"" name=""radio-years"">
												<label class=""custom-control-label"" for=""two-years"">1-2 Years <span>(300)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""three-years"" type=""radio"" name=""radio-years"">
												<label class=""custom-control-label"" for=""three-years"">2-3 Years <span>(235)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""four-years"" type=""radio"" name=""radio-years"">
												<label class=""custom-control-label"" for=""four-years"">3-4 Years <span>(568)</span></label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""five-years"" type=""radio"" name=""radio-years"">
												<label class=""custom-control-label"" for=""five-years"">4-5 Years <span>(798)</span></label>
											</div>
							");
            WriteLiteral(@"			</div>
									</div>
								</div>
								<div class=""panel"">
									<div class=""acod-head"">
										<h6 class=""acod-title"">
											<a data-toggle=""collapse""  href=""#salary"" class=""collapsed"" >
												Salary
											</a>
										</h6>
									</div>
									<div id=""salary"" class=""acod-body collapse"">
										<div class=""acod-content"">
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""salary-op1"" type=""radio"" name=""radio-currency"">
												<label class=""custom-control-label"" for=""salary-op1"">0-1 lacs <span>(120)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""salary-op2"" type=""radio"" name=""radio-currency"">
												<label class=""custom-control-label"" for=""salary-op2"">1-2 lacs <span>(300)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-con");
            WriteLiteral(@"trol-input"" id=""salary-op3"" type=""radio"" name=""radio-currency"">
												<label class=""custom-control-label"" for=""salary-op3"">2-3 lacs <span>(235)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""salary-op4"" type=""radio"" name=""radio-currency"">
												<label class=""custom-control-label"" for=""salary-op4"">3-4 lacs <span>(568)</span></label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""salary-op5"" type=""radio"" name=""radio-currency"">
												<label class=""custom-control-label"" for=""salary-op5"">4-5 lacs <span>(798)</span></label>
											</div>
										</div>
									</div>
								</div>
								<div class=""panel"">
									<div class=""acod-head"">
										<h6 class=""acod-title"">
											<a data-toggle=""collapse""  href=""#job-function"" class=""collapsed"" >
												Job Function
											</a>
										</h");
            WriteLiteral(@"6>
									</div>
									<div id=""job-function"" class=""acod-body collapse"">
										<div class=""acod-content"">
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""function-services-1"" type=""radio"" name=""radio-function"">
												<label class=""custom-control-label"" for=""function-services-1"">Production Management <span>(120)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""function-services-2"" type=""radio"" name=""radio-function"">
												<label class=""custom-control-label"" for=""function-services-2"">Design Engineering <span>(300)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""function-services-3"" type=""radio"" name=""radio-function"">
												<label class=""custom-control-label"" for=""function-services-3"">Safety/ Health <span>(235)</span> </label>
									");
            WriteLiteral(@"		</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""function-services-4"" type=""radio"" name=""radio-function"">
												<label class=""custom-control-label"" for=""function-services-4"">Engineering <span>(568)</span></label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""function-services-5"" type=""radio"" name=""radio-function"">
												<label class=""custom-control-label"" for=""function-services-5"">Product Development <span>(798)</span></label>
											</div>
										</div>
									</div>
								</div>
								<div class=""panel"">
									<div class=""acod-head"">
										<h6 class=""acod-title"">
											<a data-toggle=""collapse""  href=""#industry"" class=""collapsed"" >
												Industry
											</a>
										</h6>
									</div>
									<div id=""industry"" class=""acod-body collapse"">
										<div class=""acod-content"">
											<div cla");
            WriteLiteral(@"ss=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""industry1"" type=""radio"" name=""radio-industry"">
												<label class=""custom-control-label"" for=""industry1"">Telecom <span>(5)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""industry2"" type=""radio"" name=""radio-industry"">
												<label class=""custom-control-label"" for=""industry2"">Consulting Services <span>(10)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""industry3"" type=""radio"" name=""radio-industry"">
												<label class=""custom-control-label"" for=""industry3"">Engineering/Projects <span>(15)</span> </label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""industry4"" type=""radio"" name=""radio-industry"">
												<label class=""custom-control-label");
            WriteLiteral(@""" for=""industry4"">Manufacturing/Industrial <span>(12)</span></label>
											</div>
											<div class=""custom-control custom-radio"">
												<input class=""custom-control-input"" id=""industry5"" type=""radio"" name=""radio-industry"">
												<label class=""custom-control-label"" for=""industry5"">Architecture/Interior Design <span>(8)</span></label>
											</div>
										</div>
									</div>
								</div>
							</aside>
						</div>
						<div class=""col-xl-9 col-lg-8 col-md-7"">
							<div class=""job-bx-title clearfix"">
								<h5 class=""font-weight-700 pull-left text-uppercase"">2269 Jobs Found</h5>
								<div class=""float-right"">
									<span class=""select-title"">Sort by freshness</span>
									<select>
										");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60829541", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60830527", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60831511", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd713628ce21daf2caaf1701292fe6a9dbdf60832494", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</select>\r\n\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<ul class=\"post-job-bx browse-job-grid row\">\r\n");
#nullable restore
#line 246 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Job\Browse.cshtml"
                                 for(int i=1; i<=20 ; i++)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<li class=\"col-lg-6 col-md-12\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"post-bx\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"d-flex m-b30\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"job-post-info\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h5><a href=\"job-detail.html\">Digital Marketing Executive ");
#nullable restore
#line 252 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Job\Browse.cshtml"
                                                                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h5>
												<ul>
													<li><i class=""fa fa-map-marker""></i> Sacramento, California</li>
													<li><i class=""fa fa-bookmark-o""></i> Full Time</li>
													<li><i class=""fa fa-clock-o""></i> Published 11 months ago</li>
												</ul>
											</div>
										</div>
										<div class=""d-flex"">
											<div class=""job-time mr-auto"">
												<a href=""javascript:void(0);""><span>Full Time</span></a>
											</div>
											<div class=""salary-bx"">
												<span>$1200 - $ 2500</span>
											</div>
										</div>
										<label class=""like-btn"">
											<input type=""checkbox"">
											<span class=""checkmark""></span>
										</label>
									</div>
								</li>
");
#nullable restore
#line 274 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Job\Browse.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</ul>
							<div class=""pagination-bx float-right m-t30"">
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
            <!-- Browse Jobs END -->
		</div>

    </div>
    <!-- Content END-->
	<!-- Modal Box -->
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
