#pragma checksum "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Car\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abf6624b07dd772ab20f4dde4491aae8c5bcb43a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Detail), @"mvc.1.0.view", @"/Views/Car/Detail.cshtml")]
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
#line 1 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Car\Detail.cshtml"
using İnfoCar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf6624b07dd772ab20f4dde4491aae8c5bcb43a", @"/Views/Car/Detail.cshtml")]
    public class Views_Car_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cars>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Car\Detail.cshtml"
  
    
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 134, "\"", 151, 1);
#nullable restore
#line 8 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Car\Detail.cshtml"
WriteAttributeValue("", 140, Model.Link, 140, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">Brand: ");
#nullable restore
#line 10 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Car\Detail.cshtml"
                                 Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5 class=\"card-title mt-2\">Model: ");
#nullable restore
#line 11 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Car\Detail.cshtml"
                                      Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">Model Id: ");
#nullable restore
#line 12 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Car\Detail.cshtml"
                                  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Model Average: ");
#nullable restore
#line 13 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Car\Detail.cshtml"
                                       Write(Model.Average);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Model Year: ");
#nullable restore
#line 14 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Car\Detail.cshtml"
                                    Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Model Price: ");
#nullable restore
#line 15 "C:\Users\user\Desktop\İnfoCar\İnfoCar\İnfoCar\Views\Car\Detail.cshtml"
                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cars> Html { get; private set; }
    }
}
#pragma warning restore 1591
