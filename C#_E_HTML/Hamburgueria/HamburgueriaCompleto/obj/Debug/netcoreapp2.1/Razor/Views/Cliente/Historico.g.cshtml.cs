#pragma checksum "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc0884010de0e55f27e628a3e7f87fcbec08cb46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\_ViewImports.cshtml"
using Hamburgueria;

#line default
#line hidden
#line 2 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\_ViewImports.cshtml"
using Hamburgueria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc0884010de0e55f27e628a3e7f87fcbec08cb46", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bfcae468d1cbc5c7f24a51f853f9b8db2281679", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hamburgueria.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Pedidos - McBonald's";
    ViewData["H2"] = "Histórico de Pedidos";

#line default
#line hidden
            BeginContext(153, 10, true);
            WriteLiteral("<header>\r\n");
            EndContext();
#line 7 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Cliente\Historico.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(224, 87, true);
            WriteLiteral("    <hgroup>\r\n        <h1>McBonald\'s</h1>\r\n    </hgroup>\r\n</header>\r\n\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(312, 14, false);
#line 16 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(326, 270, true);
            WriteLiteral(@"</h2>
    <h3>Seu histórico:</h3>
    <table>
        <thead>
            <tr>
                <th>Data</th>
                <th>Hamburguer</th>
                <th>Shake</th>
                <th>Preço</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 28 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Cliente\Historico.cshtml"
             foreach( var pedido in Model.Pedidos ) {

#line default
#line hidden
            BeginContext(651, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(698, 17, false);
#line 30 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Cliente\Historico.cshtml"
                   Write(pedido.DataPedido);

#line default
#line hidden
            EndContext();
            BeginContext(715, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(747, 22, false);
#line 31 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Cliente\Historico.cshtml"
                   Write(pedido.Hamburguer.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(769, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(801, 17, false);
#line 32 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Cliente\Historico.cshtml"
                   Write(pedido.Shake.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(818, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(850, 17, false);
#line 33 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Cliente\Historico.cshtml"
                   Write(pedido.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(867, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(912, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hamburgueria.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
