#pragma checksum "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "432652ac76746888edd360a4d366f59d716b18de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Models.DTOs.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"432652ac76746888edd360a4d366f59d716b18de", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be194870830f42a069c9ea434231893299df8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Order/New"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 300px; height: 150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("nu exista imagine momentan"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\Order\Index.cshtml"
      
    ViewData["Title"] = "Order";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4 style=\"color:ghostwhite\">Order Info</h4>\r\n<hr />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "432652ac76746888edd360a4d366f59d716b18de5701", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label style=\"color:ghostwhite\" for=\"FirstName\">First Name:</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"FirstName\"");
                BeginWriteAttribute("value", " value=\"", 338, "\"", 346, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label style=\"color:ghostwhite\" for=\"LastName\">Last Name:</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"LastName\"");
                BeginWriteAttribute("value", " value=\"", 530, "\"", 538, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-row\">\r\n        <div class=\"form-group col-md-6\">\r\n            <label style=\"color:ghostwhite\" for=\"PhoneNumber\">Phone Number:</label>\r\n            <input type=\"text\" class=\"form-control\" name=\"PhoneNumber\"");
                BeginWriteAttribute("value", " value=\"", 780, "\"", 788, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n        </div>\r\n        <div class=\"form-group col-md-6\">\r\n            <label style=\"color:ghostwhite\" for=\"Email\">Email:</label>\r\n            <input type=\"email\" class=\"form-control\" name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 992, "\"", 1000, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label style=\"color:ghostwhite\" for=\"Address\">Address:</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Address\"");
                BeginWriteAttribute("value", " value=\"", 1200, "\"", 1208, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    </div>\r\n\r\n    <button style=\"color:ghostwhite\" type=\"submit\" value=\"Submit\" class=\"btn btn-primary\">Place order</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<br/><br />


<table id=""table"" class=""table table-hover table-striped table-dark"">
    <thead>
        <tr>
            <th hidden>Product Id</th>
            <th>Image</th>
            <th>Product name</th>
            <th>Price</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 53 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\Order\Index.cshtml"
         foreach (var item in Model.OrderDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 1720, "\"", 1733, 1);
#nullable restore
#line 55 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\Order\Index.cshtml"
WriteAttributeValue("", 1725, item.Id, 1725, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td hidden>");
#nullable restore
#line 56 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\Order\Index.cshtml"
                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "432652ac76746888edd360a4d366f59d716b18de10517", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1838, "~/", 1838, 2, true);
#nullable restore
#line 57 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\Order\Index.cshtml"
AddHtmlAttributeValue("", 1840, item.ImagePath, 1840, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 58 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\Order\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 59 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\Order\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Bianca Barat\OneDrive\Desktop\ECommerce-main\ProiectMaster\ProiectMaster.Web\Views\Order\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </tbody>

</table>


<div class=""row mb-2 mt-2 operationsButtons"">
    <div class=""col-md-12"">
        <button type=""button"" class=""btn btn-delete btn-outline-delete font-weight-bold mr-2"" id=""btnDelete"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Order.onDelete()"">
            <span class=""fa fa-trash""></span>
        </button>
    </div>
</div>
");
        }
        #pragma warning restore 1998
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
