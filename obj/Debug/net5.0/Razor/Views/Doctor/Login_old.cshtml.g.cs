#pragma checksum "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\Login_old.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62a85af135bec00a70b3323a96b2a1ebd54dab6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Login_old), @"mvc.1.0.view", @"/Views/Doctor/Login_old.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62a85af135bec00a70b3323a96b2a1ebd54dab6f", @"/Views/Doctor/Login_old.cshtml")]
    public class Views_Doctor_Login_old : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.DoctorViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\Login_old.cshtml"
  Layout = "~/views/Doctor/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62a85af135bec00a70b3323a96b2a1ebd54dab6f2832", async() => {
                WriteLiteral("\n    <h1 id=\"main\" class=\"alert alert-danger\" align=\"left\">Doctor Login</h1>\n    <div class=\"row\">\n        <div class=\"col-md-4\">\n");
#nullable restore
#line 8 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\Login_old.cshtml"
             using (Html.BeginForm("Login", "Doctor", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\Login_old.cshtml"
Write(Html.LabelFor(m => m.Username, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\Login_old.cshtml"
           Write(Html.EditorFor(m => m.Username, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\Login_old.cshtml"
                           Write(Html.LabelFor(m => m.EnteredPassword, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\Login_old.cshtml"
                                           Write(Html.PasswordFor(m => m.EnteredPassword, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <button class=\"btn btn-success\">Login</button>            ");
#nullable restore
#line 14 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\Login_old.cshtml"
                                                                                                                          }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    </div>\n    <section>\n        ");
#nullable restore
#line 18 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\Login_old.cshtml"
   Write(Html.ActionLink("Register a new Doctor account", "Register"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </section>\n    <section class=\"alert alert-danger\">\n        ");
#nullable restore
#line 21 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\Login_old.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </section>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.DoctorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
