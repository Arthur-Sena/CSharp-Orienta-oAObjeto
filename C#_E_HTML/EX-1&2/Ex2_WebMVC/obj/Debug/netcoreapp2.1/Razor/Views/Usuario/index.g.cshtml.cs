#pragma checksum "D:\senai\codigos\C#_E_HTML\EX-1&2\Ex2_WebMVC\Views\Usuario\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93f3f975785f6351c701da1a7fab35c4a61809f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_index), @"mvc.1.0.view", @"/Views/Usuario/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/index.cshtml", typeof(AspNetCore.Views_Usuario_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93f3f975785f6351c701da1a7fab35c4a61809f0", @"/Views/Usuario/index.cshtml")]
    public class Views_Usuario_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\senai\codigos\C#_E_HTML\EX-1&2\Ex2_WebMVC\Views\Usuario\index.cshtml"
  
    Layout = "MasterPage";
    ViewBag.Title = "Cadastrar Usuario";

#line default
#line hidden
            BeginContext(77, 819, true);
            WriteLiteral(@"<div class = ""container"">
    <form action=""/Usuario/Cadastrar"" method=""POST"">
    <h1>CADASTRE-SE</h1>
        <div class=""form-group"">

            <label for=""nome"">Nome:</label>
            <input type=""text"" name=""nome"" class=""form-control"">
            
            <label for=""email"">E-Mail:</label>
            <input type=""text"" name=""email"" class=""form-control"">
            
            <label for=""senha"">Senha:</label>
            <input type=""text"" name=""senha"" class=""form-control"">
            
            <label for=""dataNascimento"">Data de Nascimento:</label>
            <input type=""date"" name=""dataNascimento"" class=""form-control"">
            <br>
            <input type=""submit"" value=""Cadastrar"" class=""btn btn-secondary btn-lg btn-block"">
        </div>
    </form>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
