using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2.Classes
{
    public class Equipos
    {
        public int Id { get; set; }
        public string TipoEquipo { get; set; }
        public string Modelo { get; set; }
        public int UsuarioID { get; set; }

        public Equipos() { 
            TipoEquipo = string.Empty;
            Modelo = string.Empty;
        }

        public Equipos(int id, string tipoEquipo, string modelo, int usuarioID)
        {
            Id = id;
            TipoEquipo = tipoEquipo;
            Modelo = modelo;
            UsuarioID = usuarioID;
        }

        public bool agregarEquipo()
        {
            int success = Proc2BD.insertarEquipo(TipoEquipo, Modelo, UsuarioID);

            return success > 0;
        }

        public bool borrarEquipo()
        {
            int success = Proc2BD.borrarEquiposPorId(Id);

            return success > 0;
        }

        public bool modificarEquipo()
        {
            int success = Proc2BD.actualizarEquipoPorId(Id, TipoEquipo, Modelo, UsuarioID);

            return success > 0;
        }

        public bool consultarUsuario(GridView dg)
        {
            int success = Proc2BD.consultarEquiposPorId(Id, dg);

            return success > 0;
        }
    }
}