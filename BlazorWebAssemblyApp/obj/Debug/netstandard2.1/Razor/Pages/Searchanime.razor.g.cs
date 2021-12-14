#pragma checksum "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54405414d3caf944e0de62d5801b05b1f4d48422"
// <auto-generated/>
#pragma warning disable 1591
namespace AnimeApi
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\_Imports.razor"
using BlazorWebAssemblyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\_Imports.razor"
using BlazorWebAssemblyApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/searchanime")]
    public partial class Searchanime : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Search Anime</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
 if (animes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>No Data...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Type</th>\r\n                <th>Rating</th>\r\n                <th>Title</th>\r\n                <th>Synopsis</th>\r\n                <th>Image</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 27 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
             foreach (var anime in animes)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
                         anime.attributes.subtype

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
                         anime.attributes.averageRating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
                         anime.attributes.titles.en

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 33 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
                         anime.attributes.synopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "img");
            __builder.AddAttribute(27, "src", 
#nullable restore
#line 34 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
                                  anime.attributes.posterImage.tiny

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "alt", 
#nullable restore
#line 34 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
                                                                         anime.attributes.titles.en

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "style", "max-height:280; max-width:180");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 36 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 39 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
                                 searchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTerm = __value, searchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "value", "Search");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
                                               SearchAnime

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Searchanime.razor"
       

    private string searchTerm;
    private IList<Datum> animes;
    private AnimeApi.GetAnime result;
    private AnimeRepository ar;

    async Task SearchAnime()
    {

        ar = new AnimeRepository();
        try
        {
            result = await ar.GetAnime(searchTerm);

        }
        catch (Exception ex)
        {

            if (ex is AnimeApi.CustomException < AnimeApi.InvalidLangauge>|| ex is AnimeApi.CustomException<AnimeApi.NoName>)
            {

                await JsRuntime.InvokeVoidAsync("alert", ex.Message);
            }

            else if (ex is JsonException)
            {

                await JsRuntime.InvokeVoidAsync("alert", "Json error hasn't been fixed for certain animes yet.");
            }
        }


        animes = result.data;

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
