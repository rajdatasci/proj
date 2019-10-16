#pragma checksum "C:\Users\fundu\connectevents\Views\Auth\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b6f289fa61aa74ae80ce6ab85a8a6f10272f5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_login), @"mvc.1.0.view", @"/Views/Auth/login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/login.cshtml", typeof(AspNetCore.Views_Auth_login))]
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
#line 1 "C:\Users\fundu\connectevents\Views\_ViewImports.cshtml"
using connectevents;

#line default
#line hidden
#line 2 "C:\Users\fundu\connectevents\Views\_ViewImports.cshtml"
using connectevents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b6f289fa61aa74ae80ce6ab85a8a6f10272f5a", @"/Views/Auth/login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86240f3a514e2821f0b3f268eb50f984e2dbf919", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/auth/login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\fundu\connectevents\Views\Auth\login.cshtml"
  
  var error = (bool)ViewData["error"];
  var loginSuccessfull = (bool)ViewData["loginSuccessfull"];
  var userNotFound = (bool)ViewData["userNotFound"];

#line default
#line hidden
            BeginContext(163, 25, true);
            WriteLiteral("\r\n<h2>Login Page</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\fundu\connectevents\Views\Auth\login.cshtml"
 if(error)
{

#line default
#line hidden
            BeginContext(203, 85, true);
            WriteLiteral("  <div class=\"alert alert-error\" role=\"alert\">\r\n    Something went wrong!\r\n  </div>\r\n");
            EndContext();
#line 14 "C:\Users\fundu\connectevents\Views\Auth\login.cshtml"
}

#line default
#line hidden
            BeginContext(291, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\fundu\connectevents\Views\Auth\login.cshtml"
 if(loginSuccessfull)
{

#line default
#line hidden
            BeginContext(319, 74, true);
            WriteLiteral("  <div class=\"alert alert-error\" role=\"alert\">\r\n    Logged in!\r\n  </div>\r\n");
            EndContext();
#line 21 "C:\Users\fundu\connectevents\Views\Auth\login.cshtml"
}

#line default
#line hidden
            BeginContext(396, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\fundu\connectevents\Views\Auth\login.cshtml"
 if(userNotFound)
{

#line default
#line hidden
            BeginContext(420, 129, true);
            WriteLiteral("  <div class=\"alert alert-error\" role=\"alert\">\r\n    User not found. Please <a href=\"/auth/register\">register</a> here\r\n  </div>\r\n");
            EndContext();
#line 28 "C:\Users\fundu\connectevents\Views\Auth\login.cshtml"
}

#line default
#line hidden
            BeginContext(552, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(556, 377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2b6f289fa61aa74ae80ce6ab85a8a6f10272f5a5761", async() => {
                BeginContext(597, 329, true);
                WriteLiteral(@"
  <div class=""form-group"">
    <input type=""email"" class=""form-control"" name=""email"" placeholder=""Email"" required>
  </div>
  <div class=""form-group"">
    <input type=""password"" class=""form-control"" name=""password"" placeholder=""Password"" required>
  </div>
  <button type=""submit"" class=""btn btn-primary"">Login</button>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591