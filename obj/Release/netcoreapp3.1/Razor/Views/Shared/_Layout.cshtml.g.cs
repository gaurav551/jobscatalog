#pragma checksum "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1bef0f21f9c349a4136a0cbb90072c3e9d36501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bef0f21f9c349a4136a0cbb90072c3e9d36501", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f86f1abe93baddbc70bbdb19dcadb6a3a92a2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dzSubscribe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://job-board.dexignzone.com/xhtml/script/mailchamp.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!DOCTYPE html>
<html lang=""en"">

<!-- Mirrored from job-board.dexignzone.com/xhtml/index.html by HTTrack Website Copier/3.x [XR&CO'2014], Mon, 04 May 2020 06:08:08 GMT -->
<!-- Added by HTTrack -->
<meta http-equiv=""content-type"" content=""text/html;charset=UTF-8"" /><!-- /Added by HTTrack -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bef0f21f9c349a4136a0cbb90072c3e9d365018236", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 420, "\"", 430, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 459, "\"", 469, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"robots\"");
                BeginWriteAttribute("content", " content=\"", 498, "\"", 508, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <meta name=""description"" content=""JobBoard - HTML Template"" />
    <meta property=""og:title"" content=""JobBoard - HTML Template"" />
    <meta property=""og:description"" content=""JobBoard - HTML Template"" />
    <meta property=""og:image"" content=""social-image.png"" />
    <meta name=""format-detection"" content=""telephone=no"">

    <!-- FAVICONS ICON -->
    <link rel=""icon"" href=""/assets/images/favicon.ico"" type=""image/x-icon"" />
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""/assets/images/favicon.png"" />

    <!-- PAGE TITLE HERE -->
    <title>JobBoard - HTML Template</title>

    <!-- MOBILE SPECIFIC -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!--[if lt IE 9]>
    <script src=""https://job-board.dexignzone.com/xhtml/js/html5shiv.min.js""></script>
    <script src=""https://job-board.dexignzone.com/xhtml/js/respond.min.js""></script>
    <![endif]-->
    <!-- STYLESHEETS -->
    <link rel=""stylesheet"" type=""text/css"" href=""/assets/css/plu");
                WriteLiteral(@"gins.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/assets/css/style.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/assets/css/templete.css"">
    <link class=""skin"" rel=""stylesheet"" type=""text/css"" href=""/assets/css/skin/skin-1.css"">

");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bef0f21f9c349a4136a0cbb90072c3e9d3650111243", async() => {
                WriteLiteral(@"
    <div id=""loading-area""></div>
    <div class=""page-wraper"">
        <!-- header -->
        <header class=""site-header mo-left header fullwidth"">
            <!-- main header -->
            <div class=""sticky-header main-bar-wraper navbar-expand-lg"">
                <div class=""main-bar clearfix"">
                    <div class=""container clearfix"">
                        <!-- website logo -->
                        <div class=""logo-header mostion"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bef0f21f9c349a4136a0cbb90072c3e9d3650112014", async() => {
                    WriteLiteral("<img src=\"/assets/images/kk.jpg\" class=\"logo\"");
                    BeginWriteAttribute("alt", " alt=\"", 2404, "\"", 2410, 0);
                    EndWriteAttribute();
                    WriteLiteral(">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <!-- nav toggle button -->
                        <!-- nav toggle button -->
                        <button class=""navbar-toggler collapsed navicon justify-content-end"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavDropdown"" aria-controls=""navbarNavDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                            <span></span>
                            <span></span>
                            <span></span>
                        </button>
                        <!-- extra nav -->
                        <div class=""extra-nav"">
                            <div class=""extra-cell"">

                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c1bef0f21f9c349a4136a0cbb90072c3e9d3650114404", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                        <!-- main nav -->
                        <div class=""header-nav navbar-collapse collapse justify-content-start"" id=""navbarNavDropdown"">
                            <ul class=""nav navbar-nav"">
                                <li");
                BeginWriteAttribute("class", " class=\"", 3515, "\"", 3523, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <a href=""#"">Home <i class=""fa fa-chevron-down""></i></a>
                                    <ul class=""sub-menu"">
                                        <li><a href=""index.html"" class=""dez-page"">Home 1</a></li>
                                        <li><a href=""index-2.html"" class=""dez-page"">Home 2</a></li>
                                    </ul>
                                </li>
                                <li");
                BeginWriteAttribute("class", " class=\"", 3996, "\"", 4004, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bef0f21f9c349a4136a0cbb90072c3e9d3650116745", async() => {
                    WriteLiteral("Employee<i class=\"fa fa-user\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <!-- main header END -->
        </header>
        <div class=""page-content"">
            ");
#nullable restore
#line 89 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
        <!--Modal -->
        <div class=""modal fade modal-bx-info"" id=""loginmodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""loginmodalTitle"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">

                        <h5 class=""modal-title"">Login</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bef0f21f9c349a4136a0cbb90072c3e9d3650119247", async() => {
                    WriteLiteral(@"
                            <h3 class=""m-t0"">Personal Details</h3>
                            <div class=""form-group"">
                                <input name=""email"" class=""form-control"" type=""email"" class=""form-control "" data-val=""true"" data-val-email=""The Email field is not a valid e-mail address."" data-val-required=""The Email field is required."" placeholder=""Email"" />
                                <span class=""text-danger field-validation-valid"" data-valmsg-for=""email"" data-valmsg-replace=""true""></span>
                            </div>
                            <div class=""form-group"">
                                <input class=""form-control "" placeholder=""Type Password"" type=""password"" data-val=""true"" data-val-required=""The Password field is required."" name=""password"">
                                <span class=""text-danger field-validation-valid"" data-valmsg-for=""password"" data-valmsg-replace=""true""></span>
                                <input type=""hidden"" name=""returnUrl"">
 ");
                    WriteLiteral(@"                           </div>
                            <div class=""custom-control custom-checkbox"">
                                <input type=""checkbox"" class=""custom-control-input"" id=""permanent2"" name=""RememberMe"">
                                <label class=""custom-control-label"" for=""permanent2"">Remember Me</label>
                            </div>
                            <br>
                            <div class=""clearfix"">
                                <button type=""submit"" class=""btn-primary site-button btn-block"">Submit </button>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <!--/Modal -->
        <footer class=""site-footer"">
            <div class=""footer-top"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-xl-5 col-lg-4 col-md-12 col-sm-12"">
                            <div class=""widget"">
                                <img src=""/assets/images/logo-white.png"" width=""180"" class=""m-b15""");
                BeginWriteAttribute("alt", " alt=\"", 7504, "\"", 7510, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                <p class=""text-capitalize m-b20"">Lorem Ipsum is simply dummy text of the printing and typesetting industry has been the industry's standard dummy text ever since the.</p>
                                <div class=""subscribe-form m-b20"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bef0f21f9c349a4136a0cbb90072c3e9d3650123896", async() => {
                    WriteLiteral(@"
                                        <div class=""dzSubscribeMsg""></div>
                                        <div class=""input-group"">
                                            <input name=""dzEmail"" required=""required"" class=""form-control"" placeholder=""Your Email Address"" type=""email"">
                                            <span class=""input-group-btn"">
                                                <button name=""submit"" value=""Submit"" type=""submit"" class=""site-button radius-xl"">Subscribe</button>
                                            </span>
                                        </div>
                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                                <ul class=""list-inline m-a0"">
                                    <li><a href=""javascript:void(0);"" class=""site-button white facebook circle ""><i class=""fa fa-facebook""></i></a></li>
                                    <li><a href=""javascript:void(0);"" class=""site-button white google-plus circle ""><i class=""fa fa-google-plus""></i></a></li>
                                    <li><a href=""javascript:void(0);"" class=""site-button white linkedin circle ""><i class=""fa fa-linkedin""></i></a></li>
                                    <li><a href=""javascript:void(0);"" class=""site-button white instagram circle ""><i class=""fa fa-instagram""></i></a></li>
                                    <li><a href=""javascript:void(0);"" class=""site-button white twitter circle ""><i class=""fa fa-twitter""></i></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""");
                WriteLiteral(@"col-xl-5 col-lg-5 col-md-8 col-sm-8 col-12"">
                            <div class=""widget border-0"">
                                <h5 class=""m-b30 text-white"">Frequently Asked Questions</h5>
                                <ul class=""list-2 list-line"">

                                    <li><a href=""javascript:void(0);"">For Employers</a></li>
                                    <li><a href=""javascript:void(0);"">Underwriting</a></li>
                                    <li><a href=""javascript:void(0);"">Contact Us</a></li>
                                    <li><a href=""javascript:void(0);"">Lending Licnses</a></li>
                                    <li><a href=""javascript:void(0);"">Support</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-xl-2 col-lg-3 col-md-4 col-sm-4 col-12"">
                            <div class=""widget border-0"">
                                <h5 class=""m-b30 t");
                WriteLiteral(@"ext-white"">Find Jobs</h5>
                                <ul class=""list-2 w10 list-line"">
                                    <li><a href=""javascript:void(0);"">US Jobs</a></li>
                                    <li><a href=""javascript:void(0);"">Canada Jobs</a></li>
                                    <li><a href=""javascript:void(0);"">UK Jobs</a></li>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- footer bottom part -->
            <div class=""footer-bottom"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-12 text-center"">
                            <span>
                                © Copyright 2020  by <i class=""fa fa-heart m-lr5 text-red heart""></i>
                                <a href=""javascript:void(0);"">Ganny Soft </a> All rights reserved.
                            </span>
                     ");
                WriteLiteral(@"   </div>
                    </div>
                </div>
            </div>
        </footer>
        <!-- Footer END -->
        <!-- scroll top button -->
        <button class=""scroltop fa fa-arrow-up""></button>
    </div>
    <!-- JAVASCRIPT FILES ========================================= -->
    <script src=""/assets/js/jquery.min.js""></script><!-- JQUERY.MIN JS -->
    <script src=""/assets/plugins/bootstrap/js/popper.min.js""></script><!-- BOOTSTRAP.MIN JS -->
    <script src=""/assets/plugins/bootstrap/js/bootstrap.min.js""></script><!-- BOOTSTRAP.MIN JS -->
    <script src=""/assets/plugins/bootstrap-select/bootstrap-select.min.js""></script><!-- FORM JS -->
    <script src=""/assets/plugins/bootstrap-touchspin/jquery.bootstrap-touchspin.js""></script><!-- FORM JS -->
    <script src=""/assets/plugins/magnific-popup/magnific-popup.js""></script><!-- MAGNIFIC POPUP JS -->
    <script src=""/assets/plugins/counter/waypoints-min.js""></script><!-- WAYPOINTS JS -->
    <script src=""/assets/plugins");
                WriteLiteral(@"/counter/counterup.min.js""></script><!-- COUNTERUP JS -->
    <script src=""/assets/plugins/imagesloaded/imagesloaded.js""></script><!-- IMAGESLOADED -->
    <script src=""/assets/plugins/masonry/masonry-3.1.4.js""></script><!-- MASONRY -->
    <script src=""/assets/plugins/masonry/masonry.filter.js""></script><!-- MASONRY -->
    <script src=""/assets/plugins/owl-carousel/owl.carousel.js""></script><!-- OWL SLIDER -->
    <script src=""/assets/plugins/tagcomplete/tagcomplete.js""></script><!-- TAGCOMPLETE -->
    <script src=""/assets/js/custom.js""></script><!-- CUSTOM FUCTIONS  -->
    <script src=""/assets/js/dz.carousel.js""></script><!-- SORTCODE FUCTIONS  -->
    <script src=""/assets/js/dz.ajax.js""></script><!-- CONTACT JS  -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bef0f21f9c349a4136a0cbb90072c3e9d3650131348", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bef0f21f9c349a4136a0cbb90072c3e9d3650132448", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 222 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Mirrored from job-board.dexignzone.com/xhtml/index.html by HTTrack Website Copier/3.x [XR&CO\'2014], Mon, 04 May 2020 06:08:36 GMT -->\r\n</html>\r\n");
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
