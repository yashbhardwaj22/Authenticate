#pragma checksum "C:\Users\yashb\Desktop\RegisterLogin\RegisterLogin\Views\Login\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c81c962fbafcebe51443bc38e213d6fe45850253"
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
#line 1 "C:\Users\yashb\Desktop\RegisterLogin\RegisterLogin\Views\_ViewImports.cshtml"
using RegisterLogin;

#line default
#line hidden
#line 2 "C:\Users\yashb\Desktop\RegisterLogin\RegisterLogin\Views\_ViewImports.cshtml"
using RegisterLogin.Models;

#line default
#line hidden
#line 1 "C:\Users\yashb\Desktop\RegisterLogin\RegisterLogin\Views\Login\Dashboard.cshtml"
using RegisterLogin.DAL;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c81c962fbafcebe51443bc38e213d6fe45850253", @"/Views/Login/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"975bd0c6192f0b95cfd20e726b22f59375d0fb6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Login>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\yashb\Desktop\RegisterLogin\RegisterLogin\Views\Login\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(85, 47, true);
            WriteLiteral("\r\n<h2>Dashboard</h2>\r\n\r\n<h2>hello good evening ");
            EndContext();
            BeginContext(133, 14, false);
#line 9 "C:\Users\yashb\Desktop\RegisterLogin\RegisterLogin\Views\Login\Dashboard.cshtml"
                  Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(147, 7, true);
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