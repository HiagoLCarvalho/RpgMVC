#pragma checksum "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a2886064ea7a0ffe8a8f49d38003d7c0f7ca464"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagens_Edit), @"mvc.1.0.view", @"/Views/Personagens/Edit.cshtml")]
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
#line 1 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a2886064ea7a0ffe8a8f49d38003d7c0f7ca464", @"/Views/Personagens/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd6c27e866fba86603325ac11c78fec551602e1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Personagens_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.PersonagemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
  
    ViewBag.Title = "Editar Personagem";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Editar dados do Personagem</h2>\n");
#nullable restore
#line 6 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n        <hr />\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 12 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
       Write(Html.LabelFor(model => model.Id, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 14 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
           Write(Html.EditorFor(model => model.Id, new { htmlAttributes = new { @class = "form-control", @readonly =
            "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 19 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 21 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 25 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
       Write(Html.LabelFor(model => model.PontosVida, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 27 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
           Write(Html.EditorFor(model => model.PontosVida, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 31 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
       Write(Html.LabelFor(model => model.Forca, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 33 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
           Write(Html.EditorFor(model => model.Forca, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 37 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
       Write(Html.LabelFor(model => model.Defesa, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 39 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
           Write(Html.EditorFor(model => model.Defesa, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 43 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
       Write(Html.LabelFor(model => model.Inteligencia, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 45 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
           Write(Html.EditorFor(model => model.Inteligencia, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 49 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
       Write(Html.LabelFor(model => model.Classe, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 51 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
           Write(Html.DropDownListFor(model => model.Classe ,
            Html.GetEnumSelectList(typeof(RpgMvc.Models.Enums.ClasseEnum)),
            "---Selecione---", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-6\">\n                <input type=\"submit\" value=\"Salvar altera????es\" class=\"btn btn-primary\" />\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 62 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    ");
#nullable restore
#line 64 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\Personagens\Edit.cshtml"
Write(Html.ActionLink("Retornar", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.PersonagemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
