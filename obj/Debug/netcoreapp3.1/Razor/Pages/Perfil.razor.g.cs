#pragma checksum "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Perfil.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45f2b8d1747000724737e2e2441ab6618cf51515"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-5 bg-light m-2 justify-content-start");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"p-3 mb-3 bg-primary text-white text-center\">Editar Perfil</div>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Perfil.razor"
                      editarUsuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.AddMarkupContent(11, "<label>Cambiar Nombre</label>\r\n            ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "id", "nombre");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Perfil.razor"
                                                                        usu.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usu.Nombre = __value, usu.Nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.AddMarkupContent(23, "<label>Cambiar Contraseña</label>\r\n            ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "id", "contraseña");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Perfil.razor"
                                                                                usu.Clave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usu.Clave = __value, usu.Clave));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.AddMarkupContent(35, "<label>Cambiar tu color favorito</label>\r\n            ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "type", "color");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Perfil.razor"
                                                             usu.Color

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usu.Color = __value, usu.Color));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "text-center p-3 mb-3");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "class", "btn btn-info");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea6_7\Pages\Perfil.razor"
                                                   Actualizar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(49, " Guardar Cambios");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
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
