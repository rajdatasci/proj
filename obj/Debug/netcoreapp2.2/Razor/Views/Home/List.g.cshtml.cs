#pragma checksum "C:\Users\fundu\connectevents\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11beedb3642e634c037ee12d82c7235290b6119f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11beedb3642e634c037ee12d82c7235290b6119f", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86240f3a514e2821f0b3f268eb50f984e2dbf919", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\fundu\connectevents\Views\Home\List.cshtml"
  
    Event Event= (Event)ViewBag.Event;

#line default
#line hidden
            BeginContext(47, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(54, 10, false);
#line 5 "C:\Users\fundu\connectevents\Views\Home\List.cshtml"
Write(Event.Name);

#line default
#line hidden
            EndContext();
            BeginContext(64, 19, true);
            WriteLiteral("</h2>\r\n<p>DETAILS: ");
            EndContext();
            BeginContext(84, 13, false);
#line 6 "C:\Users\fundu\connectevents\Views\Home\List.cshtml"
       Write(Event.Details);

#line default
#line hidden
            EndContext();
            BeginContext(97, 10, true);
            WriteLiteral("</p>\r\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 107, "\"", 130, 1);
#line 7 "C:\Users\fundu\connectevents\Views\Home\List.cshtml"
WriteAttributeValue("", 113, Event.PictureUrl, 113, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(131, 662, true);
            WriteLiteral(@" alt=""Event Image"" width=""450"">

<div class=""chat_window""><div class=""top_menu""><div class=""buttons""><div class=""button close""></div><div class=""button minimize""></div><div class=""button maximize""></div></div><div class=""title"">Chat</div></div><ul class=""messages""></ul><div class=""bottom_wrapper clearfix""><div class=""message_input_wrapper""><input class=""message_input"" placeholder=""Type your message here..."" /></div><div class=""send_message""><div class=""icon""></div><div class=""text"">Send</div></div></div></div><div class=""message_template""><li class=""message""><div class=""avatar""></div><div class=""text_wrapper""><div class=""text""></div></div></li></div>
");
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
