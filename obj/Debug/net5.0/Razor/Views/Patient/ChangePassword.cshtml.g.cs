#pragma checksum "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f6d7bb29c4b8b19319dc49ec6ac5548caf0c39b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_ChangePassword), @"mvc.1.0.view", @"/Views/Patient/ChangePassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f6d7bb29c4b8b19319dc49ec6ac5548caf0c39b", @"/Views/Patient/ChangePassword.cshtml")]
    public class Views_Patient_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.PatientViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f6d7bb29c4b8b19319dc49ec6ac5548caf0c39b3683", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f6d7bb29c4b8b19319dc49ec6ac5548caf0c39b3943", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f6d7bb29c4b8b19319dc49ec6ac5548caf0c39b5825", async() => {
                WriteLiteral("\n    <div>\n");
#nullable restore
#line 19 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
         using (Html.BeginForm("ChangePassword", "Patient", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<table class=\"table-bordered\">\n    <tr>\n        <td>\n            ");
#nullable restore
#line 24 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
       Write(Html.Label("Old Password", "Old Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 27 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
       Write(Html.Password("oldPassword"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td>\n            ");
#nullable restore
#line 32 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
       Write(Html.Label("NewPassword", "New Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 35 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
       Write(Html.PasswordFor(m => m.EnteredPassword, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 36 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
       Write(Html.ValidationMessageFor(m => m.EnteredPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td>\n            ");
#nullable restore
#line 41 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
       Write(Html.Label("Retype New Password", "Retype New Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n        </td>\n        <td>\n            ");
#nullable restore
#line 45 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
       Write(Html.PasswordFor(m => m.RetypeEnteredPassword, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 46 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
       Write(Html.ValidationMessageFor(m => m.RetypeEnteredPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </td>\n    </tr>\n</table>\n                <button class=\"btn btn-primary\">Change Password</button>");
#nullable restore
#line 50 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
                                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br />\n        ");
#nullable restore
#line 53 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
   Write(Html.ActionLink("Return to Main Page", "PatientConsole", "Patient"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n    <section class=\"alert alert-danger\">\n        ");
#nullable restore
#line 56 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\ChangePassword.cshtml"
   Write(ViewData["ChangePassword"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    </section>\n");
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
            WriteLiteral("\n</html>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.PatientViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
