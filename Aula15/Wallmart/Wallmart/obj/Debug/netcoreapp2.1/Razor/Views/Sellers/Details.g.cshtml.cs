#pragma checksum "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a494328c17e35042170d79ece8362b2cb65faf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Details), @"mvc.1.0.view", @"/Views/Sellers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Details.cshtml", typeof(AspNetCore.Views_Sellers_Details))]
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
#line 1 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\_ViewImports.cshtml"
using Wallmart;

#line default
#line hidden
#line 2 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\_ViewImports.cshtml"
using Wallmart.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a494328c17e35042170d79ece8362b2cb65faf8", @"/Views/Sellers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7b621aae5cb5cb6e6d0a575f19b1fe5ce33d63", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wallmart.Models.Seller>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(83, 17, false);
#line 7 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(100, 107, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4>Seller</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(208, 40, false);
#line 14 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(292, 36, false);
#line 17 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(328, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(372, 41, false);
#line 20 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(457, 37, false);
#line 23 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(494, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(538, 45, false);
#line 26 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(583, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(627, 41, false);
#line 29 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(668, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(712, 42, false);
#line 32 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(754, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(798, 38, false);
#line 35 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(836, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(880, 46, false);
#line 38 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(926, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(970, 47, false);
#line 41 "C:\Users\gsenn\Desktop\workspace\PI3-Atividades\Aula15\Wallmart\Wallmart\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 36, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wallmart.Models.Seller> Html { get; private set; }
    }
}
#pragma warning restore 1591
