using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea6.Data;
using Tarea6.Models;

namespace Tarea6.Servicios
{
    public class UsuarioServicio
    {
        private Tarea6DbContext tareaContext;

        public UsuarioServicio(Tarea6DbContext tareaContext)
        {
            this.tareaContext = tareaContext;
        }
        //lee
        public async Task<List<Usuario>> GetUsuariosAsync()
        {
            return await tareaContext.Usuarios.ToListAsync();
        }
        //escribe
        public async Task<Usuario> AgregarUsuario(Usuario usuario)
        {
            try
            {
                tareaContext.Usuarios.Add(usuario);
                await tareaContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return usuario;
        }
        //editar
        public async Task<Usuario> EditarUsuario(Usuario usuario)
        {
            
            var UsuarioExistente = tareaContext.Usuarios.First(a => a.Id == usuario.Id);
            tareaContext.Entry(usuario).CurrentValues.SetValues(usuario);
            //tareaContext.Update(usuario);
           await  tareaContext.SaveChangesAsync();
            
            
            return usuario;
        }
    }
}
