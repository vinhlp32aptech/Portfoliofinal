#pragma checksum "C:\Users\Win\Source\Repos\Portfoliofinal\PortfolioOnline\Views\Signup\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ba2a999933f722a4730f2dd40fb25dd020acae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Signup_Index), @"mvc.1.0.view", @"/Views/Signup/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ba2a999933f722a4730f2dd40fb25dd020acae3", @"/Views/Signup/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Signup_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "signin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Win\Source\Repos\Portfoliofinal\PortfolioOnline\Views\Signup\Index.cshtml"
  
    ViewData["Title"] = "SignUp";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid px-1 px-md-5 px-lg-1 px-xl-5 py-5 mx-auto"">
    <div class=""card card0 border-0"">
        <div class=""row d-flex"">
            <div class=""col-lg-6"">
                <div class=""card1 pb-5"">

                    <div class=""row px-3 justify-content-center mt-4 mb-5 border-line""> <img");
            BeginWriteAttribute("src", " src=\"", 411, "\"", 417, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""image""> </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""card2 card border-0 px-4 py-5"">
                    <div class=""row mb-4 px-3"">
                        <h6 class=""mb-0 mr-4 mt-2"">Sign in with</h6>
                        <div class=""facebook text-center mr-3"">
                            <div class=""fa fa-facebook""></div>
                        </div>
                        <div class=""twitter text-center mr-3"">
                            <div class=""fa fa-twitter""></div>
                        </div>
                        <div class=""linkedin text-center mr-3"">
                            <div class=""fa fa-linkedin""></div>
                        </div>
                    </div>
                    <div class=""row px-3 mb-4"">
                        <div class=""line""></div> <small class=""or text-center"">Or</small>
                        <div class=""line""></div>
                    </div>
             ");
            WriteLiteral(@"       <div class=""row px-3"">
                        <label class=""mb-1"">
                            <h6 class=""mb-0 text-sm"">Email Address</h6>
                        </label> <input class=""mb-4"" type=""text"" name=""email"" placeholder=""Enter a valid email address"">
                    </div>
                    <div class=""row px-3"">
                        <label class=""mb-1"">
                            <h6 class=""mb-0 text-sm"">Password</h6>
                        </label> <input type=""password"" name=""password"" placeholder=""Enter password"">
                    </div>
                    <br>
                    <div class=""row px-3"">
                        <label class=""mb-1"">
                            <h6 class=""mb-0 text-sm"">Confirm Password</h6>
                        </label> <input class=""mb-4"" type=""text"" name=""email"" placeholder=""Enter Confirm Password"">
                    </div>
                    <br>
                    <div class=""row mb-3 px-3""> <button type=""submit"" cl");
            WriteLiteral("ass=\"btn btn-blue text-center\">SignUp</button> </div>\r\n                    <div class=\"row mb-4 px-3\"> <small class=\"font-weight-bold\">Do you already have an account ? ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ba2a999933f722a4730f2dd40fb25dd020acae36771", async() => {
                WriteLiteral("SignIn Now!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</small> </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
