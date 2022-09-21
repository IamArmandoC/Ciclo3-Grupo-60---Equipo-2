using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {

        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());


        static void Main(string[] args)
        {
            Console.WriteLine("Hola Enviamos Informacion a las tablas");
            //AddDueno(); 
            //AddVeterinario();
            BuscarDueno(4);
            
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Piedad",
                Apellidos = "DelSocorro",
                Direccion = "Manssion",
                Telefono = "312323",
                Correo = "Mansio@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Dc.Aurelio",
                Apellidos = "Cheverony",
                Direccion = "Club10",
                Telefono = "31532548",
                TarjetaProfesional = "466o63"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void BuscarDueno(int idDueno)
        { 
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres);

        }


    }
}
