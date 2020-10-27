#pragma checksum "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Mapa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d1b4f9033f243c706d3421878ac50cb129e082"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea6_7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\_Imports.razor"
using Tarea6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\_Imports.razor"
using Tarea6_7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\_Imports.razor"
using Tarea6.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Mapa.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mapa")]
    public partial class Mapa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Mapa.razor"
 if (Tesoros == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h1>No hay Tesoros que ubicar!</h1>\r\n");
#nullable restore
#line 11 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Mapa.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "    <div id=\"myMap\" style=\"height:800px\"></div>\r\n");
#nullable restore
#line 15 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Mapa.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Mapa.razor"
       

    List<Tarea6.Models.Tesoro> Tesoros = new List<Tarea6.Models.Tesoro>();
    List<Tarea6.Models.Usuario> Usuarios = new List<Tarea6.Models.Usuario>();
    List<Tarea6.Models.Tesoro> Ubicaciones = new List<Tarea6.Models.Tesoro>();
    private Blazored.SessionStorage.ISessionStorageService _sessionStorage;
    string corr;
    int Id;

    protected override async Task OnInitializedAsync()
    {

        Tesoros = await servicio.GetTesoroAsync();
        Usuarios = await servicios.GetUsuariosAsync();
        _sessionStorage = sessionStorage;

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await Ubicacion();
            await Js.InvokeVoidAsync("GenerateMap", Ubicaciones);
        }
    }

    private async Task Ubicacion()
    {
        corr = await sessionStorage.GetItemAsync<string>("correo");
        var usu = Usuarios.FirstOrDefault(u => u.Correo.Equals(corr));
        if (usu == null)
        {

        }
        else
        {
            Id = usu.Id;
            Ubicaciones = Tesoros.Where(s => s.Usuario == Id).ToList();
      
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Tarea6.Servicios.UsuarioServicio servicios { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Tarea6.Servicios.Tesoroervicio servicio { get; set; }
    }
}
#pragma warning restore 1591
