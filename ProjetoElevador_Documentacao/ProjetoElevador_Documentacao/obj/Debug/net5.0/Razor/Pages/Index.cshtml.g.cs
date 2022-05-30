#pragma checksum "E:\evandrosouzabr\Documentos\GitHub\CursoFormacaoMSDEVSamsungOcean2022\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "347abd70b099c850b5246cd4d79d65cb44ed1a47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetoElevador_Documentacao.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ProjetoElevador_Documentacao.Pages
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
#line 1 "E:\evandrosouzabr\Documentos\GitHub\CursoFormacaoMSDEVSamsungOcean2022\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Pages\_ViewImports.cshtml"
using ProjetoElevador_Documentacao;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347abd70b099c850b5246cd4d79d65cb44ed1a47", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a585ffd0c9fa06c332a76792c08fde053b9e4cd3", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\evandrosouzabr\Documentos\GitHub\CursoFormacaoMSDEVSamsungOcean2022\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Pages\Index.cshtml"
  
    ViewData["Title"] = "Projeto Elevador - Evandro Souza";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Projeto Elevador</h1>
    <p>[FORMAÇÃO MS-DEV] Aprendendo a programar com C#: teoria e prática.</p>
    <p>Elaborado por Evandro Vidéo de Souza Júnior</p>
</div>
<div align=""justify"">
    <p>O projeto consiste em permitir que o usuário defina o número de andares do prédio e a quantidade máxima
       de pessoas que o elevador poderá suportar.
       Após informar a quantidade máxima de andares e a capacidade máxima do elevador, o programa apresenta um
       conjunto de opções para que o usuário possa escolher uma das seguintes ações:</p>
       <p><b>[1] - Entrar no elevador:</b> deve acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço).</p>
       <p><b>[2] - Sair do elevador:</b>deve remover uma pessoa do elevador (só deve remover se houver alguém dentro dele).</p>
       <p><b>[3] - Subir um andar:</b>deve subir um andar (não deve subir se já estiver no último andar).</p>
       <p><b>[4] - Descer um andar:</b>de");
            WriteLiteral(@"ve descer um andar (não deve descer se já estiver no térreo).</p>
       <p><b>[5] - Finalizar o programa:</b> Sai do programa.</p>
</div>
<div align=""justify"">
    <p>As regras de negócio das funções (métodos) que o elevador pode realizar estão definidas dentro da classe <b>Elevador</b>,
       que encontra-se dentro da pasta Model.</p>
    <p> Para maiore informações sobre o projeto, favor entrar em contato comigo pelos contatos abaixo:</p>
    <p><a href=""https://github.com/evandrosouzabr"">Meu Gihthub!</a></p>
    <p><a href=mailto:evandrosouzabr@gmail.com>Meu e-mail!</p>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591