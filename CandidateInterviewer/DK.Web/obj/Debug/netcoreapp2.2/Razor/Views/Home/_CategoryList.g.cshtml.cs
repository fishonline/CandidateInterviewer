#pragma checksum "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ace4953a8072dfc01d5fcdb4ed078302225e6fe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__CategoryList), @"mvc.1.0.view", @"/Views/Home/_CategoryList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_CategoryList.cshtml", typeof(AspNetCore.Views_Home__CategoryList))]
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
#line 1 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\_ViewImports.cshtml"
using DK.Web;

#line default
#line hidden
#line 2 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\_ViewImports.cshtml"
using DK.Web.ViewModels;

#line default
#line hidden
#line 3 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
using DK.BusinessLogic.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ace4953a8072dfc01d5fcdb4ed078302225e6fe8", @"/Views/Home/_CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c0b10d1ca970eda3aaac8e60075617da4643ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("platform__img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("connection__link connection__link--arrow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Interview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
 if (Model?.Any() == true)
{

#line default
#line hidden
            BeginContext(101, 98, true);
            WriteLiteral("    <section class=\"examples\">\r\n        <div class=\"container\">\r\n            <h2 class=\"title-h2\">");
            EndContext();
            BeginContext(200, 48, false);
#line 9 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
                            Write(Model.FirstOrDefault().Type.GetEnumDisplayName());

#line default
#line hidden
            EndContext();
            BeginContext(248, 50, true);
            WriteLiteral("</h2>\r\n            <h3 class=\"title-h3\">Tests for ");
            EndContext();
            BeginContext(299, 58, false);
#line 10 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
                                      Write(Model.FirstOrDefault().Type.GetEnumDisplayName().ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(357, 294, true);
            WriteLiteral(@" specialists.</h3>
            <div class=""examples__outer"">
                <div class=""slider"">
                    <div class=""slider__outer owl-carousel owl-loaded owl-drag"">
                        <div class=""owl-stage-outer"">
                            <div class=""static-stage"">
");
            EndContext();
#line 16 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
                                 for (int i = 0; i < Model.Count(); i++)
                                {

#line default
#line hidden
            BeginContext(760, 528, true);
            WriteLiteral(@"                                    <div class=""owl-item"">
                                        <div class=""slider__itm"">
                                            <div class=""connection connection--slider"">
                                                <div class=""connection__outer"">
                                                    <div class=""connection__top"">
                                                        <div class=""connection__wrap"">
                                                            ");
            EndContext();
            BeginContext(1288, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ace4953a8072dfc01d5fcdb4ed078302225e6fe87919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1320, "~/images/", 1320, 9, true);
#line 24 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
AddHtmlAttributeValue("", 1329, Model[i].Logo, 1329, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1347, 244, true);
            WriteLiteral("\r\n                                                        </div>\r\n                                                        <div class=\"connection__desc\">\r\n                                                            <span class=\"connection__ttl\">");
            EndContext();
            BeginContext(1592, 13, false);
#line 27 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
                                                                                     Write(Model[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(1605, 97, true);
            WriteLiteral("</span>\r\n                                                            <p class=\"connection__text\">");
            EndContext();
            BeginContext(1703, 20, false);
#line 28 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
                                                                                   Write(Model[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(1723, 272, true);
            WriteLiteral(@"</p>
                                                        </div>
                                                    </div>
                                                    <div class=""connection__bottom"">
                                                        ");
            EndContext();
            BeginContext(1995, 319, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ace4953a8072dfc01d5fcdb4ed078302225e6fe811132", async() => {
                BeginContext(2133, 177, true);
                WriteLiteral("\r\n                                                            START THE TEST<span class=\"connection__link-icon\"></span>\r\n                                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
                                                                                                                                                                        WriteLiteral(Model[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2314, 262, true);
            WriteLiteral(@"
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
");
            EndContext();
#line 40 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
                                }

#line default
#line hidden
            BeginContext(2611, 1047, true);
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""owl-nav disabled"">
                            <button type=""button"" role=""presentation"" class=""owl-prev"">
                                <span aria-label=""Previous"">‹</span>
                            </button>
                            <button type=""button"" role=""presentation"" class=""owl-next"">
                                <span aria-label=""Next"">›</span>
                            </button>
                        </div>
                        <div class=""owl-dots"">
                            <button role=""button"" class=""owl-dot active"">
                                <span></span>
                            </button>
                            <button role=""button"" class=""owl-dot"">
                                <span></span>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        <");
            WriteLiteral("/div>\r\n    </section>\r\n");
            EndContext();
#line 64 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\_CategoryList.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
