using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;


namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVeterinario
    {

        //FUNCIONES CRUD//
        IEnumerable<Veterinario> GetAllVeterinarios(); //Metodo que Devuelve todos los dueños de la tabla
        Veterinario AddVeterinario(Veterinario veterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario);
        void DeleteVeterinario(int idVeterinario);
        Veterinario GetVeterinario(int idVeterinario);
        IEnumerable<Veterinario> GetVeterinariosPorFiltro(string filtro);
    }
}