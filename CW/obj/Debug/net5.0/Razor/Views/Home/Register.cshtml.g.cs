#pragma checksum "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f7a15d0e9230d50e164f29181a6dde2f9929613"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
#nullable restore
#line 1 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\_ViewImports.cshtml"
using CW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\_ViewImports.cshtml"
using CW.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Register.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Register.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Register.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f7a15d0e9230d50e164f29181a6dde2f9929613", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e6986b9d96fa5abe9ef2e4f38ed754137f42a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "Registered Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Register.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Register.cshtml"
  
    var name = HttpContextAccessor.HttpContext.Session.GetString("MemberName");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid  text-center create-cause-banner-container\">\r\n    <div class=\"row title-row\">\r\n        <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n            <div> <h2> <b>Welcome, ");
#nullable restore
#line 20 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Register.cshtml"
                              Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</b></h2></div>\r\n            <div>\r\n                <p>\r\n                    <b>\r\n                        Register page is yet to be done.\r\n\r\n                    </b>\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
