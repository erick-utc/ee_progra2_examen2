using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2.Classes
{
    public class Tecnicos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        public Tecnicos() {
            Nombre = string.Empty;
            Especialidad = string.Empty;
        }

        public Tecnicos(int id, string nombre, string especialidad)
        {
            Id = id;
            Nombre = nombre;
            Especialidad = especialidad;
        }

        public bool agregarTecnico()
        {
            int success = Proc2BD.insertarTecnico(Nombre, Especialidad);

            return success > 0;
        }

        public bool borrarTecnico()
        {
            int success = Proc2BD.borrarTecnicosPorId(Id);

            return success > 0;
        }

        public bool modificarTecnico()
        {
            int success = Proc2BD.actualizarTecnicoPorId(Id, Nombre, Especialidad);

            return success > 0;
        }

        public bool consultarTecnico(GridView dg)
        {
            int success = Proc2BD.consultarTecnicosPorId(Id, dg);

            return success > 0;
        }
    }
}