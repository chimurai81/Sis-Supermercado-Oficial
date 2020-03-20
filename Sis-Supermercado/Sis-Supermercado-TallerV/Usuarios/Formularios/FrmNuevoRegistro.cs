using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios.Formularios
{
    public partial class FrmNuevoRegistro : Form
    {
        public FrmNuevoRegistro()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNuevoRegistro_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "NOMBRE")
            {
                txtnombre.Text = "";
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "NOMBRE";
            }
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {
                txtcontraseña.Text = "";
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "CONTRASEÑA";
            }
        }
    }
}
