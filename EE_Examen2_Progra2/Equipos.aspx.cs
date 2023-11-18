using EE_Examen2_Progra2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2
{
    public partial class Equipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillGrid();
                fillUsers();
            }
                
        }

        protected void fillGrid()
        {
            int success = Classes.Proc2BD.consultarEquipos(dgEquipos);

            if (success > 0)
            {
                Console.Write(success.ToString());
            }
        }

        protected void fillUsers()
        {
            int success = Classes.Proc2BD.ConsultarUsuariosEquipos(ddUsuario);
        }

        protected void add()
        {
            Classes.Equipos equipo = new Classes.Equipos();
            if (!txtTipoEquipo.Text.Trim().Equals(string.Empty))
            {
                equipo.TipoEquipo = txtTipoEquipo.Text.Trim();
            }
            else { return; }

            if (!txtModelo.Text.Trim().Equals(string.Empty))
            {
                equipo.Modelo = txtModelo.Text.Trim();
            }
            else { return; }

            if (!ddUsuario.SelectedValue.Trim().Equals(string.Empty))
            {
                equipo.UsuarioID = int.Parse(ddUsuario.SelectedValue.Trim());
            }
            else { return; }

            if (equipo.agregarEquipo())
            {
                fillGrid();
            }


        }

        protected void delete()
        {
            Classes.Usuarios equipo = new Classes.Usuarios();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                equipo.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }

            if (equipo.borrarUsuario())
            {
                fillGrid();
            }

        }

        protected void modificar()
        {
            Classes.Equipos equipo = new Classes.Equipos();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                equipo.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }
            if (!txtTipoEquipo.Text.Trim().Equals(string.Empty))
            {
                equipo.TipoEquipo = txtTipoEquipo.Text.Trim();
            }
            else { return; }

            if (!txtModelo.Text.Trim().Equals(string.Empty))
            {
                equipo.Modelo = txtModelo.Text.Trim();
            }
            else { return; }

           
                equipo.UsuarioID = int.Parse(ddUsuario.SelectedValue);

            if (equipo.modificarEquipo())
            {
                fillGrid();
            }
        }

        protected void consultar()
        {
            Classes.Usuarios equipo = new Classes.Usuarios();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                equipo.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }

            if (equipo.consultarUsuario(dgEquipos))
            {
                fillGrid();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            add();
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            delete();
        }

        protected void BtnModificar_Click(object senter, EventArgs e)
        {
            modificar();
        }

        protected void BtnConsultar_Click(object senter, EventArgs e)
        {
            consultar();
        }

        protected void BtnReset_Click(object senter, EventArgs e)
        {
            fillGrid();
        }
    }
}