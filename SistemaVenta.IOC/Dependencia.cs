﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.DAL.Implementacion;
using SistemaVenta.DAL.Interfaces;
using SistemaVenta.BLL.Implementacion;
using SistemaVenta.BLL.Interfaces;

namespace SistemaVenta.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration Configuration)  //Inyeccion de dependencia
        {
            services.AddDbContext<DBVENTAContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CadenaSQL"));
            });
            services.AddTransient(typeof(IGenericRepository<>),typeof(GenericRepository<>));   //Trasient es para variar los valores de los parametros
            services.AddScoped<IVentaRepository, VentaRepository>();
            services.AddScoped<ICorreoService, CorreoService>();
            services.AddScoped<IFireBaseService, FireBaseService>();
            services.AddScoped<IUtilidadesService, UtilidadesService>();
            services.AddScoped<IRolService, RolService>();
            services.AddScoped<IUsusarioService, UsuarioService>();
        }
    }
}
