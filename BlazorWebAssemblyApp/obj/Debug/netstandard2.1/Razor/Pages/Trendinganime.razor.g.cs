#pragma checksum "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bd3b9badeb4c5a62e602208e57915f6327b241c"
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
#line 3 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/trendinganime")]
    public partial class Trendinganime : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Trending Anime</h1>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
 if (animes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 14 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
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
#line 28 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
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
#line 31 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
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
#line 32 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
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
#line 33 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
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
#line 34 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
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
#line 35 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
                                  anime.attributes.posterImage.tiny

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "alt", 
#nullable restore
#line 35 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
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
#line 37 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
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
#line 40 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\sonic\Documents\EADCA3\BlazorWebAssemblyApp\Pages\Trendinganime.razor"
       

    private IList<Datum> animes;
    private AnimeRepository ar;
    private AnimeApi.TrendingAnime trending;

    protected override async Task OnInitializedAsync()
    {   
        ar = new AnimeRepository();
        trending = await ar.GetTrending();
        animes = trending.data;

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
