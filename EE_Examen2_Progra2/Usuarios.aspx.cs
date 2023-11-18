using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        protected void fillGrid()
        {
            int success = Classes.Proc2BD.consultarUsuarios(dgUsuarios);

            if (success > 0) {
                Console.Write(success.ToString());   
            }
        }

        protected void add()
        {
            Classes.Usuarios user = new Classes.Usuarios();
            if(!txtNombre.Text.Trim().Equals(string.Empty))
            {
                user.Nombre = txtNombre.Text.Trim();
            }else { return; }

            if(!txtCorreo.Text.Trim().Equals(string.Empty))
            {
                user.CorreoElectronico = txtCorreo.Text.Trim();
            }else { return; }

            if (!txtTelefono.Text.Trim().Equals(string.Empty))
            {
                user.Telefono = txtTelefono.Text.Trim();
            }else { return; }

            if(user.agregarUsuario())
            {
                fillGrid();
            }

            
        }

        protected void delete()
        {
            Classes.Usuarios user = new Classes.Usuarios();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                user.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }

            if (user.borrarUsuario())
            {
                fillGrid();
            }
            
        }

        protected void modificar()
        {
            Classes.Usuarios user = new Classes.Usuarios();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                user.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }
            if (!txtNombre.Text.Trim().Equals(string.Empty))
            {
                user.Nombre = txtNombre.Text.Trim();
            }
            else { return; }

            if (!txtCorreo.Text.Trim().Equals(string.Empty))
            {
                user.CorreoElectronico = txtCorreo.Text.Trim();
            }
            else { return; }

            if (!txtTelefono.Text.Trim().Equals(string.Empty))
            {
                user.Telefono = txtTelefono.Text.Trim();
            }
            else { return; }

            if (user.modificarUsuario())
            {
                fillGrid();
            }
        }

        protected void consultar()
        {
            Classes.Usuarios user = new Classes.Usuarios();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                user.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }

            if (user.consultarUsuario(dgUsuarios))
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