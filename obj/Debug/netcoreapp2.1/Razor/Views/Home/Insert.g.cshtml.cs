#pragma checksum "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c3d19f125fca5575286fcf61d9ec5d92a018969"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Insert), @"mvc.1.0.view", @"/Views/Home/Insert.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Insert.cshtml", typeof(AspNetCore.Views_Home_Insert))]
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
#line 1 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#line 1 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
using NETCoreWebApplication.Models;

#line default
#line hidden
#line 2 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
using NETCoreWebApplication.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c3d19f125fca5575286fcf61d9ec5d92a018969", @"/Views/Home/Insert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Insert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InsertPersonShoeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
  
    ViewData["Title"] = "Insert";
    HomeController hc = new HomeController();
    

#line default
#line hidden
            BeginContext(204, 53, true);
            WriteLiteral("\r\n<div class=\"container\" style=\"padding-top:70px;\">\r\n");
            EndContext();
#line 11 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
     using (Html.BeginForm("Insert", "Home", FormMethod.Post, new { enctype = "multipart/formdata" }))
    {

#line default
#line hidden
            BeginContext(368, 327, true);
            WriteLiteral(@"        <h2>Insert Person & Shoe</h2>
        <hr />
        <div class=""row "">
            <div class=""col-md-8 jumbotron"">
                <div class=""col-md-6"" style=""padding-right:20px;"">
                    <div class=""form-horizontal "">
                        <div class=""form-group"">
                            ");
            EndContext();
            BeginContext(696, 26, false);
#line 20 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
                       Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(722, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(753, 144, false);
#line 21 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
                       Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control", style = "border-right-style:none; border-left-style:none; border-top-style:none;" }));

#line default
#line hidden
            EndContext();
            BeginContext(897, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1010, 25, false);
#line 24 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
                       Write(Html.LabelFor(x => x.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1066, 174, false);
#line 25 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
                       Write(Html.DropDownListFor(x => x.Age, hc.AgeList, "Select Age", new { @class = "form-control", style = "border-right-style:none; border-left-style:none; border-top-style:none;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1353, 28, false);
#line 28 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
                       Write(Html.LabelFor(x => x.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1412, 183, false);
#line 29 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
                       Write(Html.DropDownListFor(x => x.Gender, hc.GenderList, "Select Gender", new { @class = "form-control", style = "border-right-style:none; border-left-style:none; border-top-style:none;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 283, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""form-horizontal"" style=""padding-right:30px;"">
                        <div class=""form-group"">
                            ");
            EndContext();
            BeginContext(1879, 30, false);
#line 36 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
                       Write(Html.LabelFor(x => x.ShoeName));

#line default
#line hidden
            EndContext();
            BeginContext(1909, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1940, 148, false);
#line 37 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
                       Write(Html.TextBoxFor(x => x.ShoeName, new { @class = "form-control", style = "border-right-style:none; border-left-style:none; border-top-style:none;" }));

#line default
#line hidden
            EndContext();
            BeginContext(2088, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2201, 31, false);
#line 40 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
                       Write(Html.LabelFor(x => x.ShoeBrand));

#line default
#line hidden
            EndContext();
            BeginContext(2232, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2263, 149, false);
#line 41 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
                       Write(Html.TextBoxFor(x => x.ShoeBrand, new { @class = "form-control", style = "border-right-style:none; border-left-style:none; border-top-style:none;" }));

#line default
#line hidden
            EndContext();
            BeginContext(2412, 327, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <button role=""button"" class=""btn btn-success btn-effect"" value=""Register"">
                <span>INSERT RECORD</span>
            </button>
        </div>
");
            EndContext();
#line 52 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\NETCoreWebApplication\NETCoreWebApplication\Views\Home\Insert.cshtml"
    }

#line default
#line hidden
            BeginContext(2746, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InsertPersonShoeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
