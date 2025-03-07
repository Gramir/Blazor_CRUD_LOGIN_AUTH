#pragma checksum "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Perfil.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45f2b8d1747000724737e2e2441ab6618cf51515"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Perfil.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/perfil")]
    public partial class Perfil : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Perfil.razor"
       

    Tarea6.Models.Usuario editarUsuario = new Tarea6.Models.Usuario();
    Tarea6.Models.Usuario usu = new Tarea6.Models.Usuario();
    List<Tarea6.Models.Usuario> Usuarios = new List<Tarea6.Models.Usuario>();
    private Blazored.SessionStorage.ISessionStorageService _sessionStorage;
    string corr;

    protected override async Task OnInitializedAsync()
    {
        _sessionStorage = sessionStorage;
        await RefrescarUsuario();
    }

    private async Task RefrescarUsuario()
    {
        Usuarios = await servicios.GetUsuariosAsync();
        await FillUser();
    }

    private async Task FillUser()
    {
        corr = await sessionStorage.GetItemAsync<string>("correo");
        usu = Usuarios.FirstOrDefault(u => u.Correo.Equals(corr));
        if (usu == null)
        {
            await Js.InvokeVoidAsync("Reload");
        }
        else
        {
            editarUsuario.Id = usu.Id;
            editarUsuario.Nombre = usu.Nombre;
            editarUsuario.Clave = usu.Clave;
            editarUsuario.Color = usu.Color;
            editarUsuario.Correo = usu.Correo;
        }
    }

    private async Task Actualizar()
    {

        await servicios.EditarUsuario(editarUsuario);
        await Js.InvokeAsync<bool>("confirm", "Perfil Actualizado!");
        nav.NavigateTo("/");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Tarea6.Servicios.UsuarioServicio servicios { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
