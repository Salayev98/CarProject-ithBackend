#pragma checksum "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fec2dcfc30eeae9d4ec9c70c7a13b4749056e7a1"
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
#line 1 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
using İnfoCar.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec2dcfc30eeae9d4ec9c70c7a13b4749056e7a1", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Brands</h1>\r\n<ul class=\"mt-2\">\r\n");
#nullable restore
#line 9 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
     foreach (var item in Model.Brands)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>Cars Brands Id: ");
#nullable restore
#line 11 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Cars Brands Name: ");
#nullable restore
#line 11 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 12 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<h1 class=\"mt-2\">Models</h1>\r\n<ul class=\"mt-2\">\r\n");
#nullable restore
#line 16 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
     foreach (var item in Model.Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>Cars Models Id: ");
#nullable restore
#line 18 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Cars Models Name: ");
#nullable restore
#line 18 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 19 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<h1 class=\"mt-2\">Cars</h1>\r\n\r\n<div class=\"card\" style=\"width: 18rem\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
     foreach (var item in Model.Cars)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 580, "\"", 596, 1);
#nullable restore
#line 28 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
WriteAttributeValue("", 586, item.Link, 586, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">Brand: ");
#nullable restore
#line 30 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                                     Write(item.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5 class=\"card-title mt-2\">Model: ");
#nullable restore
#line 31 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                                          Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">Model Id: ");
#nullable restore
#line 32 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Model Average: ");
#nullable restore
#line 33 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                                           Write(item.Average);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Model Year: ");
#nullable restore
#line 34 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                                        Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Model Price: ");
#nullable restore
#line 35 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a href=\"#\">");
#nullable restore
#line 36 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("to Detail", "detail", "car"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </div>\r\n");
#nullable restore
#line 38 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
