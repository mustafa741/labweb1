#pragma checksum "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d61adc5cc5f54a05d91bdcbeeab5755749f4cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
#line 2 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\_ViewImports.cshtml"
using lab2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\_ViewImports.cshtml"
using lab2.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\_ViewImports.cshtml"
using lab2.Models.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
using lab2.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d61adc5cc5f54a05d91bdcbeeab5755749f4cea", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e5614b20ac272ccf4ebe9de2ab6293ee85af46", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 4 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 6 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 7 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 10 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
      Write(Config.SiteName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 11 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 322, "\"", 351, 1);
#nullable restore
#line 14 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 332, ViewBag.Descripton, 332, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 15 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 423, "\"", 450, 1);
#nullable restore
#line 18 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 433, ViewBag.Keywords, 433, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 19 "C:\Users\Кирилл\Desktop\мусс\lab2\lab2\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591