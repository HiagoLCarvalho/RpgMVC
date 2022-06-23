#pragma checksum "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dbce17c3e6bbadf5dcf50975c8ebce026b0ade2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonagemHabilidades_Index), @"mvc.1.0.view", @"/Views/PersonagemHabilidades/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dbce17c3e6bbadf5dcf50975c8ebce026b0ade2", @"/Views/PersonagemHabilidades/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd6c27e866fba86603325ac11c78fec551602e1f", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonagemHabilidades_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.PersonagemHabilidadeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 8 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 9 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 13 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 14 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Habilidades do Personagem</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>");
#nullable restore
#line 18 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
       Write(Html.DisplayName("Personagem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 19 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
       Write(Html.DisplayName("Habilidade"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 20 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Habilidade.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Personagem.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Habilidade.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Habilidade.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
           Write(Html.ActionLink("Deletar", "Delete"
            , new {habilidadeId = item.HabilidadeId, personagemId = item.PersonagemId}
            , new { onclick = "return confirm('Deseja realmente deletar esta habilidade?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div>\r\n    ");
#nullable restore
#line 35 "C:\Users\Hiago\OneDrive\Desktop\Gabs\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
Write(Html.ActionLink("Retornar aos Personagens", "Index", "Personagens"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.PersonagemHabilidadeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
