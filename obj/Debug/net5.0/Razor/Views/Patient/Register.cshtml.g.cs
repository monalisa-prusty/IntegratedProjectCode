#pragma checksum "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "414e336b691b3980bf5bef4f9136e4bc61285ed8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Register), @"mvc.1.0.view", @"/Views/Patient/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"414e336b691b3980bf5bef4f9136e4bc61285ed8", @"/Views/Patient/Register.cshtml")]
    public class Views_Patient_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.PatientViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414e336b691b3980bf5bef4f9136e4bc61285ed83632", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "414e336b691b3980bf5bef4f9136e4bc61285ed83955", async() => {
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
                WriteLiteral(@"
    <title>Register</title>
    <style>
        form {
            width: 300px;
        }
    </style>
    <script>
                //function passwordCheck() {
                //    var pass = document.getElementById(""Password"").value;
                //    var repass = document.getElementById(""txtReType"").value;
                //    if (pass != repass)
                //        alert(""Password Mismatch"");
                //}
    </script>
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414e336b691b3980bf5bef4f9136e4bc61285ed86286", async() => {
                WriteLiteral("\n\n    <h1 id=\"main\" class=\"alert alert-danger\">Register Account</h1>\n    <hr />\n    <div class=\"row\">\n        <div class=\"col-md-4\">\n");
#nullable restore
#line 28 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
             using (Html.BeginForm("Register", "Patient", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.LabelFor(m => m.Username, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.EditorFor(m => m.Username, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.ValidationMessageFor(m => m.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.LabelFor(m => m.EnteredPassword, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.PasswordFor(m => m.EnteredPassword, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.ValidationMessageFor(m => m.EnteredPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.LabelFor(m => m.RetypeEnteredPassword, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.PasswordFor(m => m.RetypeEnteredPassword, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.ValidationMessageFor(m => m.RetypeEnteredPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.LabelFor(m => m.Name, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.EditorFor(m => m.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.LabelFor(m => m.Age, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.EditorFor(m => m.Age, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.LabelFor(m => m.Gender, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.EditorFor(m => m.Gender, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.ValidationMessageFor(m => m.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.LabelFor(m => m.Phone, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
           Write(Html.EditorFor(m => m.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
                                                                                                       
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"



                                                                                                                                                                                                                                                                                                                <button class=""btn btn-primary"">Create Account</button>}
        </div>
    </div>
    <section>
        ");
#nullable restore
#line 68 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
   Write(Html.ActionLink("Back to Login", "Login"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </section>\n    <section class=\"alert alert-danger\">\n        ");
#nullable restore
#line 71 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </section>\n\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 75 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Patient\Register.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                    WriteLiteral("    ");
                }
                );
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
            WriteLiteral("\n</html>");
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