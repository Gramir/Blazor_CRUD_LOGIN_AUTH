#pragma checksum "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Inicio.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d8fd30f06186e7e30bd89697bafa7e82307f1b"
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
#line 4 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Inicio.razor"
using Tarea6.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/iniciar")]
    public partial class Inicio : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<a>Good try mate... Good try...</a>\r\n    ");
            }
            ));
            __builder.AddAttribute(4, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-5 bg-light m-2 justify-content-start");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<div class=\"p-3 mb-3 bg-primary text-white text-center\">Log In</div>\r\n\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.AddMarkupContent(13, "<label>Correo</label>\r\n                ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "email");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Inicio.razor"
                                                                       correo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => correo = __value, correo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.AddMarkupContent(24, "<label>Contraseña</label>\r\n                ");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "type", "password");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Inicio.razor"
                                                                    clave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => clave = __value, clave));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "text-center p-3 mb-3");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "class", "btn btn-info");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Inicio.razor"
                                                       Verificar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(38, "Log In");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Inicio.razor"
       

    List<Tarea6.Models.Usuario> Usuarios = new List<Tarea6.Models.Usuario>();


    string correo, clave;

    protected override async Task OnInitializedAsync()
    {
        Usuarios = await servicio.GetUsuariosAsync();

    }

    private async Task Verificar()
    {
        var usu = Usuarios.FirstOrDefault(u => u.Correo.Equals(correo));
        if (usu == null)
        {
            await js.InvokeAsync<bool>("confirm", "Correo Incorrecto");
        }
        else
        {
            var id = usu.Id;
            var pass = usu.Clave;
            if (pass != clave)
            {
                await js.InvokeAsync<bool>("confirm", "Contraseña Incorrecta");
            }
            else
            {
                await Correcto();
            }
        }
    }

    private async Task<bool> Correcto()
    {
        ((Authorize)auth).Logeado(correo);
        nav.NavigateTo("/");
        await sessionStorage.SetItemAsync("correo", correo);
        return await Task.FromResult(true);
    }

  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Tarea6.Servicios.UsuarioServicio servicio { get; set; }
    }
}
#pragma warning restore 1591
