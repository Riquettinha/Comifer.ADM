#pragma checksum "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84c874937b652c5137ce43659026d8961bd01276"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marcas_Detalhes), @"mvc.1.0.view", @"/Views/Marcas/Detalhes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c874937b652c5137ce43659026d8961bd01276", @"/Views/Marcas/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf8b3bf2f5c74247df7ef878a66f7e314975e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Marcas_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comifer.ADM.ViewModels.DetailedBrandViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes Marca";

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
                BeginWriteAttribute("href", " href=\"", 489, "\"", 530, 1);
#nullable restore
#line 12 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
WriteAttributeValue("", 496, Url.Action("Principal", "Inicio"), 496, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-home\"></i> Inicio</a></li>\r\n                    <li class=\"breadcrumb-item\"><a");
                BeginWriteAttribute("href", " href=\"", 627, "\"", 668, 1);
#nullable restore
#line 13 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
WriteAttributeValue("", 634, Url.Action("Principal", "Marcas"), 634, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Marcas</a></li>\r\n                    <li class=\"breadcrumb-item active\" aria-current=\"page\">Detalhes</li>\r\n                </ol>\r\n            </nav>\r\n        </div>\r\n        <div class=\"col-lg-6 col-5 text-right\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 899, "\"", 939, 1);
#nullable restore
#line 19 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
WriteAttributeValue("", 906, Url.Action("Principal","Marcas"), 906, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-neutral\">Lista de Marcas</a>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""col-xl-12 order-xl-1"">
    <div class=""card"">
        <div class=""card-header"">
            <div class=""row align-items-center"">
                <div class=""col-8"">
                    <h3 class=""mb-0"">Detalhes</h3>
                </div>
                <div class=""col-4"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 1343, "\"", 1404, 1);
#nullable restore
#line 32 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
WriteAttributeValue("", 1350, Url.Action("Editar", "Marcas", new { id = Model.Id }), 1350, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-sm pull-right"">
                        <i class=""fa fa-edit""></i> Editar
                    </a>
                </div>
            </div>
        </div>
        <div class=""card-body detailment"">
            <div class=""pl-lg-12"">
                <div class=""form-group"">
                    ");
#nullable restore
#line 41 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
               Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 42 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
               Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 45 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
               Write(Html.LabelFor(m => m.SiteUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 46 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
               Write(Html.DisplayFor(m => m.SiteUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 49 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
               Write(Html.LabelFor(m => m.ProviderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 50 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
               Write(Html.DisplayFor(m => m.ProviderName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 53 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
               Write(Html.LabelFor(m => m.ProductParentCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 54 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
               Write(Html.DisplayFor(m => m.ProductParentCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 57 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
               Write(Html.LabelFor(m => m.ProductCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 58 "C:\Projetos\Pessoais\Comifer\Comifer.ADM\Views\Marcas\Detalhes.cshtml"
               Write(Html.DisplayFor(m => m.ProductCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comifer.ADM.ViewModels.DetailedBrandViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591