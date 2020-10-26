#pragma checksum "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Registro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d43cc988c43ebaed7d02a95fefd8329ee7eabd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/registro")]
    public partial class Registro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Registro.razor"
       
    public Tarea6.Models.Usuario NuevoUsuario { get; set; } = new Tarea6.Models.Usuario();
    List<Tarea6.Models.Usuario> Usuarios = new List<Tarea6.Models.Usuario>();


    protected override async Task OnInitializedAsync()
    {
        Usuarios = await servicio.GetUsuariosAsync();
    }

    private async Task AgregarUsuario()
    {

        await servicio.AgregarUsuario(NuevoUsuario);
        await Js.InvokeAsync<bool>("confirm", "Usuario Guardado!");
        nav.NavigateTo("/iniciar");

    }

    private async Task Verificar()
    {

        if (NuevoUsuario.Correo == null || NuevoUsuario.Clave == null || NuevoUsuario.Nombre == null || NuevoUsuario.Color == null)
        {
            await Js.InvokeAsync<bool>("confirm", "Debe completar toda la informacion");
        }
        else
        {
            var match = Usuarios.Any(u => u.Correo == NuevoUsuario.Correo);
            if (match == true)
            {
                await Js.InvokeAsync<bool>("confirm", "Correo ya existe");
            }
            else
            {
               await AgregarUsuario();
            }

        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Tarea6.Servicios.UsuarioServicio servicio { get; set; }
    }
}
#pragma warning restore 1591
