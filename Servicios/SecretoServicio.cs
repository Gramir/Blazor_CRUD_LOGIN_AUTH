using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea6.Data;
using Tarea6.Models;

namespace Tarea6.Servicios
{
    public class Tesoroervicio
    {
        private Tarea6DbContext tareaContext;

        public Tesoroervicio(Tarea6DbContext tareaContext)
        {
            this.tareaContext = tareaContext;
        }
        //lee
        public async Task<List<Tesoro>> GetTesoroAsync()
        {
            return await tareaContext.Tesoros.ToListAsync();
        }
        //escribe
        public async Task<Tesoro> AgregarTesoro(Tesoro Tesoro)
        {
            try
            {
                tareaContext.Tesoros.Add(Tesoro);
                await tareaContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Tesoro;
        }
        //edita
        public async Task<Tesoro> EditarTesoro(Tesoro Tesoro)
        {
            try
            {
                var TesoroExistete = tareaContext.Tesoros.FirstOrDefault(a => a.Id == Tesoro.Id);
                if (TesoroExistete != null)
                {
                    tareaContext.Update(Tesoro);
                    await tareaContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Tesoro;
        }
        //borra
        public async Task BorrarTesoro(Tesoro Tesoro)
        {
            try
            {
                tareaContext.Tesoros.Remove(Tesoro);
                await tareaContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    
}
}
