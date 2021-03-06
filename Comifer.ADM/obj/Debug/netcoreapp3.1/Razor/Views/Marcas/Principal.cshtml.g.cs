#pragma checksum "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Principal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eb11e8fdf4d91a17d23e9c2918f3753bb339022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marcas_Principal), @"mvc.1.0.view", @"/Views/Marcas/Principal.cshtml")]
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
#line 1 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\_ViewImports.cshtml"
using Comifer.ADM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\_ViewImports.cshtml"
using Comifer.ADM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb11e8fdf4d91a17d23e9c2918f3753bb339022", @"/Views/Marcas/Principal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf8b3bf2f5c74247df7ef878a66f7e314975e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Marcas_Principal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comifer.ADM.ViewModels.DetailedBrandViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Principal.cshtml"
  
    ViewData["Title"] = "Lista de Marcas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral(@"
    <div class=""row align-items-center py-4"">
        <div class=""col-lg-6 col-7"">
            <h6 class=""h2 text-white d-inline-block mb-0"">Marcas</h6>
            <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                    <li class=""breadcrumb-item""><a");
                BeginWriteAttribute("href", " href=\"", 496, "\"", 537, 1);
#nullable restore
#line 12 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Principal.cshtml"
WriteAttributeValue("", 503, Url.Action("Principal", "Inicio"), 503, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fas fa-home""></i> Inicio</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Marcas</li>
                </ol>
            </nav>
        </div>
        <div class=""col-lg-6 col-5 text-right"">
            <a");
                BeginWriteAttribute("href", " href=\"", 794, "\"", 832, 1);
#nullable restore
#line 18 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Principal.cshtml"
WriteAttributeValue("", 801, Url.Action("Incluir","Marcas"), 801, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-neutral\">Nova</a>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"col\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header border-0\">\r\n");
#nullable restore
#line 26 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Principal.cshtml"
             using (@Html.BeginForm("Principal", "Marcas"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row filter\">\r\n                    <div class=\"col-12 pb-2\">\r\n                        <label for=\"ProviderId\">Fornecedor:</label>\r\n                        ");
#nullable restore
#line 31 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Principal.cshtml"
                   Write(Html.DropDownList("idFornecedor", new List<SelectListItem>(ViewBag.Providers), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-12 mt-1\">\r\n                        <button type=\"submit\" class=\"btn btn-primary pull-right\">Filtrar</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 37 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Principal.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"mb-0\">Lista</h3>\r\n        </div>\r\n        ");
#nullable restore
#line 40 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Principal.cshtml"
   Write(await Html.PartialAsync("_Brands", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            if (\'");
#nullable restore
#line 47 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Principal.cshtml"
            Write(ViewBag.ProviderId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' != \'\') {\r\n                $(\"#idFornecedor\").val(\'");
#nullable restore
#line 48 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Principal.cshtml"
                                   Write(ViewBag.ProviderId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            }\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comifer.ADM.ViewModels.DetailedBrandViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
