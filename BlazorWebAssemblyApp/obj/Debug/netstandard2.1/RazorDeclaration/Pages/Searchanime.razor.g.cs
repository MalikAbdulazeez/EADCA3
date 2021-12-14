#pragma checksum "C:\Users\sonic\Documents\BlazorWebAssemblyApp\Pages\Searchanime.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54405414d3caf944e0de62d5801b05b1f4d48422"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AnimeApi
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sonic\Documents\BlazorWebAssemblyApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sonic\Documents\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sonic\Documents\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sonic\Documents\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sonic\Documents\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sonic\Documents\BlazorWebAssemblyApp\_Imports.razor"
using BlazorWebAssemblyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sonic\Documents\BlazorWebAssemblyApp\_Imports.razor"
using BlazorWebAssemblyApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sonic\Documents\BlazorWebAssemblyApp\Pages\Searchanime.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sonic\Documents\BlazorWebAssemblyApp\Pages\Searchanime.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\sonic\Documents\BlazorWebAssemblyApp\Pages\Searchanime.razor"
       

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
