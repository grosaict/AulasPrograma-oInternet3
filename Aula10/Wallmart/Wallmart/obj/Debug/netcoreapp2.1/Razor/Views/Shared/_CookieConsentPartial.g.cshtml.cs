#pragma checksum "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula10\Wallmart\Wallmart\Views\Shared\_CookieConsentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e11221416bcb9c68b1689e225cad66e1f5c3dd60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CookieConsentPartial), @"mvc.1.0.view", @"/Views/Shared/_CookieConsentPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CookieConsentPartial.cshtml", typeof(AspNetCore.Views_Shared__CookieConsentPartial))]
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
#line 1 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula10\Wallmart\Wallmart\Views\_ViewImports.cshtml"
using Wallmart;

#line default
#line hidden
#line 2 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula10\Wallmart\Wallmart\Views\_ViewImports.cshtml"
using Wallmart.Models;

#line default
#line hidden
#line 1 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula10\Wallmart\Wallmart\Views\Shared\_CookieConsentPartial.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11221416bcb9c68b1689e225cad66e1f5c3dd60", @"/Views/Shared/_CookieConsentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7b621aae5cb5cb6e6d0a575f19b1fe5ce33d63", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CookieConsentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula10\Wallmart\Wallmart\Views\Shared\_CookieConsentPartial.cshtml"
  
    var consentFeature = Context.Features.Get<ITrackingConsentFeature>();
    var showBanner = !consentFeature?.CanTrack ?? false;
    var cookieString = consentFeature?.CreateConsentCookie();

#line default
#line hidden
            BeginContext(248, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula10\Wallmart\Wallmart\Views\Shared\_CookieConsentPartial.cshtml"
 if (showBanner)
{

#line default
#line hidden
            BeginContext(271, 1158, true);
            WriteLiteral(@"    <!--<nav id=""cookieConsent"" class=""navbar navbar-default navbar-fixed-top"" role=""alert"">
        <div class=""container"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#cookieConsent .navbar-collapse"">
                    <span class=""sr-only"">Toggle cookie consent banner</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <span class=""navbar-brand""><span class=""glyphicon glyphicon-info-sign"" aria-hidden=""true""></span></span>
            </div>
            <div class=""collapse navbar-collapse"">
                <p class=""navbar-text"">
                    Use this space to summarize your privacy and cookie use policy.
                </p>
                <div class=""navbar-right"">
                    <a asp-controller=""Home"" asp-action=""Privacy"" class=""btn ");
            WriteLiteral("btn-info navbar-btn\">Learn More</a>\r\n                    <button type=\"button\" class=\"btn btn-default navbar-btn\" data-cookie-string=\"");
            EndContext();
            BeginContext(1430, 12, false);
#line 28 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula10\Wallmart\Wallmart\Views\Shared\_CookieConsentPartial.cshtml"
                                                                                            Write(cookieString);

#line default
#line hidden
            EndContext();
            BeginContext(1442, 459, true);
            WriteLiteral(@""">Accept</button>
                </div>
            </div>
        </div>
    </nav>-->
    <script>
        (function () {
            document.querySelector(""#cookieConsent button[data-cookie-string]"").addEventListener(""click"", function (el) {
                document.cookie = el.target.dataset.cookieString;
                document.querySelector(""#cookieConsent"").classList.add(""hidden"");
            }, false);
        })();
    </script>
");
            EndContext();
#line 41 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula10\Wallmart\Wallmart\Views\Shared\_CookieConsentPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
