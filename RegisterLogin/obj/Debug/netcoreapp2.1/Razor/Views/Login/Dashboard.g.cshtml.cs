#pragma checksum "C:\Users\yashb\Desktop\Authenticate\RegisterLogin\Views\Login\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61284e92de3c7d9de7fa63d09887853095feacc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Dashboard), @"mvc.1.0.view", @"/Views/Login/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Dashboard.cshtml", typeof(AspNetCore.Views_Login_Dashboard))]
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
#line 1 "C:\Users\yashb\Desktop\Authenticate\RegisterLogin\Views\_ViewImports.cshtml"
using Authenticate;

#line default
#line hidden
#line 2 "C:\Users\yashb\Desktop\Authenticate\RegisterLogin\Views\_ViewImports.cshtml"
using Authenticate.Models;

#line default
#line hidden
#line 1 "C:\Users\yashb\Desktop\Authenticate\RegisterLogin\Views\Login\Dashboard.cshtml"
using Authenticate.DAL;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61284e92de3c7d9de7fa63d09887853095feacc8", @"/Views/Login/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"becffa86d6d7127e376aeaf8330572008d4853de", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Login>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\yashb\Desktop\Authenticate\RegisterLogin\Views\Login\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(84, 47, true);
            WriteLiteral("\r\n<h2>Dashboard</h2>\r\n\r\n<h2>hello good evening ");
            EndContext();
            BeginContext(132, 14, false);
#line 9 "C:\Users\yashb\Desktop\Authenticate\RegisterLogin\Views\Login\Dashboard.cshtml"
                  Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(146, 7, true);
            WriteLiteral("</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Login> Html { get; private set; }
    }
}
#pragma warning restore 1591
