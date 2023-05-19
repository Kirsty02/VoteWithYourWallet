#pragma checksum "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f5629db3823aa539b343e40539baa82b84d5be8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f5629db3823aa539b343e40539baa82b84d5be8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e6986b9d96fa5abe9ef2e4f38ed754137f42a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CW.Data.Cause>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cause", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete this cause?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
  
    var topCauses = Model.OrderByDescending(c => c.Signatures?.Count ?? 0).Take(6).ToList();


#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
  
    var memberRole = HttpContextAccessor.HttpContext.Session.GetString("MemberRole");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- HEADER BANNER HERE -->
<div class=""container-fluid  text-center first-container"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div> <h1> <b>Vote with Your Wallet</b></h1></div>
        </div>
        <div class=""col-xs-12 "">
            <div> <h2> Make a difference</h2></div>
        </div>
        <div class=""col-xs-12 "">
            <div> <a href=""#second-container""> <button class=""btn btn-success btn-lg""> Learn More</button> </a> </div>
        </div>
    </div>
</div>





<!-- IMAGE BUBBLE INFO HERE -->
<div id=""second-container"" class=""container second-container text-center"">
    <div class=""row align-items-center"">
        <div class=""col-xs-8 align-self-center"">
            <div class=""center-block"">
                <h1> Change starts with you...</h1>
                <p>
                    Vote by your wallet is a website which makes it easy for anyone to search for causes
                    that are close to their heart. Created by people ");
            WriteLiteral(@"for people, this site is suppoting people to reach
                    out and share what they think needs to change!
                </p>
            </div>
        </div>
        <div class=""col-xs-4 align-self-center"">
            <div class=""center-block""> <img class=""img-circle img-responsive""");
            BeginWriteAttribute("src", " src=\"", 1733, "\"", 1774, 1);
#nullable restore
#line 55 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
WriteAttributeValue("", 1739, Url.Content("~/images/people.jpg"), 1739, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" /></div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-12""> &nbsp;&nbsp;&nbsp;&nbsp;</div>
    </div>
    <div class=""row align-items-center"">
        <div class=""col-xs-4 align-self-center"">
            <div class=""center-block""> <img class=""img-circle img-responsive""");
            BeginWriteAttribute("src", " src=\"", 2082, "\"", 2123, 1);
#nullable restore
#line 63 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
WriteAttributeValue("", 2088, Url.Content("~/images/prayer.jpg"), 2088, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" /></div>
        </div>
        <div class=""col-xs-8 align-self-center"">
            <div class=""center-block"">
                <h1> Sign your name under a cause...</h1>
                <p>
                    Become a memeber and sign your name under a cause to predge not to do buisness, or otheriwse
                    deal with the misbehaving enitity highlighed in the cause.
                </p>
                <button class=""btn btn-success btn-lg"" onclick=""location.href='/Home/Account'""> Become a Member</button>
            </div>
        </div>
    </div>
</div>



<!-- POPULAR CAUSES HERE -->
<div class=""container-fluid third-container text-center"">
    <div class=""row align-items-center"">
        <div class=""col-xs-12 align-self-center"">
            <div class=""center-block""> <h1> Popular Causes</h1></div>
        </div>
    </div>
    <div class=""container cause-container"">

        <div id=""popularCausesCarousel"" class=""carousel slide"" data-ride=""carousel"">
            <");
            WriteLiteral("!-- Indicators -->\r\n            <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 92 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                 for (int i = 0; i < topCauses.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li data-target=\"#popularCausesCarousel\" data-slide-to=\"");
#nullable restore
#line 94 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 3372, "\"", 3405, 1);
#nullable restore
#line 94 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
WriteAttributeValue("", 3380, i == 0 ? "active" : "", 3380, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 95 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ol>\r\n\r\n            <!-- Wrapper for slides -->\r\n            <div class=\"carousel-inner\" role=\"listbox\">\r\n");
#nullable restore
#line 100 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                 for (int i = 0; i < topCauses.Count; i++)
                {
                    var cause = topCauses[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 3702, "\"", 3740, 2);
            WriteAttributeValue("", 3710, "item", 3710, 4, true);
#nullable restore
#line 103 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3714, i == 0 ? "active" : "", 3715, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""cause-card"">
                            <div class=""row cause-card"">
                                <div class=""col-xs-3 "">
                                    <div class="" img-responsive "">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 4021, "\"", 4115, 2);
            WriteAttributeValue("", 4027, "data:image;base64,", 4027, 18, true);
#nullable restore
#line 108 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
WriteAttributeValue("", 4045, cause.Image?.Length > 0 ? Convert.ToBase64String(@cause.Image) : "", 4045, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n\r\n                                </div>\r\n                                <div class=\"col-xs-4 text-justify slider\">\r\n                                    <h3 >");
#nullable restore
#line 113 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                    Write(cause.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <div class=\"card-info\">\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 116 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                       Write(cause.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 117 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                             if (HttpContextAccessor.HttpContext.Session.GetString("MemberName") != null && memberRole == "Admin")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f5629db3823aa539b343e40539baa82b84d5be813698", async() => {
                WriteLiteral("\r\n                                                    <input type=\"hidden\" name=\"CauseId\"");
                BeginWriteAttribute("value", " value=\"", 4980, "\"", 5002, 1);
#nullable restore
#line 120 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
WriteAttributeValue("", 4988, cause.CauseId, 4988, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                    <button type=\"submit\" class=\"btn btn-danger btn-block\">Delete</button>\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 123 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </p>

                                    </div>
                                </div>
                                <div class=""col-xs-2 slider"">
                                    <h3 > Signed by:</h3>
                                    <div class=""people_box"">
                                        <div class=""signatures-wrapper"">
                                            <div class=""signatures-list unique-signatures-class"">
");
#nullable restore
#line 133 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                                 if (cause.Signatures != null)
                                                {
                                                    foreach (var signature in cause.Signatures)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p>");
#nullable restore
#line 137 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                                      Write(signature);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 138 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n\r\n                                    </div>\r\n");
#nullable restore
#line 144 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                     if (HttpContextAccessor.HttpContext.Session.GetString("MemberName") != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button class=\"btn btn-success btn-block sign-button\" data-causeid=\"");
#nullable restore
#line 146 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                                                                                       Write(cause.CauseId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Sign</button>\r\n");
#nullable restore
#line 147 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button class=\"btn btn-success btn-block \" onclick=\"location.href=\'/Home/Account\'\"> Sign</button>\r\n");
#nullable restore
#line 151 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                                <div class=""col-xs-3 "">
                                    <div class=""row"">
                                        <div class=""col-xs-12"">
                                            <ul class=""list-group list-group-flush"">
                                                <li class=""list-group-item signature-count""> Signatures: <strong>");
#nullable restore
#line 160 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                                                                                             Write(cause.Signatures?.Count ?? 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> of 50</li>\r\n                                                <li class=\"list-group-item card-stats\"> Category: <strong> ");
#nullable restore
#line 161 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                                                                                                      Write(cause.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></li>
                                                <li class=""list-group-item"">  Created: <strong> 22/12/22</strong></li>
                                                <li class=""list-group-item"">
                                                    <p");
            BeginWriteAttribute("class", " class=\"", 7792, "\"", 7800, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <!-- AddToAny BEGIN -->
                                                        <div class=""a2a_kit a2a_kit_size_32 a2a_default_style"">

                                                            <a class=""a2a_button_facebook""></a>
                                                            <a class=""a2a_button_twitter""></a>
                                                            <a class=""a2a_button_linkedin""></a>
                                                            <a class=""a2a_button_whatsapp""></a>
                                                        </div>
                                                        <!-- AddToAny END -->
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                     ");
            WriteLiteral("   </div>\r\n                    </div>\r\n");
#nullable restore
#line 182 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <!-- Controls -->
            <a class=""left carousel-control"" href=""#popularCausesCarousel"" role=""button"" data-slide=""prev"">
                <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""right carousel-control"" href=""#popularCausesCarousel"" role=""button"" data-slide=""next"">
                <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>

    </div>

    
    <!-- BOTTOM BUTTONS HERE -->
    <div class=""row bottom-buttons"">
        <div class=""col-xs-2 col-xs-offset-4 "">
            <button class=""btn btn-success btn-lg btn-block"" onclick=""location.href='/Home/Causes'"">
                View all causes
            </button>
        </div>
        <div class=""col-xs-2"">
");
#nullable restore
#line 207 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
             if (HttpContextAccessor.HttpContext.Session.GetString("MemberName") != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-success btn-lg btn-block\" onclick=\"location.href=\'/Home/CreateCause\'\">\r\n                    <span class=\"glyphicon glyphicon-plus active\"></span>\r\n                    Create a Cause\r\n                </button>\r\n");
#nullable restore
#line 213 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-success btn-lg btn-block\" onclick=\"location.href=\'/Home/Account\'\">\r\n                    <span class=\"glyphicon glyphicon-plus active\"></span>\r\n                    Create a Cause\r\n                </button>\r\n");
#nullable restore
#line 220 "C:\Users\kirst\Documents\MSC\programming_for_the_web\CW\CW\Views\Home\Index.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"           
        </div>
    </div>
</div>



<script>
    // Execute the function when the document is ready
    $(document).ready(function () {
        // Log a message to the console to confirm that jQuery is working
        console.log(""jQuery is working!"");

        // Attach a click event listener to the sign-button elements within the body
        $('body').on('click', '.sign-button', function () {
            // Store the current button object in a variable
            var currentButton = $(this);

            // Retrieve the causeId from the button's data attribute
            var causeId = currentButton.data('causeid');

            // Prompt the user to enter their name as a signature
            var signature = prompt(""Please enter your name"");

            // Check if the user entered a signature
            if (signature) {
                // Make an AJAX request to the /Cause/Sign endpoint with the causeId and signature data
                $.ajax({
               ");
            WriteLiteral(@"     type: 'POST',
                    url: '/Cause/Sign',
                    data: { causeId: causeId, signature: signature },
                    success: function (data) {
                        // If the AJAX request was successful, update the signatures list and count
                        if (data.success) {
                            // Find the signatures list within the closest cause-card element and append the new signature
                            var signaturesList = currentButton.closest('.cause-card').find('.signatures-list');
                            signaturesList.append('<p>' + data.signature + '</p>');

                            // Update the signature count
                            var signatureCount = currentButton.closest('.cause-card').find('.signature-count strong');
                            signatureCount.text(data.count);
                        } else {
                            // If there was an error, display an alert with the error message
    ");
            WriteLiteral(@"                        alert(data.error);
                        }
                    },
                    error: function () {
                        // If there was an error with the AJAX request, display a general error message
                        alert('An error occurred while processing your request.');
                    }
                });
            }
        });
    });

</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CW.Data.Cause>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591