#pragma checksum "/Users/rojaslcc/Projects/mi-pasteleria/mi-pasteleria/Pages/Baker/Stock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "469c35ce5549d55d031cfc66d7f3dc6ee3dc93ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(mi_pasteleria.Pages.Baker.Pages_Baker_Stock), @"mvc.1.0.razor-page", @"/Pages/Baker/Stock.cshtml")]
namespace mi_pasteleria.Pages.Baker
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
#line 1 "/Users/rojaslcc/Projects/mi-pasteleria/mi-pasteleria/Pages/_ViewImports.cshtml"
using mi_pasteleria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/rojaslcc/Projects/mi-pasteleria/mi-pasteleria/Pages/Baker/Stock.cshtml"
using Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469c35ce5549d55d031cfc66d7f3dc6ee3dc93ed", @"/Pages/Baker/Stock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11efe038d2eb7b9d6203ab527fdc50db60343d15", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Baker_Stock : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/rojaslcc/Projects/mi-pasteleria/mi-pasteleria/Pages/Baker/Stock.cshtml"
  
    ViewBag.Title = "Stock";
    List<Stock> stocks = new List<Stock> {
        new Stock() { id = 1, name = "Chocolate", productType = "Sabor", quantity = "50" },
        new Stock() { id = 2, name = "Vainilla", productType = "Sabor", quantity = "50" },
        new Stock() { id = 3, name = "Red Velvet", productType = "Sabor", quantity = "50" },
        new Stock() { id = 4, name = "Almendra", productType = "Sabor", quantity = "50" },
        new Stock() { id = 5, name = "Limón", productType = "Sabor", quantity = "50" },
        new Stock() { id = 6, name = "Champagne", productType = "Sabor", quantity = "50" },
        new Stock() { id = 7, name = "Zanahoria", productType = "Sabor", quantity = "50" },
        new Stock() { id = 8, name = "Caramelo", productType = "Sabor", quantity = "50" },
        new Stock() { id = 9, name = "Calabaza", productType = "Sabor", quantity = "50" },
        new Stock() { id = 10, name = "Crema batida", productType = "Cobertura", quantity = "50" },
        new Stock() { id = 11, name = "Fondant", productType = "Cobertura", quantity = "50" },
        new Stock() { id = 12, name = "Buttercream", productType = "Cobertura", quantity = "50" },
        new Stock() { id = 13, name = "Meregue", productType = "Cobertura", quantity = "50" },
        new Stock() { id = 14, name = "Ganache", productType = "Cobertura", quantity = "50" },
        new Stock() { id = 15, name = "Queso crema", productType = "Cobertura", quantity = "50" },
        new Stock() { id = 16, name = "Materia prima para numeros", productType = "Adorno", quantity = "50" },
        new Stock() { id = 17, name = "Materia prima para letras", productType = "Adorno", quantity = "50" },
        new Stock() { id = 18, name = "Maßteria prima para personajes", productType = "Adorno", quantity = "50" }
    };

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""py-20 bg-white"">
    <div class=""container max-w-6xl mx-auto"">
        <h2 class=""mb-4 text-4xl font-bold tracking-tight text-center"">Lista de pedidos</h2>
        <div class=""container justify-center mx-auto overflow-y-auto"">
            <div class=""flex flex-col"">
                <div class=""w-full"">
                    <div class=""border-b border-gray-200 shadow"">
                        <table id=""myTable"">
                            <thead class=""bg-gray-50"">
                                <tr>
                                    <th class=""px-6 py-2 text-xs text-gray-500"">
                                        ID
                                    </th>
                                    <th class=""px-6 py-2 text-xs text-gray-500"">
                                        Proucto
                                    </th>
                                    <th class=""px-6 py-2 text-xs text-gray-500"">
                                        Tipo de Producto
                         ");
            WriteLiteral(@"           </th>
                                    <th class=""px-6 py-2 text-xs text-gray-500"">
                                        Cantidad
                                    </th>
                                </tr>
                            </thead>
                            <tbody class=""bg-white"">
");
#nullable restore
#line 53 "/Users/rojaslcc/Projects/mi-pasteleria/mi-pasteleria/Pages/Baker/Stock.cshtml"
                                 foreach (var item in stocks)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"whitespace-nowrap\">\n                                        <td class=\"px-6 py-4 text-sm text-gray-500\">\n                                            ");
#nullable restore
#line 57 "/Users/rojaslcc/Projects/mi-pasteleria/mi-pasteleria/Pages/Baker/Stock.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td class=\"px-6 py-4\">\n                                            <div class=\"text-sm text-gray-900\">\n                                                ");
#nullable restore
#line 61 "/Users/rojaslcc/Projects/mi-pasteleria/mi-pasteleria/Pages/Baker/Stock.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </td>
                                        <td class=""px-6 py-4"">
                                            <div class=""text-sm text-gray-500"">
                                                ");
#nullable restore
#line 66 "/Users/rojaslcc/Projects/mi-pasteleria/mi-pasteleria/Pages/Baker/Stock.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.productType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </div>\n                                        </td>\n                                        <td class=\"px-6 py-4 text-sm text-gray-500\">\n                                            ");
#nullable restore
#line 70 "/Users/rojaslcc/Projects/mi-pasteleria/mi-pasteleria/Pages/Baker/Stock.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                    </tr>\n");
#nullable restore
#line 73 "/Users/rojaslcc/Projects/mi-pasteleria/mi-pasteleria/Pages/Baker/Stock.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<script>
    $(document).ready(function () {
        $('#myTable').DataTable();
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StockModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StockModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StockModel>)PageContext?.ViewData;
        public StockModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591